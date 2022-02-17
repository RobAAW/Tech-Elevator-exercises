-- 14. The name and date established of the top 10 oldest national parks.
-- Order the results with the oldest park first.
-- (10 rows)
SELECT TOP 10 *
FROM 
(
SELECT park_name, date_established
FROM park
) oldest_parks
ORDER BY date_established;

 


