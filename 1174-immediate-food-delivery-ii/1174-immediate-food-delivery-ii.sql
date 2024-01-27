# Write your MySQL query statement below

WITH rt AS (
SELECT *, ROW_NUMBER() OVER (PARTITION BY customer_id ORDER BY customer_id, order_date) rn
FROM Delivery)

SELECT ROUND(100*SUM(CASE WHEN order_date = customer_pref_delivery_date THEN 1 ELSE 0 END)/COUNT(*),2) immediate_percentage
FROM rt
WHERE rn = 1

