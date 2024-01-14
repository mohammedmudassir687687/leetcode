# Write your MySQL query statement below




SELECT contest_id, ROUND(100 * COUNT(*)/(SELECT Count(user_id) FROM Users), 2) AS Percentage FROM Register
GROUP BY contest_id
ORDER BY Percentage DESC, contest_id