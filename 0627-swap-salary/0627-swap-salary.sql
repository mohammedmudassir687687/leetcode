# Write your MySQL query statement below


UPDATE Salary SET sex = CASE WHEN sex LIKE 'm' THEN 'f' ELSE 'm' END
