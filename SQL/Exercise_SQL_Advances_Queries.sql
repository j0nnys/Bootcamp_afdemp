--1. What were our total revenues in 1997(the bad way)
SELECT Orders.OrderID, SUM(ROUND(Unitprice * Quantity * (1 - Discount),2)) FinalPrice
INTO #tempFinalPrices3
FROM Orders
	INNER JOIN [Order Details] ON [Order Details].OrderID = Orders.OrderID
WHERE OrderDate BETWEEN '1997-01-01' AND '1997-12-31'
GROUP BY Orders.OrderID
SELECT SUM(FinalPrice) total FROM #tempFinalPrices3;

--1. What were our total revenues in 1997
SELECT SUM(ROUND(Unitprice * Quantity * (1 - Discount),2)) AS [Final Price]
FROM [Order Details] AS OD
	INNER JOIN Orders AS O ON OD.OrderID = O.OrderID
WHERE Year(O.OrderDate) = 1997

--2. What is the total amount each customer has payed us so far
SELECT Customers.CompanyName, SUM(ROUND(Unitprice * Quantity * (1 - Discount),2)) [Total Pay]
FROM Customers
	JOIN Orders ON Customers.CustomerID = Orders.CustomerID
	JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID
GROUP BY Customers.CompanyName
ORDER BY Customers.CompanyName

--3. Find the 10 top selling products
SELECT TOP (10) Products.ProductName, SUM(ROUND([Order Details].Unitprice * Quantity * (1 - Discount),2)) [Top 10 Products]
FROM Products
	INNER JOIN [Order Details] ON Products.ProductID = [Order Details].ProductID
GROUP BY Products.ProductName
ORDER BY [Top 10 Products] Desc

--4. Create a view with total revenues per customer
go
CREATE VIEW [Total Revenues per Customer2] AS
SELECT Customers.CustomerID, Customers.CompanyName, SUM(ROUND([Order Details].Unitprice * Quantity * (1 - Discount),2)) [TOTAL]
FROM Customers
	LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID
	LEFT JOIN [Order Details] ON Orders.CustomerID = Customers.CustomerID
GROUP BY Customers.CustomerID, Customers.CompanyName;
go
SELECT * FROM [Total Revenues per Customer2] 
go

--5. Which UK Customers have payed us more than 1000 dollars
SELECT Customers.CustomerID, Customers.CompanyName, SUM(ROUND([Order Details].Quantity * UnitPrice * (1 - Discount), 2)) [Total]
FROM Customers 
	LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID
	LEFT JOIN [Order Details] on [Order Details].OrderID = [Order Details].OrderID
WHERE Customers.Country = 'UK'
GROUP BY Customers.CustomerID, Customers.CompanyName
HAVING SUM(ROUND([Order Details].Quantity * UnitPrice * (1 - Discount), 2)) > 1000;
