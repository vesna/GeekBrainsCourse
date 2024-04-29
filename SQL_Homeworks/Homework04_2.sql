--«адание є2.. ¬ывести на экран марку авто(количество) и количество авто не этой марки.
--100 машин, их них 20 - BMW и 80 машин другой марки , AUDI - 30 и 70 машин другой марки, LADA - 15, 85 авто другой марки
USE GeekBrainsTest;

SELECT a1.MARK, 
	COUNT(a1.MARK) as count, 
	(SELECT COUNT(a2.MARK) FROM dbo.AUTO as a2 WHERE a2.MARK != a1.MARK) as other
FROM dbo.AUTO as a1 
GROUP BY a1.MARK
