# Write your MySQL query statement below
WITH updated_prices AS
(SELECT *, (CASE WHEN change_date <= '2019-08-16' THEN new_price ELSE 10 END) updated_price
FROM Products
ORDER BY product_id, change_date DESC)


SELECT product_id, new_price price FROM
(
    SELECT *, ROW_NUMBER() OVER (PARTITION BY product_id ORDER BY product_id, change_date DESC) rn FROM updated_prices WHERE change_date <= '2019-08-16'
) AS t1
WHERE t1.rn = 1
UNION
SELECT product_id, 10 price FROM updated_prices WHERE product_id IN
(
SELECT product_id FROM updated_prices GROUP BY product_id
HAVING SUM(CASE WHEN change_date <= "2019-08-16" THEN 1 ELSE 0 END) = 0
)