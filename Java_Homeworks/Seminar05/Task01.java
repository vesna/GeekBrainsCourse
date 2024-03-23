package Java_Homeworks.Seminar05;

import java.util.*;

/*Даны 2 строки, написать метод, который вернет true, если эти строки являются изоморфными и false, если нет. Строки изоморфны, если одну букву в первом слове можно заменить на некоторую букву во втором слове, при этом
повторяющиеся буквы одного слова меняются на одну и ту же букву с сохранением порядка следования. (Например, add - egg изоморфны)
буква может не меняться, а остаться такой же. (Например, note - code)
Пример 1:
Input: s = "foo", t = "bar"
Output: false
Пример 2:
Input: s = "paper", t = "title"
Output: true
 */
public class Task01 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Введитке перрвую строку");
        String firstLine = sc.nextLine();
        System.out.println("Введитке вторую строку");
        String secondLine = sc.nextLine();
        sc.close();
        System.out.println(isomorphicCheck(firstLine, secondLine));
    }

    public static boolean isomorphicCheck(String x, String y){
            if (x.length() != y.length())
                return false;
            Map<Character, Character> pairs = new HashMap<>();
            for(int i = 0; i < x.length(); i++){
                if(pairs.containsKey(x.charAt(i))){
                    if(pairs.get(x.charAt(i)) != y.charAt(i)){
                        return false;
                    }
                }
                else {
                    pairs.put(x.charAt(i), y.charAt(i));
                }
            }
            return true;
    }
}
