package OOP_Homeworks;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.HashSet;
import java.util.Random;
import java.util.Scanner;

import OOP_Homeworks.Units.*;

public class Main {
    public static final int GANG_SIZE = 10;
    public static ArrayList<Unit> whiteSide;
    public static ArrayList<Unit> darkSide;
    public static ArrayList<Unit> allUnits;

    public static void main(String[] args) {
        Init();
        // arrayList.forEach(Unit::getNAME);
        // arrayList.forEach(n -> n.step(arrayList2));
        Scanner scanner = new Scanner(System.in);
        while (true) {
            ConsoleView.view();
            makeStep();
            scanner.nextLine();
        }

        // allUnits.forEach(n -> System.out.println(n.toString()));

        // whiteSide.forEach(n -> n.step(darkSide, whiteSide));
    }

    private static void Init() {
        whiteSide = new ArrayList<>();
        darkSide = new ArrayList<>();
        allUnits = new ArrayList<>();

        Random rnd = new Random();
        int x = 1;
        int y = 1;
        for (int i = 0; i < GANG_SIZE; i++) {
            switch (rnd.nextInt(4)) {
                case 0:
                    whiteSide.add(new Peasant(whiteSide, x, y++, GANG_SIZE));
                    break;
                case 1:
                    whiteSide.add(new Robber(whiteSide, x, y++, GANG_SIZE));
                    break;
                case 2:
                    whiteSide.add(new Sniper(whiteSide, x, y++, GANG_SIZE));
                    break;
                default:
                    whiteSide.add(new Witcher(whiteSide, x, y++, GANG_SIZE));
                    break;
            }
        }

        x = GANG_SIZE;
        y = 1;
        for (int i = 0; i < GANG_SIZE; i++) {
            switch (rnd.nextInt(4)) {
                case 0:
                    darkSide.add(new Peasant(darkSide, x, y++, GANG_SIZE));
                    break;
                case 1:
                    darkSide.add(new SpearMan(darkSide, x, y++, GANG_SIZE));
                    break;
                case 2:
                    darkSide.add(new XBowMan(darkSide, x, y++, GANG_SIZE));
                    break;
                default:
                    darkSide.add(new Monk(darkSide, x, y++, GANG_SIZE));
                    break;
            }
        }

        allUnits.addAll(whiteSide);
        allUnits.addAll(darkSide);
    }

    private static void makeStep() {
        HashSet<Integer> speedRates = new HashSet<>();
        for (Unit unit : allUnits) {
            speedRates.add(unit.getSpeed());
        }

        ArrayList<Integer> speeds = new ArrayList<>(speedRates);
        Collections.sort(speeds, Collections.reverseOrder());

        for (int speed : speeds) {
            ArrayList<Unit> speedArray = new ArrayList<>();
            for (Unit unit : allUnits) {
                if (unit.getSpeed() == speed) {
                    speedArray.add(unit);
                }

            }
            Collections.shuffle(speedArray);
            for (Unit unit : speedArray) {
                if (unit.getName().equals(darkSide)) {
                    unit.step(whiteSide);
                } else {
                    unit.step(darkSide);
                }
            }
        }
        // allUnits.sort(new Comparator<Unit>() {
        //     @Override
        //     public int compare(Unit u1, Unit u2) {
        //         if (u1.getSpeed() == u2.getSpeed())
        //             return 0;
        //         else if (u1.getSpeed() > u2.getSpeed())
        //             return 1;
        //         else
        //             return -1;
        //     }
        // });
    }
}
