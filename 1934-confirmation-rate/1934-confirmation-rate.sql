# Write your MySQL query statement below



SELECT s.user_id user_id, CASE WHEN c.confirmation_rate IS NULL THEN 0 ELSE c.confirmation_rate END confirmation_rate 
FROM Signups s LEFT JOIN 
(
    SELECT user_id, ROUND(SUM(CASE WHEN action = 'confirmed' THEN 1 ELSE 0 END)/COUNT(action),2) confirmation_rate FROM Confirmations GROUP BY user_id
) AS c
ON s.user_id = c.user_id