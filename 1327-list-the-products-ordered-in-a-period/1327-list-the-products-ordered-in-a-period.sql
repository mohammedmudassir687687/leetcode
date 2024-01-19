# Write your MySQL query statement below


SELECT p.product_name, o.sumunit unit
FROM Products p LEFT JOIN 
(
    SELECT product_id, SUM(unit) sumunit, od
    FROM
    (
        SELECT product_id, od, unit FROM (
            SELECT product_id, CONCAT(EXTRACT(YEAR FROM order_date), '-', EXTRACT(MONTH FROM order_date)) od, unit
            FROM Orders
        ) as t1
    ) as t2
    WHERE t2.od='2020-2'
    GROUP BY t2.product_id
) as o
ON p.product_id = o.product_id
WHERE o.sumunit >= 100




