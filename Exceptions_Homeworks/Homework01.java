import java.io.FileReader;
import java.io.IOException;
import java.util.Arrays;
import java.util.Scanner;

public class Homework01 {
    /*
     * 
     * 3) (Дополнительно) Реализуйте метод, принимающий в качестве аргументов два
     * целочисленных массива,
     * и возвращающий новый массив, каждый элемент которого равен частному элементов
     * двух входящих массивов в той же ячейке.
     * Если длины массивов не равны, необходимо как-то оповестить пользователя.
     * Важно: При выполнении метода единственное исключение, которое пользователь
     * может увидеть - RuntimeException, т.е. ваше.
     */
    public static void main(String[] args) {
        // task1();

        // Scanner scanner = new Scanner(System.in);
        // System.out.print("Введите длину массива 1: ");
        // int length = scanner.nextInt();
        // int[] array1 = new int[length];
        // System.out.println("Введите элементы массива:");
        // for (int i = 0; i < length; i++) {
        // array1[i] = scanner.nextInt();
        // }
        // System.out.print("Введите длину массива 2: ");
        // length = scanner.nextInt();
        // int[] array2 = new int[length];
        // System.out.println("Введите элементы массива:");
        // for (int i = 0; i < length; i++) {
        // array2[i] = scanner.nextInt();
        // }
        // task2(array1, array2);
    }

    public static void task3() {

    }

    /*
     * 2) Реализуйте метод, принимающий в качестве аргументов два целочисленных
     * массива, и возвращающий новый массив,
     * каждый элемент которого равен разности элементов двух входящих массивов в той
     * же ячейке. Если длины массивов не равны,
     * необходимо как-то оповестить пользователя.
     */
    public static void task2(int[] arr1, int[] arr2) {
        if (arr1.length != arr2.length) {
            System.out.println("Размерность массивов должна быть одинаковой");
            return;
        }
        int[] result = new int[arr1.length];
        for (int i = 0; i < result.length; i++) {
            result[i] = arr1[i] - arr2[i];
        }
    }

    /* 1) Реализуйте 3 метода, чтобы в каждом из них получить разные исключения */
    public static void task1() {
        method1();
        method2();
        method3();
    }

    public static void method1() {
        try {
            int i = 2 / 0;
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    public static void method2() {
        try {
            int[] i = new int[3];
            int j = i[4];
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    public static void method3() {
        try (FileReader reader = new FileReader("notes3.txt")) {
            // читаем посимвольно
            int c;
            while ((c = reader.read()) != -1) {

                System.out.print((char) c);
            }
        } catch (IOException ex) {

            System.out.println(ex.getMessage());
        }
    }

}
