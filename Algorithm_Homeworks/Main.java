package Algorithm_Homeworks;

import java.time.Duration;
import java.time.LocalTime;
import java.util.Random;

public class Main {
    public static void main(String[] args) {

        int[] array = new int[50000];
        for (int i = 0; i < array.length; i++)
            array[i] = new Random().nextInt(200);
        int[] array2 = array;
        LocalTime timeQuickSortStart = LocalTime.now();
        quickSort(array);
        LocalTime timeQuickSortEnd = LocalTime.now();

        LocalTime timeInsertSortStart = LocalTime.now();
        inserterSort(array2);
        LocalTime timeInsertSortEnd = LocalTime.now();

        System.out.println(Duration.between(timeQuickSortStart, timeQuickSortEnd));

        System.out.println(Duration.between(timeInsertSortStart, timeInsertSortEnd));

        LinkedList linkedList = new LinkedList();
        for (int i = 0; i < 10; i++)
            linkedList.add(new Random().nextInt(200));
    }

    public static void quickSort(int[] array) {
        quickSortRecursive(array, 0, array.length - 1);
    }

    public static void quickSortRecursive(int[] array, int leftBorder, int rightBorder) {
        int leftMarker = leftBorder;
        int rightMarker = rightBorder;
        int pivot = array[(leftMarker + rightMarker) / 2];
        do {
            while (array[leftMarker] < pivot)
                leftMarker++;
            while (array[rightMarker] > pivot)
                rightMarker--;
            if (leftMarker <= rightMarker) {
                if (leftMarker < rightMarker) {
                    int temp = array[leftMarker];
                    array[leftMarker] = array[rightMarker];
                    array[rightMarker] = temp;
                }
                leftMarker++;
                rightMarker--;
            }
        } while (leftMarker <= rightMarker);
        if (leftMarker < rightBorder)
            quickSortRecursive(array, leftMarker, rightBorder);
        if (leftBorder < rightMarker)
            quickSortRecursive(array, leftBorder, rightMarker);
    }

    public static void inserterSort(int[] array) {
        for (int left = 0; left < array.length; left++) {
            // Р’С‹С‚Р°СЃРєРёРІР°РµРј Р·РЅР°С‡РµРЅРёРµ СЌР»РµРјРµРЅС‚Р°
            int value = array[left];
            // РџРµСЂРµРјРµС‰Р°РµРјСЃСЏ РїРѕ СЌР»РµРјРµРЅС‚Р°Рј, РєРѕС‚РѕСЂС‹Рµ РїРµСЂРµРґ
            // РІС‹С‚Р°С‰РµРЅРЅС‹Рј СЌР»РµРјРµРЅС‚РѕРј
            int i = left - 1;
            for (; i >= 0; i--) {
                // Р•СЃР»Рё РІС‹С‚Р°С‰РёР»Рё Р·РЅР°С‡РµРЅРёРµ РјРµРЅСЊС€РµРµ вЂ”
                // РїРµСЂРµРґРІРёРіР°РµРј Р±РѕР»СЊС€РёР№ СЌР»РµРјРµРЅС‚ РґР°Р»СЊС€Рµ
                if (value < array[i]) {
                    array[i + 1] = array[i];
                } else {
                    // Р•СЃР»Рё РІС‹С‚Р°С‰РµРЅРЅС‹Р№ СЌР»РµРјРµРЅС‚ Р±РѕР»СЊС€Рµ вЂ”
                    // РѕСЃС‚Р°РЅР°РІР»РёРІР°РµРјСЃСЏ
                    break;
                }
            }
            // Р’ РѕСЃРІРѕР±РѕРґРёРІС€РµРµСЃСЏ РјРµСЃС‚Рѕ РІСЃС‚Р°РІР»СЏРµРј
            // РІС‹С‚Р°С‰РµРЅРЅРѕРµ Р·РЅР°С‡РµРЅРёРµ
            array[i + 1] = value;
        }
    }
}
