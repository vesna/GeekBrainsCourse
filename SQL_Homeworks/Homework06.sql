USE GeekBrainsTest;
/*Создайте функцию, которая принимает кол-во сек и формат их в кол-во дней часов. 
Пример: 123456 ->'1 days 10 hours 17 minutes 36 seconds'*/


CREATE FUNCTION dbo.converter_seconds (@seconds INT)
RETURNS VARCHAR(100)
WITH EXECUTE AS CALLER
AS	
BEGIN
  DECLARE @days INT;
  DECLARE @hours INT;
  DECLARE @minutes INT;
  DECLARE @formatted_duration VARCHAR(100);

  SET @days = floor(@seconds / (24 * 3600));
  SET @seconds = @seconds % (24 * 3600);

  SET @hours = floor(@seconds / 3600);
  SET @seconds = @seconds % 3600;

  SET @minutes = floor(@seconds / 60);
  SET @seconds = @seconds % 60;

  SET @formatted_duration = CONCAT(@days, ' days ', @hours, ' hours ', @minutes, ' minutes ', @seconds, ' seconds');

  RETURN @formatted_duration;
END;
GO

SELECT dbo.converter_seconds(123456);

/*Выведите только четные числа от 1 до 10. Пример: 2,4,6,8,10 */

CREATE FUNCTION dbo.get_even_numbers(@n INT)
RETURNS VARCHAR(100)
WITH EXECUTE AS CALLER
AS	
BEGIN
	DECLARE @i INT;
	SET @i = 1;
	DECLARE @result VARCHAR(100);
	SET @result = '';
  
	WHILE @i <= @n
	BEGIN
		IF @i % 2 = 0
			SET @result = CONCAT(@result, @i, ', ');
		SET @i = @i + 1;
	END;
  
	RETURN SUBSTRING(@result, 1, LEN(@result) - 2);
END;
GO

SELECT dbo.get_even_numbers(10);
