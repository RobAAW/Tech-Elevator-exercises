-- 21. For every person in the person table with the first name of "George", list the number of movies they've been in--include all Georges, 
--even those that have not appeared in any movies. Display the names in alphabetical order. (59 rows)
-- Name the count column 'num_of_movies'

SELECT p.person_name, COUNT(m.title) AS num_of_movies
FROM person p
LEFT JOIN movie_actor ma
ON p.person_id = ma.actor_id
LEFT JOIN movie m
ON ma.movie_id = m.movie_id
WHERE p.person_name LIKE 'George %'
GROUP BY p.person_name;



SELECT person_name
FROM person
WHERE person_name LIKE 'George %'
ORDER BY person_name;


SELECT *
FROM movie;