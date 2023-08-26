USE GeekBrainsTest;

IF (OBJECT_ID(N'dbo.SALESPEOPLE', N'U') IS NULL)
BEGIN
	CREATE TABLE dbo.SALESPEOPLE(
		Snum INT NOT NULL PRIMARY KEY,
		Sname VARCHAR(50) NOT NULL,
		Сity VARCHAR(50) NOT NULL,
		Сomm VARCHAR(50) NOT NULL
	)
END
GO

IF (OBJECT_ID(N'dbo.CUSTOMERS', N'U') IS NULL)
BEGIN
	CREATE TABLE dbo.CUSTOMERS(
		Сnum INT NOT NULL PRIMARY KEY,
		Сname VARCHAR(50) NOT NULL,
		Сity VARCHAR(50) NOT NULL,
		Rating INT NOT NULL,
		Snum INT NOT NULL FOREIGN KEY REFERENCES dbo.SALESPEOPLE(Snum) ON UPDATE CASCADE
	)
END
GO

IF (OBJECT_ID(N'dbo.ORDERS', N'U') IS NULL)
BEGIN
	CREATE TABLE dbo.ORDERS(
		Onum INT NOT NULL PRIMARY KEY,
		Amt DECIMAL(5, 2) NOT NULL,
		Odate DATE NOT NULL,
		Rating INT NOT NULL,
		Сnum INT NOT NULL, 
		Snum INT NOT NULL, 
		CONSTRAINT FK_CUSTOMERS_ORDERS FOREIGN KEY (Сnum) REFERENCES dbo.CUSTOMERS(Сnum),
		CONSTRAINT FK_SALESPEOPLE_ORDERS FOREIGN KEY (Snum) REFERENCES dbo.SALESPEOPLE(Snum)
		ON UPDATE CASCADE
	)
END
GO

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