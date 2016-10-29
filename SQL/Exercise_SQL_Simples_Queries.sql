--1. Get all columns from the tables Customers, Orders and Suppliers 
SELECT * FROM Customers 
SELECT * FROM Orders
SELECT * FROM Suppliers

--2. Get all Customers alphabetically, by Country and name 
SELECT * FROM Customers ORDER BY Country, ContactName

--3. Get all Orders by date 
SELECT * FROM Orders ORDER BY OrderDate

--4. Get the count of all Orders made during 1997 
SELECT COUNT(OrderDate) FROM Orders WHERE OrderDate='1997' --BETWEEN '1997-01-01' AND '1997-12-31 23:59:59'

--5. Get the names of all the contact persons where the person is a manager, alphabetically
SELECT ContactName FROM Customers WHERE ContactTitle LIKE '%Manager%' ORDER BY ContactName

--6. Get all orders placed on the 19th of May, 1997  
SELECT * FROM Orders WHERE OrderDate ='1997-05-16'