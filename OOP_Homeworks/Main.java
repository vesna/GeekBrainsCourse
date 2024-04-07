package OOP_Homeworks;

import java.util.ArrayList;
import java.util.Comparator;
import java.util.Random;

import OOP_Homeworks.Units.*;

public class Main {
    public static void main(String[] args) {

        ArrayList<Unit> arrayList = new ArrayList<>();
        arrayList.add(new Sniper(getNames()));
        arrayList.add(new XBowMan(getNames()));
        arrayList.add(new Monk(getNames()));
        ArrayList<Unit> arrayList2 = new ArrayList<>();
        arrayList2.add(new Sniper(getNames()));
        arrayList2.add(new XBowMan(getNames()));
        arrayList2.add(new Monk(getNames()));

       // arrayList.forEach(Unit::getNAME);

        
       // arrayList.forEach(n -> n.step(arrayList2));

        ArrayList<Unit> list = new ArrayList<>();
        list.addAll(arrayList);
        list.addAll(arrayList2);

        list.sort(new Comparator<Unit>(){
            @Override
            public int compare(Unit u1, Unit u2){
                if(u1.getSpeed() == u2.getSpeed()) return 0;
                else if(u1.getSpeed() > u2.getSpeed()) return 1;
                else return -1;
            }
        });

        list.forEach(n -> System.out.println(n.getSpeed()));

        arrayList.forEach(n -> n.step(arrayList2, arrayList));
    }

    private static String getNames(){
        return Names.values()[new Random().nextInt(Names.values().length)].toString();
    }

}
