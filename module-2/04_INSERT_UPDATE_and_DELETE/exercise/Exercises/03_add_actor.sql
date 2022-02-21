-- 3. Did you know Eric Stoltz was originally cast as Marty McFly in "Back to the Future"? Add Eric Stoltz to the list of actors for "Back to the Future" (1 row)

INSERT INTO movie_actor (movie_id, actor_id)
VALUES (105, 7036);


SELECT *
FROM movie_actor
WHERE actor_id = '7036';


SELECT *
FROM person
WHERE person_name LIKE 'Eric%';

SELECT * 
FROM movie
WHERE title LIKE 'Back%';