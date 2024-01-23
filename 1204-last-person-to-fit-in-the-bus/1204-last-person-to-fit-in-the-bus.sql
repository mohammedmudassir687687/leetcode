# Write your MySQL query statement below

select person_name from (
select
  turn,
  person_name,
  person_id,
  weight,
  sum(weight) over (order by turn) as cumulative_sum
from queue) as a
where cumulative_sum <= 1000
order by cumulative_sum desc
limit 1;
