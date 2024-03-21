package Java_Homeworks.Seminar02;

public class Task01 {
    /*Дано четное число N (>0) и символы c1 и c2. 
Написать метод, который вернет строку длины N, которая состоит из чередующихся символов c1 и c2, начиная с c1.
    */public static void main(String[] args){
        char c1 = 'a';
        char c2 = 't';
        int num = 10;
        System.out.println(createAlteraitingString (c1, c2, num));
    }
    private static String createAlteraitingString (char c1, char c2, int num){
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < num; i++) {
            if (i % 2 == 0) result.append(c1);
            else result.append(c2);
        }   
        return result.toString();
    }
    
}

