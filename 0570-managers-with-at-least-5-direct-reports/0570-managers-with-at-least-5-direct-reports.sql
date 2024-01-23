# Write your MySQL query statement below


select e.name from employee e LEFT JOIN (
select managerId from employee
where managerId is not null
group by managerId
having count(*) >= 5 
) AS f
ON e.id = f.managerId
where f.managerId is not null
