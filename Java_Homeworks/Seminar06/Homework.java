package Java_Homeworks.Seminar06;

import java.util.*;

/*Подумать над структурой класса Ноутбук для магазина техники - выделить поля и методы. Реализовать в java.
Создать множество ноутбуков.
Написать метод, который будет запрашивать у пользователя критерий (или критерии) фильтрации и выведет ноутбуки, 
отвечающие фильтру. Критерии фильтрации можно хранить в Map. 
Например:
“Введите цифру, соответствующую необходимому критерию:
1 - ОЗУ
2 - Объем ЖД
3 - Операционная система
4 - Цвет …
Далее нужно запросить минимальные значения для указанных критериев - сохранить параметры фильтрации можно также в Map.
Отфильтровать ноутбуки их первоначального множества и вывести проходящие по условиям. */
public class Homework {
    public static void main(String[] args) {
        Set<Laptop> unicLaptop = new HashSet<Laptop>();
        unicLaptop.add(new Laptop("Lenovo IdealPad 5", 8, 256, "Windows 11", "синий", 15.6, 80000));
        unicLaptop.add(new Laptop("Honor MagicBook 16", 16, 512, "без ОС", "серый", 16.1, 100000));
        unicLaptop.add(new Laptop("Apple MacBook Air 13", 8, 256, "MacOs", "золотистый", 13.3, 200000));
        unicLaptop.add(new Laptop("HP 250 G7", 4, 1024, "без ОС", "черный", 15.6, 60000));
        unicLaptop.add(new Laptop("Xiomi RedmiBook 15", 8, 256, "Windows 11", "серый", 15.6, 120000));

        Map<Integer, String> mapCriteria = new HashMap<>();
        mapCriteria.put(1, "объем оперативной памяти");
        mapCriteria.put(2, "объем накопителя");
        mapCriteria.put(3, "ОС");
        mapCriteria.put(4, "цвет");
        mapCriteria.put(5, "диагональ");
        mapCriteria.put(6, "цена");

        Scanner sc = new Scanner(System.in);
        System.out.println("объем оперативной памяти: ");
        int ramUser = sc.nextInt();
        System.out.println("объем накопителя: ");
        int storUser = sc.nextInt();
        System.out.println("диагональ");
        double digUser = sc.nextDouble();
        for(Laptop lap: unicLaptop) {
            if ((lap.getRam() >= ramUser) && (lap.getStorageCap() >= storUser)  && lap.getDiagonal() >= digUser) {
                System.out.println(lap.toString());
            }
        }
        sc.close();
    }
}
