USE GeekBrainsTest

IF OBJECT_ID('dbo.Staff', 'U') IS NOT NULL
  DROP TABLE dbo.Staff
GO

CREATE TABLE dbo.Staff(
	ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name VARCHAR(50) NOT NULL,
	Surname VARCHAR(50) NOT NULL,
	Speciality VARCHAR(50) NOT NULL,
	Seniority INT NOT NULL, 
	Salary INT NOT NULL,
	Age INT NOT NULL
)
GO

INSERT INTO dbo.Staff(Name, Surname, Speciality, Seniority, Salary, Age)
VALUES
	 ('Вася', 'Петров', 'Начальник', 40, 100000, 60),
	 ('Петр', 'Власов', 'Начальник', 8, 70000, 30),
	 ('Катя', 'Катина', 'Инженер', 2, 70000, 25),
	 ('Саша', 'Сасин', 'Инженер', 12, 50000, 35),
	 ('Иван', 'Петров', 'Рабочий', 40, 30000, 59),
	 ('Петр', 'Петров', 'Рабочий', 20, 55000, 60),
	 ('Сидр', 'Сидоров', 'Рабочий', 10, 20000, 35),
	 ('Антон', 'Антонов', 'Рабочий', 8, 19000, 28),
	 ('Юрий', 'Юрков', 'Рабочий', 5, 15000, 25),
	 ('Максим', 'Петров', 'Рабочий', 2, 11000, 19),
	 ('Юрий', 'Петров', 'Рабочий', 3, 12000, 24),
	 ('Людмила', 'Маркина', 'Уборщик', 10, 10000, 49)
 

--1. Отсортируйте поле “зарплата” в порядке убывания и возрастания
SELECT * FROM dbo.Staff ORDER BY Salary ASC
SELECT * FROM dbo.Staff ORDER BY Salary DESC
--2. ** Отсортируйте по возрастанию поле “Зарплата” и выведите 5 строк с
--наибольшей заработной платой (возможен подзапрос)
SELECT TOP 5 Salary FROM dbo.Staff ORDER BY Salary DESC
--3. Выполните группировку всех сотрудников по специальности ,
--суммарная зарплата которых превышает 100000*/
SELECT Speciality, SUM(Salary)
FROM dbo.Staff
GROUP BY Speciality
HAVING SUM(Salary) > 10000;

