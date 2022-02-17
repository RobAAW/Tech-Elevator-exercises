-- 2. The names and birthdays of actors in "The Fifth Element" (15 rows)
SELECT p.person_name, p.birthday
FROM person p
JOIN movie_actor ma
ON p.person_id = ma.actor_id
JOIN movie m
ON ma.movie_id = m.movie_id
WHERE m.title = 'The Fifth Element';

