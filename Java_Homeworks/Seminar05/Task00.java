package Java_Homeworks.Seminar05;

import java.util.LinkedHashMap;
import java.util.Map;
/*Создать структуру для хранения Номеров паспортов и Фамилий сотрудников организации.
123456 Иванов
321456 Васильев
234561 Петрова
234432 Иванов
654321 Петрова
345678 Иванов
Вывести данные по сотрудникам с фамилией Иванов.
 */
public class Task00 {
    public static void main(String[] args) {
        Map<Integer, String> passportToName = new LinkedHashMap<> ();
        passportToName.put (123456, "Иванов");
        passportToName.put (321456, "Васильев");
        passportToName.put (234561, "Петрова");
        passportToName.put (234432, "Иванов");
        passportToName.put (654321, "Петрова");
        passportToName.put (345678, "Иванов");
        System.out.println(passportToName);

        for (Map.Entry<Integer, String> entry : passportToName.entrySet())
            if (entry.getValue().equals ("Иванов"))
                System.out.println(entry);
    }
}
