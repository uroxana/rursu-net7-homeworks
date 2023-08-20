CREATE DATABASE LibrariesManagement;

USE LibrariesManagement;

CREATE TABLE Libraries
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name VARCHAR(50),
    StreetName VARCHAR(50),
    City VARCHAR(50)
);
CREATE TABLE Librarians
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Name VARCHAR(30),
    HireDate Date,
    IsOnHoliday VARCHAR(3),
    LibraryId INT REFERENCES Libraries(Id)
);

CREATE TABLE Books
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Title VARCHAR(50),
    AuthorFirstName VARCHAR(30),
    AuthorLastName VARCHAR(30),
    Type VARCHAR(10), -- crime, fantasy, horror, adventure
);

CREATE TABLE Books_Libraries
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    BookId INT REFERENCES Books(Id),
    LibraryId INT REFERENCES Libraries(Id)
);

CREATE TABLE Sales
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    NumberOfCopies INT,
    LibraryId INT REFERENCES Libraries(Id),
    LibrarianId INT REFERENCES Librarians(Id)
);

CREATE TABLE Books_Sales
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    BookId INT REFERENCES Books(Id),
    SalesId INT REFERENCES Sales(Id)
);

INSERT INTO Libraries(Name,StreetName,City)
VALUES('Antia','Vointei','Bacau'),('Cartes','Piperului','Sibiu'),('Veselie','Olarilor','Brasov'),('Tacuta','Fericirii','Iasi'),('Elevului','Verde','Bacau'),('Noua','Palat','Iasi');
SELECT * FROM Libraries;

INSERT INTO Librarians(Name,HireDate,IsOnHoliday,LibraryId)
VALUES('Andreea','2020-12-22','No',3),('Andrei','2020-12-22','No',4),('Maria','2012-01-18','No',1),('George','2019-05-24','Yes',2),('Andreea','2019-02-20','Yes',3),('Marius','2021-01-16','No',2),('Ioana','2022-09-06','No',5),('Larisa','2013-06-14','No',6)
SELECT * FROM Librarians;

INSERT INTO Books(Title,AuthorFirstName,AuthorLastName,Type)
VALUES('Poezii','Mihai','Eminescu','fantasy'),('Floarea','Andrei','Iures','comedy'),('Laguna','Ioan','Popescu','crime'),('Copilul','Elena','Manea','adventure'),('Muntele albastru','Irina','Fastin','comedy'),('Fantoma noua','Riana','Olescu','horror'),('Drumetia','Elena','Manea','adventure'),('Fugarul','Ioan','Popescu','crime'),('Laleaua','Riana','Olescu','horror'),('Coltul vesel','Andrei','Iures','comedy'),('Unicornul Roz','Sorana','Mina','fantasy'),('Bicicleta','Andrei','Iures','comedy');
SELECT * FROM Books;

INSERT INTO Books_Libraries(BookId,LibraryId)
VALUES (1,5),(2,3),(3,5),(4,1),(5,6),(6,2),(7,1),(8,4),(9,3),(10,6),(11,4),(12,1);
SELECT * FROM Books_Libraries;

INSERT INTO Sales(NumberOfCopies,LibraryId,LibrarianId)
VALUES(4,4,1),(8,6,7),(12,2,3),(6,3,4),(3,4,1),(7,5,6),(3,6,5),(5,6,7);
SELECT*FROM Sales;

INSERT INTO Books_Sales(BookId,SalesId)
VALUES(1,3),(3,7),(2,4),(4,6),(6,8),(8,2),(10,5),(12,1);
SELECT*FROM Books_Sales;
--Exercise 1-Find at least 4 improvements that must be applied to the database structure 
--add an e-mail column in table Books;
--create table reports;


--EXERCISE 2-Display all the librarians together with the library name they work in ordered by librarian name and library name descending.

SELECT Librarians.ID, Librarians.NAME,Libraries.NAME AS LibraryName
FROM Librarians 
JOIN Libraries
ON LibraryId = Libraries.iD
ORDER BY Librarians.NAME DESC, Libraries.NAME DESC;

--EXERCISE 3-Update all the street names to start with "STR.".
UPDATE Libraries
SET StreetName=concat('STR  ', StreetName);

--Exercise 4-Display the authors' email for those who have more than 3 books published.
ALTER TABLE Books
ADD Email varchar(55);

UPDATE Books
SET Email=('eminescu@yahoo.com')
WHERE id=1;
UPDATE Books
SET Email=('Iures@gmail')
WHERE id=2;
UPDATE Books
SET Email=('Popescu@yahoo.com')
WHERE id=3;
UPDATE Books
SET Email=('Manea@yahoo.com')
WHERE id=4;
UPDATE Books
SET Email=('Fastin@gmail')
WHERE id=5;
UPDATE Books
SET Email=('Olescu@yahoo.com')
WHERE id=6;
UPDATE Books
SET Email=('Manea@yahoo.com')
WHERE id=7;
UPDATE Books
SET Email=('Popescu@yahoo.com')
WHERE id=8;
UPDATE Books
SET Email=('Olescu@yahoo.com')
WHERE id=9;
UPDATE Books
SET Email=('Iures@gmail')
WHERE id=10;
UPDATE Books
SET Email=('Mina@yahoo.com')
WHERE id=11;
UPDATE Books
SET Email=('Iures@gmail')
WHERE id=12;

INSERT INTO Books(Title,AuthorFirstName,AuthorLastName,Type, Email)
VALUES('Poezii scurte','Andrei','Iures','fantasy','Iures@gmail')

CREATE TABLE Reports 
(
    Id INT IDENTITY(1, 1) PRIMARY KEY,
    Email varchar(500), 
    count INT
);

INSERT INTO Reports
SELECT Email,count(*) AS Total 
FROM Books 
GROUP BY Email;

SELECT Email AS AuthorEmail, count AS BooksPublished FROM Reports
WHERE count>3;

--Exercise 5-Display the library name and the book title of the largest sale (the highest number of copies sold in one sale).
SELECT Title AS BookTitle,Libraryid
FROM Books
JOIN Books_libraries on books.id=bookid
SELECT Libraries.Name,numberOfCopies
FROM Libraries
FULL JOIN Sales on Libraryid=Libraries.Id;
SELECT MAX(NumberOfCopies) AS LargestSale
FROM Sales

--Exercise 6-Display all the librarians that are not on holiday and are hired more than 5 years ago.
SELECT NAME AS LibrarianName,IsOnHoliday,HireDate
FROM Librarians
WHERE year(HireDate)<(YEAR(GETDATE())-5)
AND IsOnHoliday='no';
