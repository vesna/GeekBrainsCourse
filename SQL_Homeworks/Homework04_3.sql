/*Задание №3.
Даны 2 таблицы, созданные следующим образом:
create table test_a (id number, data varchar2(1));
create table test_b (id number);
insert into test_a(id, data) values
(10, 'A'),
(20, 'A'),
(30, 'F'),
(40, 'D'),
(50, 'C');
insert into test_b(id) values
(10),
(30),
(50);
__
__
Напишите запрос, который вернет строки из таблицы test_a, id которых нет в таблице test_b, НЕ используя ключевого слова NOT.

__
__
__*/
USE GeekBrainsTest;

SELECT a.id, 
	a.data
FROM dbo.test_a as a 
	LEFT JOIN dbo.test_b as b ON a.id = b.id
WHERE b.id IS NULL;
