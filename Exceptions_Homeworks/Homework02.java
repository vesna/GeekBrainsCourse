import java.io.FileNotFoundException;
import java.util.Scanner;

public class Homework02 {
    public static void main(String[] args) {
        // task1();
        // task2();

        // try {
        // int a = 90;
        // int b = 3;
        // System.out.println(a / b);
        // printSum(23, 234);
        // int[] abc = { 1, 2 };
        // abc[3] = 9;
        // } catch (NullPointerException ex) {
        // System.out.println("Указатель не может указывать на null!");
        // } catch (IndexOutOfBoundsException ex) {
        // System.out.println("Массив выходит за пределы своего размера!");
        // }catch (Throwable ex) {
        // System.out.println("Что-то пошло не так...");
        // }

        task4();

    }

    /*
     * Разработайте программу, которая выбросит Exception, когда пользователь вводит
     * пустую строку. Пользователю должно показаться сообщение, что пустые строки
     * вводить нельзя.
     */
    public static void task4() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите строку: ");
        String s = scanner.nextLine();
        if (s.trim().isEmpty())
            throw new NullPointerException("Пустая строка");
    }

    /*
     * Реализуйте метод, который запрашивает у пользователя ввод дробного числа
     * (типа float), и возвращает введенное значение.
     * Ввод текста вместо числа не должно приводить к падению приложения,
     * вместо этого, необходимо повторно запросить у пользователя ввод данных.
     */

    public static void task1() {
        Scanner scanner = new Scanner(System.in);
        System.out.print("Введите дробное число: ");
        try {
            float number = scanner.nextFloat();
            System.out.printf("число %f", number);
        } catch (Exception ex) {
            System.out.print("Введите дробное число ,а не текст \n");
            task1();
        }
    }

    /*
     * Если необходимо, исправьте данный код
     * (задание 2 https://docs.google.com/document/d/
     * 17EaA1lDxzD5YigQ5OAal60fOFKVoCbEJqooB9XfhT7w/edit)
     */
    public static void task2() {
        try {
            int d = 0;
            int[] i = new int[8];
            for (int j = 0; j < i.length; j++) {
                double catchedRes1 = i[j] / d;
                System.out.println("catchedRes1 = " + catchedRes1);
            }
        } catch (ArithmeticException e) {
            System.out.println("Catching exception: " + e);
        }
    }

    /*
     * Дан следующий код, исправьте его там, где требуется
     * (задание 3 https://docs.google.com/document/d/
     * 17EaA1lDxzD5YigQ5OAal60fOFKVoCbEJqooB9XfhT7w/edit)
     */
    public static void printSum(Integer a, Integer b) throws FileNotFoundException {
        System.out.println(a + b);
    }

}
