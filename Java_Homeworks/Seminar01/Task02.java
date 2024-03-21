package Java_Homeworks.Seminar01;
/*Дан массив двоичных чисел, например [1,1,0,1,1,1], вывести максимальное количество подряд идущих 1. */
public class Task02 {
    public static void main(String[] args){
        int[] arr = new int[]{1,1,0,1,1,1};
        int count = 0;
        int res = 0;
        for(int i = 0; i < arr.length; i++){
            if(arr[i] == 1){
                count++;
            }else{
                if(count > res) res = count;
                count = 0;
            }
        }
        if(count > res) res = count;
        System.out.println(res);
    }
}
