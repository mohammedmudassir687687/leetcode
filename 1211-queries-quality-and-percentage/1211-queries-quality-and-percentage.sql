# Write your MySQL query statement below

SELECT t1.query_name, ROUND(t1.quality, 2) AS quality, ROUND(100 * t2.lt3/t1.total, 2) AS poor_query_percentage
FROM
(SELECT query_name, ROUND(AVG(rating/position),2) AS quality, COUNT(*) AS total
FROM Queries
GROUP BY query_name) AS t1 
LEFT JOIN 
(SELECT query_name, SUM(if(rating < 3, 1, 0)) AS lt3
FROM Queries
 GROUP BY query_name
) AS t2
ON t1.query_name = t2.query_name
WHERE t1.query_name IS NOT NULL


# SELECT query_name, quality, ROUND(100*lt3/total,2) AS poor_query_percentage
# FROM
# (SELECT query_name, ROUND(AVG(rating/position),2) AS quality, COUNT(*) AS total, 
# CASE WHEN (SELECT COUNT(*) FROM Queries WHERE rating < 3 GROUP BY query_name) > 0
# THEN COUNT(*)
# ELSE 0
# END AS lt3
# FROM Queries
# GROUP BY query_name) AS t1


