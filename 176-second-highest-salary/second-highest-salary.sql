/* Write your T-SQL query statement below */
-- Select TOP 1 salary AS SecondHighestSalary
-- from (
--     Select DISTINCT Top 2 e.salary 
--     from Employee e 
--     ORDER BY e.salary DESC
-- ) t
-- ORDER BY salary ASC 

SELECT (
    SELECT DISTINCT salary
    FROM Employee
    ORDER BY salary DESC
    OFFSET 1 ROW
    FETCH NEXT 1 ROW ONLY
) AS SecondHighestSalary;
