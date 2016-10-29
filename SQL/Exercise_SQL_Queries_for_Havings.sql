--1. Create a report that shows the order ids and the associated employee names for orders that shipped after the required date (37 rows)
SELECT Orders.OrderID, Employees.FirstName, Employees.LastName
FROM Employees
	INNER JOIN Orders ON Employees.EmployeeID = Orders.EmployeeID
WHERE Orders.RequiredDate < Orders.ShippedDate
ORDER BY Employees.LastName, Employees.FirstName;


--2. Create a report that shows the total quantity of products (from the Order_Details table) ordered. Only show records for products for which the quantity ordered is fewer than 200 (5 rows)

SELECT Products.ProductName, SUM([Order Details].Quantity) AS [Total Quantity]
FROM [Order Details]
	INNER JOIN Products ON Products.ProductID = [Order Details].ProductID
GROUP BY Products.ProductName
HAVING SUM (Quantity) < 200;


--3. Create a report that shows the total number of orders by Customer since December 31, 1996. The report should only return rows for which the total number of orders is greater than 15 (5 rows)

SELECT Customers.CompanyName, COUNT(Orders.OrderID) AS [Total Number]
FROM Customers
	INNER JOIN ORDERs ON Orders.CustomerID = Customers.CustomerID
WHERE OrderDate > '1996-12-31'
GROUP BY Customers.CompanyName
HAVING COUNT(Orders.OrderID) > 15
ORDER BY [Total Number] DESC;