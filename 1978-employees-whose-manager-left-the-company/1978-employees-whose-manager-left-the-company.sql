# Write your MySQL query statement below



# SELECT employee_id e, manager_id FROM Employees WHERE salary < 30000 
select employee_id from(
SELECT employee_id, m FROM
(SELECT employee_id, manager_id as m, salary,
CASE WHEN (select COUNT(employee_id) from employees where employee_id = m) = 0 THEN 'n' ELSE 'y' END as present         
FROM Employees
WHERE salary < 30000) AS T1
WHERE present = 'n'
and m IS NOT NULL) as t2
order by employee_id
