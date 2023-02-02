CREATE TABLE Burger(
    Id_Burger INT IDENTITY (1,1) PRIMARY KEY NOT NULL,
    Name VARCHAR(50) NOT NULL,
    Id_Meat INT REFERENCES Meat (Id_Meat),
    Id_Bread INT REFERENCES Bread (Id_Bread),
    Id_Optional INT REFERENCES Optional (Id_Optional),
    Status INT
);