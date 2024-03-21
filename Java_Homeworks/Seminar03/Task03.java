package Java_Homeworks.Seminar03;

import java.util.ArrayList;

/*Создать список типа ArrayList<String>.
Поместить в него как строки, так и целые числа. 
Пройти по списку, найти и удалить целые числа.
 */
public class Task03 {
    public static void main(String[] args) {
        ArrayList mixed = new ArrayList<String>();
        mixed.add("hello");
        mixed.add(234);
        mixed.add("hi");
        mixed.add(735);
        mixed.add(7343);
        mixed.add("world");
        System.out.println(mixed);

        for (int i = 0; i < mixed.size(); i++) {
            if (mixed.get(i) instanceof Integer){
                mixed.remove(i);
                i--;
            }
        }
    }
}
