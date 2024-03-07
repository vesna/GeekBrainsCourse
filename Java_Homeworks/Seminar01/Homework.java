//* +Задано уравнение вида q + w = e, q, w, e >= 0. Некоторые цифры могут быть заменены знаком вопроса, 
//например 2? + ?5 = 69. Требуется восстановить выражение до верного равенства. Предложить хотя бы одно 
//решение или сообщить, что его нет. */

import java.util.Scanner;

public class Homework {
    static Scanner scanner = new Scanner(System.in);
    public static void main(String[] args){
        /*Вычислить n-ое треугольного число(сумма чисел от 1 до n), n! (произведение чисел от 1 до n)*/
        // System.out.println("N: ");
        // Scanner sc = new Scanner(System.in, "cp866");
        // int n = Integer.valueOf(sc.nextLine());
        // int res = 1;
        // int res1 = 1;
        // for(int i = 2; i <= n; i++){
        //     res = res + i;
        //     res1 = res1 * i;
        // }
        // sc.close();
        // System.out.println(String.format("n-ое треугольного число: %s", res));
        // System.out.println(String.format("n!: %s", res1));

        //Вывести все простые числа от 1 до 1000
        // for (int j = 2; j <= 1000; j++) {
        //     boolean simple = false;

        //     for (int i = 2; i * i <= j; i++) {
        //         simple = (j % i == 0);
        //         if (simple) {
        //             break;
        //         }
        //     }
        //     if (!simple) {
        //         System.out.print(j + " ");
        //     }
        // }

        //Реализовать простой калькулятор
        // int num1 = getInt();
        // int num2 = getInt();
        // char operation = getOperation();
        // int result = calc(num1,num2,operation);
        // System.out.println("Результат операции: "+result);
    }
 
    public static int getInt(){
        System.out.println("Введите число:");
        int num;
        if(scanner.hasNextInt()){
            num = scanner.nextInt();
        } else {
            System.out.println("Вы допустили ошибку при вводе числа. Попробуйте еще раз.");
            scanner.next();//рекурсия
            num = getInt();
        }
        return num;
    }
 
    public static char getOperation(){
        System.out.println("Введите операцию:");
        char operation;
        if(scanner.hasNext()){
            operation = scanner.next().charAt(0);
        } else {
            System.out.println("Вы допустили ошибку при вводе операции. Попробуйте еще раз.");
            scanner.next();//рекурсия
            operation = getOperation();
        }
        return operation;
    }
 
    public static int calc(int num1, int num2, char operation){
        int result;
        switch (operation){
            case '+':
                result = num1+num2;
                break;
            case '-':
                result = num1-num2;
                break;
            case '*':
                result = num1*num2;
                break;
            case '/':
                result = num1/num2;
                break;
            default:
                System.out.println("Операция не распознана. Повторите ввод.");
                result = calc(num1, num2, getOperation());//рекурсия
        }
        return result;
    }

}
