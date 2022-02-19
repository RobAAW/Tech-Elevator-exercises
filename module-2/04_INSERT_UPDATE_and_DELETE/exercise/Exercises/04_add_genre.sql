-- 4. Add a "Sports" genre to the genre table. Add the movie "Coach Carter" to the newly created genre. (1 row each)

INSERT INTO genre (genre_name)
OUTPUT INSERTED.genre_id
VALUES ('Sports');


INSERT INTO movie_genre (movie_id, genre_id)
VALUES (7214, 11771); 



SELECT *
FROM movie_genre;