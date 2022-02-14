SELECT TOP(1) Salary * Months, COUNT(*)
FROM Employee
    GROUP BY Salary * Months
    ORDER BY Salary * Months DESC