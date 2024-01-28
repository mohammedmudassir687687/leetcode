# Write your MySQL query statement below


SELECT customer_id FROM (
SELECT customer_id, COUNT(DISTINCT product_key) c
FROM Customer
GROUP BY customer_id
) as a
WHERE a.c = (SELECT COUNT(*) FROM Product)

