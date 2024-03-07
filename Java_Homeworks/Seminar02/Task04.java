package Java_Homeworks.Seminar02;
import java.io.FileWriter;
import java.io.IOException;
import java.util.Scanner;
public class Task04 {

/**
* Напишите метод, который составит строку,
* состоящую из 100 повторений слова TEST и метод,
* который запишет эту строку в простой текстовый файл, обработайте исключения.
khan academy
leet code
code wars
https://lyrical-galette-983.notion.site/4557d2f0c59544958976293bb808dd04.
*/

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Введите слово: ");
        String text = sc.nextLine();

        writeString(repeatString(text));
        sc.close();
    }

    private static String repeatString(String part) {
        StringBuilder fullMaker = new StringBuilder();
        for (int i = 0; i < 100; i++) {
            fullMaker.append(part);
        }
        return fullMaker.toString();
    }

    private static void writeString(String str) {
        FileWriter file;
        try (file = new FileWriter("test.txt")){
            file.append(str);
            System.out.println("Файл успешно создан");
        } 
        catch (IOException ex) {
            System.err.println("Ошибка: " + ex);
        } 
        finally {
            if (file != null) {
                try {
                    file.close();
                } 
                catch (IOException ex) {
                    System.err.println("Ошибка: " + ex);
                }
            }
            
         }
    }
}

