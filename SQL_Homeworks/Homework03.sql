USE GeekBrainsTest;

IF OBJECT_ID('dbo.ORDERS', 'U') IS NOT NULL
  DROP TABLE dbo.ORDERS;
GO

IF OBJECT_ID('dbo.CUSTOMERS', 'U') IS NOT NULL
  DROP TABLE dbo.CUSTOMERS;
GO

IF OBJECT_ID('dbo.SALESPEOPLE', 'U') IS NOT NULL
  DROP TABLE dbo.SALESPEOPLE;
GO

CREATE TABLE dbo.SALESPEOPLE(
	Snum INT NOT NULL PRIMARY KEY,
	Sname VARCHAR(50) NOT NULL,
	Сity VARCHAR(50) NOT NULL,
	Сomm VARCHAR(50) NOT NULL
);
GO

CREATE TABLE dbo.CUSTOMERS(
	Сnum INT NOT NULL PRIMARY KEY,
	Сname VARCHAR(50) NOT NULL,
	Сity VARCHAR(50) NOT NULL,
	Rating INT NOT NULL,
	Snum INT NOT NULL FOREIGN KEY REFERENCES dbo.SALESPEOPLE(Snum) 
	ON UPDATE CASCADE ON 
	DELETE CASCADE
);
GO

CREATE TABLE dbo.ORDERS(
	Onum INT NOT NULL PRIMARY KEY,
	Amt DECIMAL(8, 2) NOT NULL,
	Odate DATE NOT NULL,
	Сnum INT NOT NULL, 
	Snum INT NOT NULL, 
	CONSTRAINT FK_CUSTOMERS_ORDERS FOREIGN KEY (Сnum) REFERENCES dbo.CUSTOMERS(Сnum),
	CONSTRAINT FK_SALESPEOPLE_ORDERS FOREIGN KEY (Snum) REFERENCES dbo.SALESPEOPLE(Snum)
	ON UPDATE CASCADE
	ON DELETE CASCADE
);
GO

INSERT INTO dbo.SALESPEOPLE(Snum, Sname, Сity, Сomm)
VALUES 	(1001, 'Peel', 'London', '.12'), 	(1002, 'Serres', 'San Jose', '.13'), 	(1004, 'Motika', 'London', '.11'), 	(1007, 'Rifkin', 'Barcelona', '.15'), 	(1003, 'Axelrod', 'New York', '.10');
INSERT INTO dbo.CUSTOMERS(Сnum, Сname, Сity, Rating, Snum)
VALUES 
	(2001, 'Hoffman', 'London', 100, 1001), 
	(2002, 'Giovanni', 'Rome', 200, 1003), 
	(2003, 'Liu', 'SanJose', 200, 1002), 
	(2004, 'Grass', 'Berlin', 300, 1002), 
	(2006, 'Clemens', 'London', 100, 1001), 
	(2008, 'Cisneros', 'SanJose', 300, 1007),
	(2007, 'Pereira', 'Rome', 100, 1004);SET DATEFORMAT dmy;INSERT INTO dbo.ORDERS(Onum, Amt, Odate, Сnum, Snum)VALUES 
	(3001, 18.69, '10.03.1990', 2008, 1007),
	(3003, 767.19, '10.03.1990', 2001, 1001),
	(3002, 1900.10, '10.03.1990', 2007, 1004),
	(3005, 5160.45, '10.03.1990', 2003, 1002),
	(3006, 1098.16, '10.03.1990', 2008, 1007),
	(3009, 1713.23, '10.04.1990', 2002, 1003),
	(3007, 75.75, '10.04.1990', 2004, 1002),
	(3008, 4723.00, '10.05.1990', 2006, 1001),
	(3010, 1309.95, '10.06.1990', 2004, 1002),
	(3011, 9891.88, '10.06.1990', 2006, 1001);	

--1. Напишите запрос, который вывел бы таблицу со столбцами в следующем порядке: city, sname,
--snum, comm. (к первой или второй таблице, используя SELECT)

--2. Напишите команду SELECT, которая вывела бы оценку(rating), сопровождаемую именем
--каждого заказчика в городе San Jose. (“заказчики”)
--3. Напишите запрос, который вывел бы значения snum всех продавцов из таблицы заказов без
--каких бы то ни было повторений. (уникальные значения в “snum“ “Продавцы”)
--4*. Напишите запрос, который бы выбирал заказчиков, чьи имена начинаются с буквы G.
--Используется оператор "LIKE": (“заказчики”) https://dev.mysql.com/doc/refman/8.0/en/string-comparisonfunctions.html
--5. Напишите запрос, который может дать вам все заказы со значениями суммы выше чем $1,000.
--(“Заказы”, “amt” - сумма)
--6. Напишите запрос который выбрал бы наименьшую сумму заказа.
--(Из поля “amt” - сумма в таблице “Заказы” выбрать наименьшее значение)
--7. Напишите запрос к таблице “Заказчики”, который может показать всех заказчиков, у которых
--рейтинг больше 100 и они находятся не в Риме.