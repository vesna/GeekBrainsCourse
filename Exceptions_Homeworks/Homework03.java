
/*
 * Напишите приложение, которое будет запрашивать у пользователя следующие
 * данные, разделенные пробелом:
 * Фамилия Имя Отчество номертелефона
 * Форматы данных:
 * фамилия, имя, отчество - строки
 * номертелефона - целое беззнаковое число без форматирования
 * Ввод всех элементов через пробел
 * 
 * Приложение должно проверить введенные данные по количеству. Если количество
 * не совпадает с требуемым, вернуть код ошибки, обработать его и показать
 * пользователю сообщение, что он ввел меньше и больше данных, чем требуется.
 * Приложение должно попытаться распарсить полученные значения и выделить из них
 * требуемые параметры. Если форматы данных не совпадают, нужно бросить
 * исключение, соответствующее типу проблемы. Можно использовать встроенные типы
 * java и создать свои. Исключение должно быть корректно обработано,
 * пользователю выведено сообщение с информацией, что именно неверно.
 * 
 * Если всё введено и обработано верно, должен создаться файл с названием,
 * равным фамилии, в него в одну строку должны записаться полученные данные,
 * вида
 * <Фамилия><Имя><Отчество><номер_телефона>
 * Однофамильцы должны записаться в один и тот же файл, в отдельные строки.
 * 
 * Не забудьте закрыть соединение с файлом.
 * При возникновении проблемы с чтением-записью в файл, исключение должно быть
 * корректно обработано, пользователь должен увидеть стектрейс ошибки.
 */
import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.nio.file.Files;
import java.nio.file.Path;
import java.nio.file.StandardOpenOption;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;

public class Homework03 {

    public static SimpleDateFormat format = new SimpleDateFormat("dd.mm.yyyy");

    public static void main(String[] args) {
        String text;
        System.out.println(
                "Введите через пробел ФИО,\n дату рождения (dd.mm.yyyy),\n номер телефона (число без разделителей)\n и пол(символ латиницей f или m)\n");

        try (BufferedReader bf = new BufferedReader(new InputStreamReader(System.in))) {

            text = bf.readLine();
            WriteRecord(ParseText(text));
            System.out.println("success");
        } catch (IOException e) {
            System.out.println(e.getLocalizedMessage());

        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }

    public static void WriteRecord(Record res) throws Exception {

        Path filePath = Path.of(res.surname.toLowerCase() + ".txt");
        BufferedWriter fileWriter;
        if (!Files.exists(filePath)) {
            Files.createFile(filePath);
            fileWriter = Files.newBufferedWriter(filePath);
        } else {
            fileWriter = Files.newBufferedWriter(filePath, StandardOpenOption.APPEND);
            fileWriter.write('\n');
        }
        fileWriter.write(res.toString());
        fileWriter.close();
    }

    public static Record ParseText(String text) throws Exception {
        String[] array = text.split(" ");
        if (array.length != 6) {
            throw new Exception("Введено неверное количество параметров, должно быть 6");
        }
        String surname = array[0];
        String name = array[1];
        String patronymic = array[2];
        Date birthdate;
        try {
            birthdate = format.parse(array[3]);
        } catch (ParseException e) {
            throw new ParseException("Неверный формат даты рождения", e.getErrorOffset());
        }
        Long phone;
        try {
            phone = Long.parseLong(array[4]);
        } catch (NumberFormatException e) {
            throw new NumberFormatException("Неверный формат телефона");
        }
        String sex = array[5];
        if (!sex.toLowerCase().equals("m") && !sex.toLowerCase().equals("f")) {
            throw new RuntimeException("Неверно введен пол");
        }

        Record result = new Record(surname, name, patronymic, birthdate, phone, sex);
        return result;
    }

    public static class Record {
        private String surname;
        private String name;
        private String patronymic;
        private Date birthday;
        private Long phone;
        private String sex;

        public String getSurname() {
            return surname;
        }

        public void setSurname(String surname) {
            this.surname = surname;
        }

        public String getName() {
            return name;
        }

        public void setName(String name) {
            this.name = name;
        }

        public String getPatronymic() {
            return patronymic;
        }

        public void setPatronymic(String patronymic) {
            this.patronymic = patronymic;
        }

        public Date getBirthday() {
            return birthday;
        }

        public void setBirthday(Date birthday) {
            this.birthday = birthday;
        }

        public Long getPhone() {
            return phone;
        }

        public void setPhone(Long phone) {
            this.phone = phone;
        }

        public String getSex() {
            return sex;
        }

        public void setSex(String sex) {
            this.sex = sex;
        }

        public Record(String surname, String name, String patronymic, Date birthday, Long phone, String sex) {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.birthday = birthday;
            this.phone = phone;
            this.sex = sex;
        }

        @Override
        public String toString() {
            return String.format("%s %s %s %s %s %s", surname, name, patronymic, format.format(birthday),
                    phone, sex);
        }

    }

}
