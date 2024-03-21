package Java_Homeworks.Seminar03;

import java.util.ArrayList;
import java.util.Random;

/*Заполнить список десятью случайными числами. 
Отсортировать список методом sort() и вывести его на экран.
 */
public class Task01 {
    public static void main(String[] args) {
        ArrayList<Integer> collection = new ArrayList<>();
        Random rnd = new Random();
        for (int i= 0; i < 10; i++){
            collection.add(rnd.nextInt(0,11));
        }
        System.out.println(collection);
        collection.sort(new MyComparator());
        System.out.println(collection);
    }
    
}
