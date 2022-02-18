-- INNER JOIN

-- Write a query to retrieve the name and state abbreviation for the 2 cities named "Columbus" in the database
SELECT city_name, state_abbreviation
FROM city
WHERE city_name = 'Columbus';

-- Modify the previous query to retrieve the names of the states (rather than their abbreviations).
SELECT state.state_name
FROM city
INNER JOIN state
ON city.state_abbreviation = state.state_abbreviation
WHERE city.city_name = 'Columbus';


-- Write a query to retrieve the names of all the national parks with their state abbreviations.
-- (Some parks will appear more than once in the results, because they cross state boundaries.)

SELECT park.park_name, park_state.state_abbreviation
FROM park
JOIN park_state
ON park.park_id = park_state.park_id;



-- The park_state table is an associative table that can be used to connect the park and state tables.
-- Modify the previous query to retrieve the names of the states rather than their abbreviations.

SELECT park.park_name, s.state_name
FROM park
JOIN park_state
ON park.park_id = park_state.park_id
JOIN state s
ON park_state.state_abbreviation = s.state_abbreviation;



-- Modify the previous query to include the name of the state's capital city.

SELECT park.park_name, s.state_name, c.city_name
FROM park
JOIN park_state
ON park.park_id = park_state.park_id
JOIN state s
ON park_state.state_abbreviation = s.state_abbreviation
LEFT JOIN city c
ON s.capital = c.city_id;



-- Modify the previous query to include the area of each park.

SELECT park.park_name, s.state_name, c.city_name, park.area
FROM park
JOIN park_state
ON park.park_id = park_state.park_id
JOIN state s
ON park_state.state_abbreviation = s.state_abbreviation
LEFT JOIN city c
ON s.capital = c.city_id;


-- Write a query to retrieve the names and populations of all the cities in the Midwest census region.
SELECT c.city_name, c.population
FROM city c
JOIN state s
ON c.state_abbreviation = s.state_abbreviation
WHERE s.census_region = 'Midwest';

-- Write a query to retrieve the number of cities in the city table for each state in the Midwest census region.

SELECT s.state_name, COUNT(*) AS num_cities
FROM city c
JOIN state s
ON c.state_abbreviation = s.state_abbreviation
WHERE s.census_region = 'Midwest'
GROUP BY s.state_name;

-- Modify the previous query to sort the results by the number of cities in descending order.

SELECT s.state_name, COUNT(*) AS num_cities
FROM city c
JOIN state s
ON c.state_abbreviation = s.state_abbreviation
WHERE s.census_region = 'Midwest'
GROUP BY s.state_name
ORDER BY num_cities DESC;


-- LEFT JOIN

-- Write a query to retrieve the state name and the earliest date a park was established in that state (or territory) for every record in the state table that has park records associated with it.

SELECT s.state_name, MIN(p.date_established)
FROM state s
JOIN park_state ps
ON s.state_abbreviation = ps.state_abbreviation
JOIN park p
ON ps.park_id = p.park_id
GROUP BY s.state_name;

-- Modify the previous query so the results include entries for all the records in the state table, even if they have no park records associated with them.

SELECT s.state_name, MIN(p.date_established)
FROM state s
LEFT JOIN park_state ps
ON s.state_abbreviation = ps.state_abbreviation
JOIN park p
ON ps.park_id = p.park_id
GROUP BY s.state_name;


-- UNION

-- Write a query to retrieve all the place names in the city and state tables that begin with "W" sorted alphabetically. (Washington is the name of a city and a state--how many times does it appear in the results?)

SELECT city_name FROM city WHERE city_name LIKE 'W%'
UNION ALL
SELECT state_name FROM state WHERE state_name LIKE 'W%';
 

-- Modify the previous query to include a column that indicates whether the place is a city or state.

SELECT 'City' AS place_type, city_name 
FROM city 
WHERE city_name LIKE 'W%'

UNION

SELECT 'State' AS place_type, state_name 
FROM state 
WHERE state_name LIKE 'W%';


-- MovieDB
-- After running the script to set up the MovieDB database, make sure it is selected in SSMS and confirm it is working correctly by writing queries to retrieve...

-- The names of all the movie genres
SELECT *
FROM genre;


-- The titles of all the Comedy movies
SELECT m.title
FROM genre g
JOIN movie_genre mg
ON g.genre_name = mg.genre_id
JOIN movie m
ON mg.movie_id = m.movie_id
WHERE g.genre_name = 'Comedy';
