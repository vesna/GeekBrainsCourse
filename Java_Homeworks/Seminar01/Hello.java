import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;

class Hello{
    public static void main(String[] args){
        System.out.println("Hello World!");

        sou
        LocalDateTime now = LocalDateTime.now();
        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd.MM.YYYY");
                System.out.println(formatter.format(now));
    }
}