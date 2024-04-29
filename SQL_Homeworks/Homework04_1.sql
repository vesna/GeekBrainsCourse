--Задание №1.. Вывести на экран сколько машин каждого цвета для машин марок BMW и LADA
USE GeekBrainsTest;

SELECT COLOR, COUNT(COLOR)
FROM dbo.AUTO AS a
WHERE a.MARK like 'BMW' OR a.MARK like 'LADA' 
GROUP BY COLOR