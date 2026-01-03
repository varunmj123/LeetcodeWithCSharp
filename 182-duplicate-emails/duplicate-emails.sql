/* Write your T-SQL query statement below */
Select p.email
from person p
GROUP BY p.email
HAVING COUNT(*) > 1