package Java_Homeworks.Seminar03;

import java.util.Arrays;

public class Homework {
    public static void main(String[] args) {
        /*1. Реализовать алгоритм сортировки слиянием.*/
        // int[] array = {5, 1, 2, 3, 4, 8, 0 };
        // mergeSort(array, 0, array.length - 1);
        // System.out.println(Arrays.toString(array));

        /* 2. Пусть дан произвольный список целых чисел. Удалить из него чётные числа.*/

        /*3. Задан целочисленный список ArrayList. Найти минимальное, максимальное и среднее арифметичское этого списка.*/

        /*4*. (Необязательная задача повышенной сложности)
        Даны два ArrayList из целых чисел. Написать функции, которые вычисляют разницу коллекций:
        Разность:
        A - B = все числа из первой коллекции, которые не содержатся во второй коллекции
        B - A = все числа из второй коллекции, которые не содержатся в первой
        Симметрическая разность:
        A ^ B = числа из первой коллекции, которых нет во второй, А ТАКЖЕ числа из второй, которых нет в первой */
    }

    private static void mergeSort(int[] array, int begin, int end){
        if(begin == end)
            return;
        int mid = (begin + end) / 2;
        mergeSort(array, begin, mid);
        mergeSort(array, mid + 1, end);

        int[] sorted = new int[array.length];
        int inLeft = begin, inRight = mid + 1, inSorted = begin;
        int endLeft = mid + 1, endRight = end + 1;
        while(inLeft < endLeft || inRight < endRight){
            if(inLeft < endLeft && inRight < endRight){
                if(array[inLeft] < array[inRight]){
                    sorted[inSorted++] =  array[inLeft++];
                }
                else {
                    sorted[inSorted++] =  array[inRight++];
                }
            }
            else if(inLeft < endLeft){
                sorted[inSorted++] =  array[inLeft++];
            }
            else if(inRight < endRight){
                sorted[inSorted++] =  array[inRight++];
            }
            else 
                throw new IllegalStateException("невозможно сюда попасть");
        }
        for(int i = begin; i <= end; i++){
            array[i] = sorted[i];
        }
    }
}
