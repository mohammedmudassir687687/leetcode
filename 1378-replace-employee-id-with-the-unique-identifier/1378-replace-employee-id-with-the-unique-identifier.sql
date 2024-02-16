# Write your MySQL query statement below


WITH joined AS (
    SELECT e.id, e.name, u.unique_id FROM Employees e LEFT JOIN EmployeeUNI u
    ON e.id = u.id
)

SELECT unique_id, name FROM joined