# Write your MySQL query statement below


WITH jnd AS (
    SELECT u.name, t.* FROM Users u RIGHT JOIN Transactions t
    ON u.account = t.account
)

SELECT name, balance FROM (
SELECT DISTINCT name, SUM(amount) OVER (PARTITION BY account) balance FROM jnd 
) AS a
WHERE balance > 10000



