USE GeekBrainsTest;

IF (OBJECT_ID(N'dbo.SALESPEOPLE', N'U') IS NULL)
BEGIN
	CREATE TABLE dbo.SALESPEOPLE(
		Snum INT NOT NULL PRIMARY KEY,
		Sname VARCHAR(50) NOT NULL,
		�ity VARCHAR(50) NOT NULL,
		�omm VARCHAR(50) NOT NULL
	)
END
GO

IF (OBJECT_ID(N'dbo.CUSTOMERS', N'U') IS NULL)
BEGIN
	CREATE TABLE dbo.CUSTOMERS(
		�num INT NOT NULL PRIMARY KEY,
		�name VARCHAR(50) NOT NULL,
		�ity VARCHAR(50) NOT NULL,
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
		�num INT NOT NULL, 
		Snum INT NOT NULL, 
		CONSTRAINT FK_CUSTOMERS_ORDERS FOREIGN KEY (�num) REFERENCES dbo.CUSTOMERS(�num),
		CONSTRAINT FK_SALESPEOPLE_ORDERS FOREIGN KEY (Snum) REFERENCES dbo.SALESPEOPLE(Snum)
		ON UPDATE CASCADE
	)
END
GO

--1. �������� ������, ������� ����� �� ������� �� ��������� � ��������� �������: city, sname,
--snum, comm. (� ������ ��� ������ �������, ��������� SELECT)

--2. �������� ������� SELECT, ������� ������ �� ������(rating), �������������� ������
--������� ��������� � ������ San Jose. (����������)
--3. �������� ������, ������� ����� �� �������� snum ���� ��������� �� ������� ������� ���
--����� �� �� �� ���� ����������. (���������� �������� � �snum� ����������)
--4*. �������� ������, ������� �� ������� ����������, ��� ����� ���������� � ����� G.
--������������ �������� "LIKE": (����������) https://dev.mysql.com/doc/refman/8.0/en/string-comparisonfunctions.html
--5. �������� ������, ������� ����� ���� ��� ��� ������ �� ���������� ����� ���� ��� $1,000.
--(��������, �amt� - �����)
--6. �������� ������ ������� ������ �� ���������� ����� ������.
--(�� ���� �amt� - ����� � ������� �������� ������� ���������� ��������)
--7. �������� ������ � ������� ����������, ������� ����� �������� ���� ����������, � �������
--������� ������ 100 � ��� ��������� �� � ����.