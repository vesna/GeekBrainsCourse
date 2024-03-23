package Java_Homeworks.Seminar04;

import java.util.ArrayList;
import java.util.Scanner;

/*Реализовать консольное приложение, которое:
Принимает от пользователя и “запоминает” строки.
Если введено print, выводит строки так, чтобы последняя введенная была первой в списке, а первая - последней.
Если введено revert, удаляет предыдущую введенную строку из памяти.

 */
public class Task02 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        ArrayList<String> list = new ArrayList<>();
        for (int i = 0; i < 5; i++) {
            String string = sc.nextLine();
            if(string.equalsIgnoreCase("print")){
                String temp = list.get(0);
                list.set(0,list.get(i-1));
                list.set(i-1,temp);
            }
            else if (string.equalsIgnoreCase("revert")) {
                list.remove(i-1);
            }
            else{
                list.add(i, string);
            }

        }
        System.out.println(list);
    }
}
