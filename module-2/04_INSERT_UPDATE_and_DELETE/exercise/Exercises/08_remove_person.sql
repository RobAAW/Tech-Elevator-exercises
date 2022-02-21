-- 8. Remove "Penn Jillette" from the person table 
-- You'll have to remove data from another table before you can make him "disappear" (Get it? Because he's a magician...) (1 row each)

SELECT person_name
FROM person p
WHERE person_name LIKE '%Penn%';


SELECT *
FROM movie_actor
WHERE actor_id = 37221;

SELECT *
FROM movie_actor
WHERE movie_id = 862;

BEGIN TRANSACTION;
DELETE FROM movie_actor
WHERE actor_id = (SELECT person_id FROM person WHERE person_name = 'Penn Jillette')
DELETE FROM person
WHERE person_name = 'Penn Jillette';
COMMIT;