package Java_Homeworks.Seminar02;

import java.util.Scanner;

public class Task03 {
    /**Напишите метод, который принимает на вход строку (String) 
    и определяет является ли строка палиндромом (возвращает boolean значение). */
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        System.out.println("Введите строку: ");
        String str = scanner.nextLine();

        System.out.println(isPalindrome(str));

        scanner.close();
    }

    private static boolean isPalindrome(String str) {
        for (int i = 0; i < str.length() - i; i++) {
            if (str.charAt(i) != str.charAt(str.length() - 1 - i)) {
                return false;
            }
        }
        return true;
    }
}
