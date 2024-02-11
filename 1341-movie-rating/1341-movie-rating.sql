# Write your MySQL query statement below


WITH details AS (
    SELECT m.title, r.* FROM Movies m RIGHT JOIN MovieRating r ON m.movie_id = r.movie_id 
),
list AS (
    SELECT u.name, d.* FROM Users u RIGHT JOIN details d ON u.user_id = d.user_id
),
nm AS (
    SELECT COUNT(*), name FROM list GROUP BY user_id ORDER BY COUNT(*) DESC, name limit 1
),
hr AS (
    SELECT AVG(rating), title FROM list WHERE MONTH(created_at) = 2 AND YEAR(created_at) = 2020 GROUP BY movie_id ORDER BY AVG(rating) DESC, title limit 1
)

SELECT results FROM (
select name AS results from nm 
UNION ALL
SELECT title AS results from hr 
) AS a


