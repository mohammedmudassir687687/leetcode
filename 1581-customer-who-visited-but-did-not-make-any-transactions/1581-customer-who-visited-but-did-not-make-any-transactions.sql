# Write your MySQL query statement below


WITH jnd AS (
    SELECT v.*, t.transaction_id FROM
    Visits v LEFT JOIN Transactions t
    ON v.visit_id = t.visit_id
)


SELECT customer_id, COUNT(*) count_no_trans FROM jnd 
WHERE transaction_id IS NULL
GROUP BY customer_id