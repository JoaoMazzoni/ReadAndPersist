USE DBRadar

CREATE TABLE Radar (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Concessionaria VARCHAR(MAX),
    AnoDoPnvSnv VARCHAR(MAX),
    TipoDeRadar VARCHAR(MAX),
    Rodovia VARCHAR(MAX),
    Uf VARCHAR(MAX),
    KmM VARCHAR(MAX),
    Municipio VARCHAR(MAX),
    TipoPista VARCHAR(MAX),
    Sentido VARCHAR(MAX),
    Situacao VARCHAR(MAX),
    DataDaInativacao DATETIME,
    Latitude VARCHAR(MAX),
    Longitude VARCHAR(MAX),
    VelocidadeLeve VARCHAR(MAX)
);

ALTER TABLE Radar
ALTER COLUMN AnoDoPnvSnv VARCHAR(MAX)


SELECT * FROM Radar

SELECT DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'Radar' 
AND COLUMN_NAME = 'VelocidadeLeve';

