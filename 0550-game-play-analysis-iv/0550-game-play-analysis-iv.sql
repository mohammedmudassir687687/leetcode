# Write your MySQL query statement below

WITH vld AS ( 
SELECT player_id,
(CASE WHEN player_id = LEAD(player_id) OVER(ORDER BY player_id, event_date) AND DATEDIFF(event_date, LEAD(event_date) OVER(ORDER BY player_id, event_date)) = -1 THEN 1 ELSE 0 END) valid,
ROW_NUMBER() OVER(PARTITION BY player_id) rn
FROM Activity
ORDER BY player_id, event_date
),
grp AS (SELECT player_id, SUM(DISTINCT valid) grptotal FROM vld WHERE rn = 1 GROUP BY player_id )


-- SELECT * FROM grp
SELECT ROUND(SUM(grptotal)/COUNT(*),2) fraction FROM grp