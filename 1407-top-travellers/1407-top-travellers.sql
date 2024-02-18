# Write your MySQL query statement below


WITH jnd AS (
    SELECT name, case when distance is null then 0 else sum(distance) end travelled_distance from Users u left join Rides r on u.id = r.user_id
    group by user_id
    order by travelled_distance desc, name
)


select * from jnd