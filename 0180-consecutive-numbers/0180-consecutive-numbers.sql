# Write your MySQL query statement below

WITH cte AS 
(SELECT *, LEAD(num, 1) OVER() next_1, LEAD(num, 2) OVER() next_2
FROM logs)


SELECT DISTINCT num ConsecutiveNums
FROM cte
WHERE num = next_1 AND num = next_2