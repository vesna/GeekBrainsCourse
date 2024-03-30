package Java_Homeworks.Seminar04;

import java.util.*;
import java.util.Scanner;

public class Homework {
    static Scanner scanner = new Scanner(System.in);
    static Stack<Integer> stack = new Stack<>();
    static Stack<Character> opStack = new Stack<>();
    static Integer result = 0;
    public static void main(String[] args) {
        /*1 Пусть дан LinkedList с несколькими элементами. Реализуйте метод, который вернет “перевернутый” список.*/
        // List<Integer> list = new LinkedList<Integer>(List.of(5, 1, 2, 3, 4, 8, 10 ));
        // System.out.println(list);
        // revertList(list);
        // System.out.println(list);

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
        result = addNumber();
        doOperationAndAddNumber(getOperation());
        System.out.println("Результат операции: "+ result);
        doOperationAndAddNumber(getOperation());
        System.out.println("Результат операции: "+ result);
        doOperationAndAddNumber(getOperation());
        System.out.println("Результат операции: "+ result);
        System.out.println("Отмена последней операции");
        undo();
        System.out.println("Результат операции: "+ result);
        System.out.println("Отмена последней операции");
        undo();
        System.out.println("Результат операции: "+ result);
        doOperationAndAddNumber(getOperation());
        System.out.println("Результат операции: "+ result);
        /*4** Реализовать алгоритм перевода из инфиксной записи в постфиксную для арифметического выражения.
        http://primat.org/news/obratnaja_polskaja_zapis/2016-04-09-1181
        Вычислить запись если это возможно. */
    }

    public static int addNumber(){
        System.out.println("Введите число:");
        int num;
        if(scanner.hasNextInt()){
            num = scanner.nextInt();
        } else {
            System.out.println("Вы допустили ошибку при вводе числа. Попробуйте еще раз.");
            scanner.next();//рекурсия
            num = addNumber();
        }
        stack.push(num);
        return num;
    }
 
    public static char getOperation(){
        System.out.println("Введите операцию:");
        char operation;
        if(scanner.hasNext()){
            operation = scanner.next().charAt(0);
            opStack.push(operation);
        } else {
            System.out.println("Вы допустили ошибку при вводе операции. Попробуйте еще раз.");
            scanner.next();//рекурсия
            operation = getOperation();
        }
        return operation;
    }

    public static void doOperationAndAddNumber(Character op){
        doOperation(addNumber(), op);
        stack.push(result);
        //opStack.push(op);
       // result = 0;
    }

    public static void undo(){
        if(!stack.isEmpty() && !opStack.isEmpty()){
            stack.pop();
            char lastOp = opStack.pop();
            switch (lastOp){
                case '+':
                    stack.pop();
                    break;
                case '-':
                    stack.pop();
                    break;
                case '*':
                    stack.pop();
                    break;
                case '/':
                    stack.pop();
                    break;
                default:
                    break;
            }
            result = stack.get(stack.size() - 1);
        }
        else{
            System.out.println("Нет операции для отмены.");
        }
    }
 
    public static void doOperation(int num2, char operation){
        switch (operation){
            case '+':
                result += num2;
                break;
            case '-':
                result -= num2;
                break;
            case '*':
                result *= num2;
                break;
            case '/':
                result /= num2;
                break;
            default:
                break;
        }
    }


    public static void revertList(List<Integer> list){
        int i = 0;
        int size = list.size() - 1;
        while (i < size/2) {
            int temp = list.get(i); 
            int temp2 = list.get(size - i);
            list.set(i, temp2);
            list.set(size - i, temp);
            i++;
        }
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
