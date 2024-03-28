package Java_Homeworks.Seminar02;
import java.util.Arrays;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Homework {
    private static Logger logger = Logger.getLogger(Homework.class.getName());
    public static void main(String[] args){
        /*1. В файле содержится строка с исходными данными в такой форме:
{"name":"Ivanov", "country":"Russia", "city":"Moscow", "age":"null"}
Требуется на её основе построить и вывести на экран новую строку, в форме SQL запроса:
SELECT * FROM students WHERE name = "Ivanov" AND country = "Russia" AND city = "Moscow";
Для разбора строки используйте String.split.
Сформируйте новую строку, используя StringBuilder. Значения null не включаются в запрос. */

        // String input = "{\"name\":\"Ivanov\", \"country\":\"Russia\", \"city\":\"Moscow\", \"age\":\"null\"}";
        // input = input.substring(1, input.length() - 1);
        // System.out.println(input);
        
        // StringBuilder builder = new StringBuilder();
        // builder.append("SELECT * FROM students WHERE ");
        
        // String[] parts = input.split (", ");
        // boolean isFirst = true;
        // for (String part : parts) {
        // // System.out.println(part);
        //     String[] keyValue = part.split (":");
        //     String key = keyValue[0];
        //     key = key.substring (1, key.length() - 1);
        //     String value = keyValue[1];
        //     System.out.println(key);
        //     System.out.println(value);
        
        //     if (value.equals ("\"null\""))
        //     continue;
        //     if (!isFirst)
        //         builder.append(" AND ");
        //     builder.append (String.format ("%s = %s", key, value));
        //     isFirst = false;
        // }
        // builder.append(";");
        // System.out.println(builder.toString());

/*2. Реализуйте алгоритм сортировки пузырьком числового массива, результат после каждой итерации запишите в лог-файл. */
        // int[] array = {1, 4, 7, 2, 9, 8 };
        // System.out.println(Arrays.toString(array));
        // BubbleSort(array);
        // System.out.println(Arrays.toString(array));

/*3. В файле содержится строка с данными:
[{"фамилия":"Иванов","оценка":"5","предмет":"Математика"}, {"фамилия":"Петрова","оценка":"4","предмет":"Информатика"}, {"фамилия":"Краснов","оценка":"5","предмет":"Физика"}]
Напишите метод, который разберёт её на составные части и, используя StringBuilder создаст массив строк такого вида:
Студент Иванов получил 5 по предмету Математика.
Студент Петрова получил 4 по предмету Информатика.
Студент Краснов получил 5 по предмету Физика. */
        String input1 = "[{\"фамилия\":\"Иванов\",\"оценка\":\"5\",\"предмет\":\"Математика\"}, {\"фамилия\":\"Петрова\",\"оценка\":\"4\",\"предмет\":\"Информатика\"}, {\"фамилия\":\"Краснов\",\"оценка\":\"5\",\"предмет\":\"Физика\"}]";
        input1 = clip (input1); // убрать []
        String[] students = input1.split (", ");
        for (String student : students) {
            student = clip (student);
            String[] keyValues = student.split (",");
            String name = "", grade = "", subject = "";
            for (String keyValue : keyValues) {
                String[] keyValueParts = keyValue.split (":");
                String key = clip (keyValueParts[0]);
                String value = clip (keyValueParts[1]);

                if (key.equals ("фамилия"))
                    name = value;
                else if (key.equals ("оценка"))
                    grade = value;
                else if (key.equals ("предмет"))
                    subject = value;
                else 
                    throw new IllegalStateException("не понял, что за поле");
            }
            System.out.printf("Студент %s получил %s по предмету %s. \n", name, grade, subject);
        }
    }

    private static String clip(String str) {
        return str.substring(1, str.length() - 1);
    }

    private static void BubbleSort(int[] array){
        for (int ceiling = array.length; ceiling >= 0; ceiling--){
            for (int i = 0; i < ceiling && i + 1 < ceiling; i++){
                if (array[i] > array[i + 1]){
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    logger.log(Level.INFO, String.format ("%d <-> %d, %s",
                    array[i], array[i +1], Arrays.toString(array)));
                }
            }
        }
    }
    
}

