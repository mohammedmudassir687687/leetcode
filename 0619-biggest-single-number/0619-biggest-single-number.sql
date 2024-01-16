# Write your MySQL query statement below


SELECT 
(CASE WHEN COUNT(*) = 0 THEN NULL ELSE num END) num
FROM
(
SELECT num
FROM MyNumbers
GROUP BY num
HAVING COUNT(*) = 1
ORDER BY num DESC
LIMIT 1
    ) AS t1
