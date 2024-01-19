# Write your MySQL query statement below


SELECT user_id, CONCAT(UPPER(SUBSTRING(NAME, 1, 1)), LOWER(SUBSTRING(NAME, 2))) name
FROM
Users
ORDER BY
user_id








