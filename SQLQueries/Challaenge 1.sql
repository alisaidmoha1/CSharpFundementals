CREATE TABLE Owner (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100)
)

CREATE TABLE Pet (
    Id INT PRIMARY KEY IDENTITY(1,1),
    OwnerId INT NOT NULL,
    PetType NVARCHAR(100),
    FOREIGN KEY (OwnerId) REFERENCES Owner(Id)
)

INSERT INTO Owner (Name) VALUES
('Sadio Mane'),
('Van Dijk'),
('Mo Salah')

INSERT INTO Pet (OwnerId, PetType) VALUES 
(1, 'Cat'), (1, 'Dog'),
(2, 'Dog'),
(3, 'Dog'), (3, 'Bunny'), (3, 'Turtle')
