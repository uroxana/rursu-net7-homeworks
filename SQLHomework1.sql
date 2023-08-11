CREATE DATABASE Homework
CREATE TABLE Addresses
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    StreetName VARCHAR(100),
    StreetNumber INT,
    City VARCHAR(50),
);

CREATE TABLE Customers
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(150),
    Age INT,
    AddressId INT REFERENCES Addresses(Id)
);

CREATE TABLE Orders
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Details VARCHAR(150),
    CustomerId INT REFERENCES Customers(Id)
);

CREATE TABLE Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name VARCHAR(150)
);

CREATE TABLE Orders_Products
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    OrderId INT REFERENCES Orders(Id),
    ProductId INT REFERENCES Products(Id)
);

INSERT INTO Addresses
VALUES ('Bucuriei', 8, 'Deva');
INSERT INTO Addresses
VALUES ('Aviatorilor', 14, 'Bucuresti');
INSERT INTO Addresses
VALUES ('Iler', 10, 'Sibiu');
INSERT INTO Addresses
VALUES ('Florilor', 1, 'Iasi');
INSERT INTO Addresses
VALUES ('Sforii', 19, 'Brasov');
INSERT INTO Addresses
VALUES ('Independent', 4, 'Iasi');

SELECT *
FROM Addresses;

INSERT INTO Customers
VALUES ('George', 40, 1);
INSERT INTO Customers
VALUES ('Mihai', 18, 2);
INSERT INTO Customers
VALUES ('Andra', 15, 3);
INSERT INTO Customers
VALUES ('Valentin', 47, 4);
INSERT INTO Customers
VALUES ('Darius', 30, 5);
INSERT INTO Customers
VALUES ('Valentina', 34, 6);

SELECT *
FROM Customers;

INSERT INTO Orders
VALUES ('Order july', 4);
INSERT INTO Orders
VALUES ('Order september', 1);
INSERT INTO Orders
VALUES ('Order June', 4);
INSERT INTO Orders
VALUES ('order may', 2);
INSERT INTO Orders
VALUES ('order may', 3);
INSERT INTO Orders
VALUES ('order december', 1);
INSERT INTO Orders
VALUES ('order may', 5);
INSERT INTO Orders
VALUES ('order march', 6);


SELECT *
FROM Orders;

INSERT INTO Products
VALUES ('PEACH');
INSERT INTO Products
VALUES ('APRICOTS');
INSERT INTO Products
VALUES ('PLUMS');
INSERT INTO Products
VALUES ('CHERRIES');
INSERT INTO Products
VALUES ('BLUEBERRIES');
INSERT INTO Products
VALUES ('BLACKBERRIES');

SELECT * 
FROM Products;

INSERT INTO Orders_Products
VALUES (1, 6);
INSERT INTO Orders_Products
VALUES (1, 2);
INSERT INTO Orders_Products
VALUES (2, 4);
INSERT INTO Orders_Products
VALUES (3, 1);
INSERT INTO Orders_Products
VALUES (6, 1);
INSERT INTO Orders_Products
VALUES (5, 2);
INSERT INTO Orders_Products
VALUES (3, 4);
INSERT INTO Orders_Products
VALUES (3, 1);

SELECT * 
FROM Orders_Products;

--Exercise 2. Display all the Customers that are older than 15.
SELECT * 
FROM Customers
WHERE Age > 15;

--Exercise 3. Display the total number of Addresses.
SELECT COUNT(Id) As NumberOfAddresses
FROM Addresses;

--Exercise 4. Update the name of each Product to some other value.
UPDATE Products
SET Name = 'Beans'
WHERE Id = 1;
UPDATE Products
SET Name = 'Eggplant'
WHERE Id = 2;
UPDATE Products
SET Name = 'Mushrooms'
WHERE Id = 3;
UPDATE Products
SET Name = 'Spinach'
WHERE Id = 4;
UPDATE Products
SET Name = 'Potato'
WHERE Id = 5;
UPDATE Products
SET Name = 'Lentils'
WHERE Id = 6;

--Exercise 5. Alter the structure of one table by adding a new column.
Alter Table Customers
ADD PhoneNumber INT;
--Exercise 6. Populate the value of the newly added column with relevant data.
UPDATE Customers
SET PhoneNumber =743341855
WHERE Id = 6;
UPDATE Customers
SET PhoneNumber =728341855
WHERE Id = 5;
UPDATE Customers
SET PhoneNumber =343418795
WHERE Id = 4;
UPDATE Customers
SET PhoneNumber =743941351
WHERE Id = 3;
UPDATE Customers
SET PhoneNumber =143641875
WHERE Id = 2;
UPDATE Customers
SET PhoneNumber =793241865
WHERE Id = 1;


SELECT *
FROM Customers;

--Exercise 7. Display all the customers' information together with their orders.
SELECT Customers.Name,Customers.Age,Customers.PhoneNumber,Orders.Details ,Products.Name
FROM Customers
JOIN Orders ON Customers.Id = Orders.Id
JOIN Products ON Orders.Id = Products.Id ; 

--Exercise 8. Display all the customers' information together with their orders and their addresses.
SELECT Customers.Name,Customers.Age,Customers.PhoneNumber,Addresses.StreetName,Addresses.StreetNumber,Addresses.City,Orders.Details
FROM Customers
FULL OUTER JOIN Addresses On AddressId = Addresses.Id
JOIN Orders ON Customers.Id = Orders.CustomerId;
