package Java_Homeworks.Seminar05;

import java.util.*;

/*Написать программу, определяющую правильность расстановки скобок в выражении.
Пример 1: a+(d*3) - истина
Пример 2: [a+(1*3) - ложь
Пример 3: [6+(3*3)] - истина
Пример 4: {a}[+]{(d*3)} - истина
Пример 5: <{a}+{(d*3)}> - истина
Пример 6: {a+]}{(d*3)} - ложь

 */
public class Task02 {
    public static void main(String[] args) {
        String formula = "(a*{b+<sh>})";
        System.out.println(isValid(formula));
    }

    public static boolean isValid(String formula){
        Map<Character, Character> bracketsDict = new HashMap<>();
        bracketsDict.put('(', ')');
        bracketsDict.put('[', ']');
        bracketsDict.put('{', '}');
        bracketsDict.put('<', '>');
        ArrayDeque<Character> brackets = new ArrayDeque<>();
        for (char c: formula.toCharArray()){
            if(bracketsDict.containsKey(c)){
                brackets.add(c);
            }
            else if (bracketsDict.containsValue(c)){
                if(brackets.isEmpty())
                    return false;
                char open = brackets.removeLast();
                if (bracketsDict.get(open) != c){
                    return false;
                }

            }
        }
        return brackets.isEmpty();
    }
}
