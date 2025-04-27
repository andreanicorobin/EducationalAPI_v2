-- 1. Crear la base de datos
CREATE DATABASE RegistroEstudiantesDB;
GO

USE RegistroEstudiantesDB;
GO

-- 2. Crear las tablas principales

-- Tabla de estudiantes
CREATE TABLE Estudiantes (
    EstudianteID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL
);

-- Tabla de profesores
CREATE TABLE Profesores (
    ProfesorID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL
);

-- Tabla de materias
CREATE TABLE Materias (
    MateriaID INT IDENTITY(1,1) PRIMARY KEY,
    Nombre NVARCHAR(100) NOT NULL,
    Creditos INT NOT NULL DEFAULT 3, -- Cada materia vale 3 créditos
    ProfesorID INT NOT NULL,
    FOREIGN KEY (ProfesorID) REFERENCES Profesores(ProfesorID)
);

-- Tabla de inscripciones
CREATE TABLE Inscripciones (
    InscripcionID INT IDENTITY(1,1) PRIMARY KEY,
    EstudianteID INT NOT NULL,
    MateriaID INT NOT NULL,
    FOREIGN KEY (EstudianteID) REFERENCES Estudiantes(EstudianteID),
    FOREIGN KEY (MateriaID) REFERENCES Materias(MateriaID)
);

-- 3. Insertar datos base

-- Profesores (5 profes que dictarán 2 materias cada uno)
INSERT INTO Profesores (Nombre) VALUES
('Profesor A'),
('Profesor B'),
('Profesor C'),
('Profesor D'),
('Profesor E');

-- Materias (10 materias repartidas 2 por cada profesor)
INSERT INTO Materias (Nombre, ProfesorID) VALUES
('Matemáticas I', 1),
('Física I', 1),
('Programación I', 2),
('Bases de Datos', 2),
('Historia Universal', 3),
('Literatura', 3),
('Química I', 4),
('Biología I', 4),
('Filosofía', 5),
('Ética Profesional', 5);

