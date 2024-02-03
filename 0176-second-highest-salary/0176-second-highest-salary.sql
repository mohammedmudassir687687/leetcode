# Write your MySQL query statement below

WITH cte AS (
SELECT DISTINCT salary FROM Employee ORDER BY salary DESC
)

SELECT CASE WHEN COUNT(*) = 0 THEN NULL ELSE salary END SecondHighestSalary FROM
(SELECT *, ROW_NUMBER() OVER() rn FROM cte) AS innerquery
WHERE innerquery.rn = 2



# SELECT CASE WHEN COUNT(*) = 0 THEN NULL ELSE salary END SecondHighestSalary FROM
# (SELECT DISTINCT salary, ROW_NUMBER() OVER(ORDER BY salary DESC) rn from Employee
# ORDER BY salary DESC) AS a
# WHERE a.rn = 2