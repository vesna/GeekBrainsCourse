package Java_Homeworks.Seminar06;

import java.time.LocalDate;
import java.util.*;

/*1. Создайте множество, в котором будут храниться экземпляры класса Cat - HashSet<Cat>. Поместите в него некоторое количество объектов.
2. Создайте 2 или более котов с одинаковыми параметрами в полях. Поместите их во множество. Убедитесь, что все они сохранились во множество. 
3. Создайте метод public boolean equals(Object o)
Пропишите в нём логику сравнения котов по параметрам, хранимым в полях. То есть, метод должен возвращать true, только если значения во всех полях сравниваемых объектов равны.
4. Выведите снова содержимое множества из пункта 2, убедитесь, что дубликаты удалились.
 */
public class Task04 {
    public static void main(String[] args) {
        Set<Cat> myCats = new HashSet<>();

       myCats.add(new Cat("Барсик", "Виктория","Британец",LocalDate.of(2001,1, 1),"Белый"));
       myCats.add(new Cat("Барсик", "Виктория","Британец",LocalDate.of(2001,1, 1),"Белый"));
       
       myCats.add(new Cat("Пушистик", "Виктория","Британец",LocalDate.of(2001,1, 1),"Синий"));
        
       System.out.println(myCats);
    }
}