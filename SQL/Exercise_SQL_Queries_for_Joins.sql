USE NORTHWND

-- 1. Create a report for all the orders of 1996 and their Customers (152 rows)
SELECT *
FROM Customers
INNER JOIN Orders ON Orders.CustomerID = Customers.CustomerID
WHERE Orders.OrderDate BETWEEN '1996-01-01' AND '1996-12-31';

-- 2. Create a report that shows the number of	employees and customers from each city that has employees in it (5 rows)
SELECT Employees.City, COUNT(DISTINCT Employees.EmployeeID) AS numEmployees, COUNT(DISTINCT Customers.CustomerID) AS numEmployees
FROM Customers
RIGHT JOIN Employees ON Customers.City = Employees.City
GROUP BY Employees.City, Customers.City

--3. Create a report that shows the number of employees and customers from each city that has customers in it.
SELECT Customers.City, COUNT(DISTINCT Employees.EmployeeID) AS numEmployees, COUNT(DISTINCT Customers.CustomerID) AS numEmployees
FROM Customers
LEFT JOIN Employees ON Customers.City = Employees.City
GROUP BY Customers.City

-- 4. Create a report that shows the number of employees and customers from each city.
SELECT Customers.City, COUNT(DISTINCT Employees.EmployeeID) AS numEmployees, COUNT(DISTINCT Customers.CustomerID) AS numEmployees
FROM Customers
FULL JOIN Employees ON Customers.City = Employees.City
GROUP BY Customers.City, Employees.City
 
