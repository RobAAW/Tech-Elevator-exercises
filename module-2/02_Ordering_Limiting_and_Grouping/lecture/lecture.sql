-- ORDERING RESULTS

-- Populations of all states from largest to smallest.
SELECT *
FROM state
ORDER BY population desc;

-- States sorted alphabetically (A-Z) within their census region. The census regions are sorted in reverse alphabetical (Z-A) order.
SELECT *
FROM state
ORDER By census_region DESC, state_name;

-- The biggest park by area
SELECT TOP 1 *
FROM park
ORDER BY area DESC;


-- LIMITING RESULTS

-- The 10 largest cities by populations
SELECT TOP 10 *
FROM city
ORDER BY population DESC;


-- The 20 oldest parks from oldest to youngest in years, sorted alphabetically by name.
SELECT TOP 20
	park_name, 
	YEAR(GETDATE()) - YEAR(date_established) AS park_age_years
FROM park
ORDER BY park_age_years DESC, park_name;



-- CONCATENATING OUTPUTS

-- All city names and their state abbreviation.


-- All park names and area
SELECT park_name + ' ' + CAST(area AS VARCHAR) AS park_area_name
FROM park;

-- The census region and state name of all states in the West & Midwest sorted in ascending order.
SELECT census_region, state_name
FROM state
WHERE census_region IN ('West' , 'Midwest')
ORDER By state_name;


-- AGGREGATE FUNCTIONS

-- Average population across all the states. Note the use of alias, common with aggregated values.
SELECT AVG(population) AS avg_population
FROM state;

-- Total population in the West and South census regions
SELECT SUM(population) AS total_west_south
FROM state
WHERE census_region IN ('West', 'South');

-- The number of cities with populations greater than 1 million
SELECT COUNT(city_name)
FROM city
WHERE population > 1000000;

-- The number of state nicknames.
SELECT COUNT(state_nickname) AS count_nicknames
FROM state;


-- The area of the smallest and largest parks.
SELECT MIN(area) AS smallest_park, MAX(area) AS largest_park
FROM park;


-- GROUP BY

-- Count the number of cities in each state, ordered from most cities to least.
SELECT state_abbreviation, COUNT(*) AS Number_of_cities
FROM city
GROUP BY state_abbreviation;

-- Determine the average park area depending upon whether parks allow camping or not.
SELECT has_camping, AVG(area) AS avg_area
FROM park
GROUP BY has_camping;

-- Sum of the population of cities in each state ordered by state abbreviation.


-- The smallest city population in each state ordered by city population.



-- Miscelleneous

-- While you can use TOP to limit the number of results returned by a query,
-- it's recommended to use OFFSET and FETCH if you want to get
-- "pages" of results.
-- For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)



-- SUBQUERIES (optional)

-- Include state name rather than the state abbreviation while counting the number of cities in each state,
SELECT state_abbreviation,
COUNT(*) AS city_count,
(
SELECT state_name
FROM state
WHERE state.state_abbreviation = city.state_abbreviation
) AS state_name
FROM city
GROUP BY state_abbreviation;

-- Include the names of the smallest and largest parks
SELECT *
FROM park,
(
SELECT MIN(area) AS smallest_park, MAX(area) AS largest_park
FROM park
) smallest_and_largest
WHERE park.area = smallest_park
OR park.area = largest_park
ORDER BY park.park_id;


-- List the capital cities for the states in the Northeast census region.
SELECT *
FROM city
WHERE city_id IN 
(
SELECT capital
FROM state
WHERE census_region = 'Northeast'
);
