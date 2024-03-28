package Java_Homeworks.Seminar05;

import java.util.*;

public class Homework {
   public static void main(String[] args) {
        /*1.Реализуйте структуру телефонной книги с помощью HashMap, учитывая, что 1 человек может иметь несколько телефонов.*/
        Map<String, List<Integer>> namesToPhones = new HashMap<> ();
        List<Integer> phones = new ArrayList<>(List.of (1111, 22222, 33333));
        namesToPhones.put ("Ivan Ivanov", phones);
        namesToPhones.put ("Petr Petrov", List.of (111111, 222222, 3333));
        namesToPhones.put ("Sidor Sidorov", List.of (111111, 222222, 3333));

        namesToPhones.get ("Ivan Ivanov").add (44444);

        System.out.println(namesToPhones.get ("Ivan Ivanov"));


        Map<String, List<PhoneWithLabel>> namesToPhonesWithLabels;
        List<PhoneWithLabel> withLabels = new ArrayList<> ();
        withLabels.add (new PhoneWithLabel("мобильный", 11111));
        withLabels.add (new PhoneWithLabel("мобильный", 22222));
        withLabels.add (new PhoneWithLabel("мобильный", 33333));
        withLabels.add (new PhoneWithLabel("мобильный", 4444));

        Map<String, Map<String, Integer>> namesToPhonesWithLab_map = new HashMap<>();
        HashMap<String, Integer> ivansPhones = new HashMap<>();
        namesToPhonesWithLab_map.put("Ivan Ivanov", ivansPhones);
        ivansPhones.put("mobile", 1111);
        ivansPhones.put("home",222);
        ivansPhones.put("work", 333);

        namesToPhonesWithLab_map.get("Ivan Ivanov").put("stteline", 4444);
        System.out.println(namesToPhonesWithLab_map);
        /*2.Пусть дан список сотрудников: Иван (и остальные, полный текст дз будет на платформе)
        Написать программу, которая найдет и выведет повторяющиеся имена с количеством повторений. Отсортировать по убыванию популярности.*/

        /* 3.Реализовать алгоритм пирамидальной сортировки (HeapSort).*/

        /* 4.На шахматной доске расставить 8 ферзей так, чтобы они не били друг друга. */
   } 
}
