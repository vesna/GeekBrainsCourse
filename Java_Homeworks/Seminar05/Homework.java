package Java_Homeworks.Seminar05;

import java.util.*;

public class Homework {
   public static void main(String[] args) {
        /*1.Реализуйте структуру телефонной книги с помощью HashMap, учитывая, что 1 человек может иметь несколько телефонов.*/
      //   Map<String, List<Integer>> namesToPhones = new HashMap<> ();
      //   List<Integer> phones = new ArrayList<>(List.of (1111, 22222, 33333));
      //   namesToPhones.put ("Ivan Ivanov", phones);
      //   namesToPhones.put ("Petr Petrov", List.of (111111, 222222, 3333));
      //   namesToPhones.put ("Sidor Sidorov", List.of (111111, 222222, 3333));
      //   namesToPhones.get ("Ivan Ivanov").add (44444);
      //   System.out.println(namesToPhones.get ("Ivan Ivanov"));

      //   Map<String, List<PhoneWithLabel>> namesToPhonesWithLabels;
      //   List<PhoneWithLabel> withLabels = new ArrayList<> ();
      //   withLabels.add (new PhoneWithLabel("мобильный", 11111));
      //   withLabels.add (new PhoneWithLabel("мобильный", 22222));
      //   withLabels.add (new PhoneWithLabel("мобильный", 33333));
      //   withLabels.add (new PhoneWithLabel("мобильный", 4444));

      //   Map<String, Map<String, Integer>> namesToPhonesWithLab_map = new HashMap<>();
      //   HashMap<String, Integer> ivansPhones = new HashMap<>();
      //   namesToPhonesWithLab_map.put("Ivan Ivanov", ivansPhones);
      //   ivansPhones.put("mobile", 1111);
      //   ivansPhones.put("home",222);
      //   ivansPhones.put("work", 333);

      //   namesToPhonesWithLab_map.get("Ivan Ivanov").put("stteline", 4444);
      //   System.out.println(namesToPhonesWithLab_map);
        
        /*2.Пусть дан список сотрудников: Иван, Пётр, Антон и так далее. 
        Написать программу, которая найдет и выведет повторяющиеся имена с количеством повторений. 
        Отсортировать по убыванию популярности.*/
      // String[] names = {"Иван", "Пётр", "Антон", "Пётр", "Антон", "Антон"};
      // Map<String, Integer> countNames = new HashMap<>();
      // for (String name : names) {
      //    if(countNames.containsKey(name)){
      //       countNames.put(name, countNames.get(name) + 1);
      //    }
      //    else{
      //       countNames.put(name, 1);
      //    }
      // }
      // List<Map.Entry<String, Integer>> list = new ArrayList<>(countNames.entrySet());
      // Collections.sort(list, new Comparator<Map.Entry<String, Integer>>(){
      //    public int compare(Map.Entry<String, Integer> o1, Map.Entry<String, Integer> o2){
      //       return o2.getValue().compareTo(o1.getValue());
      //    }
      // });
      // for ( Map.Entry<String, Integer> name : list) {
      //    System.out.println(name.getKey() + " " + name.getValue());
      // }

        /* 3.Реализовать алгоритм пирамидальной сортировки (HeapSort).*/
        int arr[] = {12, 11, 13, 5, 6, 7};
        sort(arr);

        System.out.println("Sorted array is");
        printArray(arr);

        /* 4.На шахматной доске расставить 8 ферзей так, чтобы они не били друг друга. */
   } 

   public static void sort(int arr[]){
      int n = arr.length;

      // Построение кучи (перегруппируем массив)
      for (int i = n / 2 - 1; i >= 0; i--)
         heapify(arr, n, i);

      // Один за другим извлекаем элементы из кучи   
      for (int i=n-1; i>=0; i--)
      {
         // Перемещаем текущий корень в конец
         int temp = arr[0];
         arr[0] = arr[i];
         arr[i] = temp;

         // Вызываем процедуру heapify на уменьшенной куче
         heapify(arr, i, 0);
      }
    }

    // Процедура для преобразования в двоичную кучу поддерева с корневым узлом i, что является
   // индексом в arr[]. n - размер кучи
   public static void heapify(int arr[], int n, int i){
      int largest = i; // Инициализируем наибольший элемент как корень
      int l = 2*i + 1; // левый = 2*i + 1
      int r = 2*i + 2; // правый = 2*i + 2

         // Если левый дочерний элемент больше корня
      if (l < n && arr[l] > arr[largest])
         largest = l;

         // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
      if (r < n && arr[r] > arr[largest])
         largest = r;
      // Если самый большой элемент не корень
      if (largest != i)
      {
         int swap = arr[i];
         arr[i] = arr[largest];
         arr[largest] = swap;

         // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
         heapify(arr, n, largest);
      }
    }

    /* Вспомогательная функция для вывода на экран массива размера n */
    public static void printArray(int arr[])
    {
      int n = arr.length;
      for (int i=0; i<n; ++i)
         System.out.print(arr[i]+" ");
      System.out.println();
    }
}
