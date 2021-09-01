CREATE TABLE Restaurants (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Location NVARCHAR(100),
)

CREATE TABLE Ratings (
    Id INT PRIMARY KEY IDENTITY(1,1),
    RestaurantId INT NOT NULL,
    Score FLOAT NOT NULL CHECK (Score >= 0.0 AND Score <= 5.0)
)
