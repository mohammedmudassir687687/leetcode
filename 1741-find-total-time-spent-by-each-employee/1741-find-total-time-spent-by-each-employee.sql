# Write your MySQL query statement below


WITH staytable AS (
SELECT *, out_time - in_time AS stay FROM Employees
)

SELECT event_day AS day, emp_id, SUM(stay) AS total_time FROM staytable GROUP BY event_day, emp_id