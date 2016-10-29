BEGIN TRANSACTION
USE NORTHWND

--EXERCISE SQL INSERTING RECORDS
--1. Insert yourself into the Employees table
INSERT INTO Employees(LastName, FirstName, Title, TitleOfCourtesy, BirthDate, HireDate, City, Region, PostalCode, Country, HomePhone, ReportsTo)
VALUES ('Karopoulos', 'John', 'Student', 'Mr.', '1993-07-02 00:00:00 ', '2010-06-05', 'Athens', NULL, 18454, 'GR', 4930183, NULL)

-- Declare variable myEmployeeID with value the ID of the inserted entry
DECLARE @myEmployeeID int = SCOPE_IDENTITY();

--2. Insert an order for yourshelf in the Orders table
INSERT INTO Orders(CustomerID, EmployeeID, OrderDate, RequiredDate)
VALUES ('ALFKI', '21', '2016-10-25', '2016-11-25')

DECLARE @myOrderID int = SCOPE_IDENTITY();
-- Declare variable myProductID with value the ID of a random Product
DECLARE @myProductID int = 57;

--3. Insert order details in the Order Details table
INSERT INTO [Order Details]( OrderID, ProductID, UnitPrice, Quantity, Discount)
VALUES ('11078', '57', '19.5', '10', '0.25')

-- Print Results
select EmployeeID, LastName, FirstName from Employees;
select * from Orders where OrderID = @myOrderID;
select * from [Order Details] where OrderId = @myOrderID;

COMMIT

BEGIN TRANSACTION

--EXERCISE SQL UPDATING RECORDS
--1. Update the phone of yourself (from the previous entry in Employees table)
UPDATE Employees
SET HomePhone = '6973278142'
WHERE EmployeeID = 21

--2. Double the quantity of the order details record you inserted before
UPDATE [Order Details]
SET Quantity = Quantity * 2
WHERE OrderID = '11078'

--3. Repeat previous update but this time update all orders associated with you
UPDATE [Order Details]
SET Quantity = Quantity * 2
  FROM [Order Details]
	INNER JOIN ORDERS ON Orders.OrderID = [Order Details].OrderID
  WHERE Orders.EmployeeID = 21

COMMIT

BEGIN TRANSACTION

--EXERCISE SQL DELETING RECORDS
--1. Delete the records you inserted before. Don't delete any other records
DELETE FROM [Order Details]
WHERE OrderID = '11078'


DELETE FROM Orders
WHERE EmployeeID = 21


DELETE FROM Employees
WHERE EmployeeID = 21;

COMMIT

select EmployeeID, FirstName, LastName from Employees;
select * from [Order Details] where OrderId = @myOrderID;