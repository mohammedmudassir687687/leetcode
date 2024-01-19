# Write your MySQL query statement below


SELECT sell_date, COUNT(*) AS num_sold, GROUP_CONCAT(product ORDER BY product) products
FROM
(SELECT sell_date, product, row_number() over (partition by sell_date, product) rn from Activities) as t1 WHERE t1.rn = 1
GROUP BY sell_date












