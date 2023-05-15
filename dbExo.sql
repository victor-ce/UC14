CREATE DATABASE ExoProjects
GO

USE ExoProjects
GO

CREATE TABLE Projetos (
	Id INT PRIMARY KEY IDENTITY,
	NomeProjeto VARCHAR(150) NOT NULL, 
	DataInicio DATE NOT NULL,
	DataTermino DATE NOT NULL,
	Tecnologias VARCHAR(150) NOT NULL
	)
GO

INSERT INTO Projetos (NomeProjeto, DataInicio, DataTermino, Tecnologias) 
VALUES ('ProjetoA', '2022/01/01', '2022/01/05', 'TecA, TecB, TecC')
GO

INSERT INTO Projetos (NomeProjeto, DataInicio, DataTermino, Tecnologias) 
VALUES ('ProjetoB', '2022/02/01', '2022/02/05', 'TecD, TecE, TecF')
GO

SELECT Id, nomeProjeto, dataInicio, dataTermino FROM Projetos
GO
