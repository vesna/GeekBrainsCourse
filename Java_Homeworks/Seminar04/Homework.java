package Java_Homeworks.Seminar04;

import java.util.LinkedList;

public class Homework {
    public static void main(String[] args) {
        /*1 Пусть дан LinkedList с несколькими элементами. Реализуйте метод, который вернет “перевернутый” список.*/

        /*2 Реализуйте очередь с помощью LinkedList со следующими методами:
        enqueue() - помещает элемент в конец очереди, dequeue() - возвращает первый элемент из очереди и удаляет его, 
        first() - возвращает первый элемент из очереди, не удаляя.*/
        // LinkedList<Integer> list = new LinkedList<Integer>();
        // enqueue(list, 1);
        // enqueue(list, 2);
        // enqueue(list, 3);

        // System.out.println(size(list));
        // System.out.println(isEmpty(list));

        // System.out.println(dequeue(list));
        // System.out.println(dequeue(list));
        // System.out.println(dequeue(list));

        /*3* В калькулятор добавьте возможность отменить последнюю операцию.*/
        
        /*4** Реализовать алгоритм перевода из инфиксной записи в постфиксную для арифметического выражения.
        http://primat.org/news/obratnaja_polskaja_zapis/2016-04-09-1181
        Вычислить запись если это возможно. */
    }

    public static void enqueue (LinkedList<Integer> list , int elem){
        list.addLast(elem);

    }

    public static int dequeue (LinkedList<Integer> list){
        return list.removeFirst();
    }

    public static int first (LinkedList<Integer> list, int elem){
        return list.getFirst();
    }

    public static int size (LinkedList<Integer> list){
        return list.size();
    }

    public static boolean isEmpty(LinkedList<Integer> list){
        return list.isEmpty();
    }
}
