# Write your MySQL query statement below




SELECT CONCAT(EXTRACT(YEAR FROM trans_date), '-', CASE WHEN EXTRACT(MONTH FROM trans_date) < 10 THEN CONCAT('0', EXTRACT(MONTH FROM trans_date)) ELSE EXTRACT(MONTH FROM trans_date) END) month, country, COUNT(state) trans_count, 
SUM(CASE WHEN state = 'approved' THEN 1 ELSE 0 END) approved_count, SUM(amount) trans_total_amount,
SUM(CASE WHEN state = 'approved' THEN amount ELSE 0 END) approved_total_amount
FROM Transactions
GROUP BY country, month
