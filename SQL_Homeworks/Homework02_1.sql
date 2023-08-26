USE GeekBrainsTest;

--»спользу€ операторы €зыка SQL, создайте табличку УsalesФ. «аполните ее данными
IF (OBJECT_ID(N'dbo.Sales', N'U') IS NULL)
BEGIN
	CREATE TABLE dbo.Sales(
		ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		Order_Date DATE NOT NULL,
		Count_Product INT NOT NULL
	)
END
GO

IF NOT EXISTS(SELECT TOP(1) 1 FROM dbo.Sales)
BEGIN
	INSERT INTO dbo.Sales (Order_Date, Count_Product)
	VALUES('2022-01-01', 156), ('2022-01-02', 180), ('2022-01-03', 21), ('2022-01-04', 124), ('2022-01-05', 341)
END
GO

--—группируйте значений количества в 3 сегмента Ч меньше 100, 100-300 и больше 300.
SELECT ID AS 'id «аказа',
	CASE
		WHEN Count_Product < 100 THEN 'ћаленький заказ'
		WHEN Count_Product > 100 AND Count_Product < 300 THEN '—редний заказ'		ELSE 'Ѕольшой заказ'	END AS '“ип заказа'FROM dbo.SalesGO--—оздайте таблицу УordersФ, заполните ее значени€ми. ѕокажите УполныйФ статус заказа, использу€ оператор CASEIF (OBJECT_ID(N'dbo.Orders', N'U') IS NULL)
BEGIN
	CREATE TABLE dbo.Orders(
		ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		Employe_ID VARCHAR(20) NOT NULL,
		Amount DECIMAL(5,2) NOT NULL,
		Order_Status VARCHAR(10) NOT NULL
	)
END
GO

IF NOT EXISTS(SELECT TOP(1) 1 FROM dbo.Orders)
BEGIN
	INSERT INTO dbo.Orders (Employe_ID, Amount, Order_Status)
	VALUES('e03', 15, 'OPEN'), ('e01', 25.5, 'OPEN'), ('e05', 100.7, 'CLOSED'), ('e02', 22.18, 'OPEN'), ('t04', 9.5, 'CANCELLED')
END
GO

SELECT 
	Employe_ID,
	Amount,
	CASE
		WHEN Order_Status like 'OPEN' THEN 'Order is in open state'
		WHEN Order_Status like 'CLOSED' THEN 'Order is closed'		WHEN Order_Status like 'CANCELLED' THEN 'Order is cancelled'	END AS full_order_statusFROM dbo.OrdersGO


