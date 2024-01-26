# Write your MySQL query statement below

SELECT a.product_id, 
CASE WHEN units IS NULL THEN 0
ELSE ROUND(SUM(sales)/SUM(units),2) END average_price 
FROM
(
SELECT p.product_id, s.units, price*units sales FROM Prices p
LEFT JOIN UnitsSold s
ON p.product_id = s.product_id
WHERE s.purchase_date >= p.start_date AND s.purchase_date <= p.end_date OR s.units IS NULL
) AS a
GROUP BY product_id

-- SELECT s.product_id, s.units, price*units sales FROM Prices p
-- LEFT JOIN UnitsSold s
-- ON p.product_id = s.product_id

