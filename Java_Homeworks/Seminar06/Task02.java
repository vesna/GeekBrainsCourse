package Java_Homeworks.Seminar06;

import java.time.LocalDate;

/*1. Продумайте структуру класса Кот. Какие поля и методы будут актуальны для приложения, которое является
а) информационной системой ветеринарной клиники
б) архивом выставки котов
в) информационной системой Театра кошек Ю. Д. Куклачёва
Можно записать в текстовом виде, не обязательно реализовывать в java.
 */
public class Task02 {
    public static void main(String[] args) {
        Vaccination vaccination = new Vaccination(LocalDate.of(2023,2,28),"Bayer", "от столбняка");
        System.out.println(vaccination);
        System.out.println(vaccination.getDate());

        Cat cat = new Cat("Барсик", "Виктория","Британец",LocalDate.of(2001,1, 1),"Белый");
        System.out.println(cat);

        cat.addVacctination(vaccination);
        cat.addVacctination(new Vaccination(LocalDate.of(2002, 1, 1), "Bayer", "от бешенства"));

        System.out.println(cat);

    }
}
