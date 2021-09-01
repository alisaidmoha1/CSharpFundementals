CREATE TABLE Products (
    Id INT IDENTITY(1,1) PRIMARY KEY, -- ID will add a number each time a new product is made.
    Name NVARCHAR(100) NOT NULL, -- nvarchar is string and it will take the max 100 chracters
    Price FLOAT NOT NULL, 
    QauantityInStock INT NOT NULL CHECK (QauantityInStock >=0) -- if the quantity products is negative the database will reject/
)