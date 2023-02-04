CREATE TABLE Optionais(
    Id INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
    Id_Optional INT NOT NULL REFERENCES Optional (Id_Optional),
    Id_Burger INT NOT NULL REFERENCES Burger (Id_Burger)
);

DROP TABLE Optionais