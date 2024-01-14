# Write your MySQL query statement below
SELECT employee_id, name, reports_count, average_age
FROM Employees e LEFT JOIN 
(
    SELECT
    reports_to,
    ROUND(AVG(age), 0) average_age,
    COUNT(*) reports_count
    FROM Employees
GROUP BY reports_to
) AS t1
ON e.employee_id = t1.reports_to
WHERE reports_count IS NOT NULL
ORDER BY employee_id