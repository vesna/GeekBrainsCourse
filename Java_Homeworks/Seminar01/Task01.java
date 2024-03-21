package Java_Homeworks.Seminar01;
/*Написать программу, которая запросит пользователя ввести <Имя> в консоли. 
Получит введенную строку и выведет в консоль сообщение “Привет, <Имя>!”
 */

import java.util.Scanner;

public class Task01 {
    public static void main(String[] args){
        System.out.println("Назовите имя: ");
        Scanner sc = new Scanner(System.in, "cp866");
        String myName = sc.nextLine();
        System.out.println(String.format("Привет, %s!", myName));
        System.out.printf("Привет, %s!\n", myName);
        sc.close();
    }
}
