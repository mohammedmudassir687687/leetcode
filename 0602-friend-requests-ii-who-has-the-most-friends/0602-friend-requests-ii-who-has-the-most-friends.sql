# Write your MySQL query statement below


WITH rq AS (
SELECT COUNT(*) c, requester_id FROM RequestAccepted GROUP BY requester_id ORDER BY COUNT(*) 
    ),
    ac AS (
    SELECT COUNT(*) c, accepter_id as requester_id FROM RequestAccepted GROUP BY accepter_id ORDER BY COUNT(*)
    ),
    list AS (select * from rq UNION ALL SELECT * FROM ac)
    
    select requester_id id, sum(c) num from list GROUP BY requester_id ORDER BY num DESC limit 1
    
