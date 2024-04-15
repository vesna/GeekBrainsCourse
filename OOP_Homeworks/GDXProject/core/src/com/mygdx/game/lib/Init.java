package com.mygdx.game.lib;

import java.util.ArrayList;
import java.util.Collections;
import java.util.Comparator;
import java.util.HashSet;
import java.util.Random;
import java.util.Scanner;

import com.mygdx.game.MyGdxGame;
import com.mygdx.game.lib.*;

public class Init {
    // public static final int GANG_SIZE = 10;
    // public static ArrayList<Unit> whiteSide;
    // public static ArrayList<Unit> darkSide;
    // public static ArrayList<Unit> allUnits;

    public static void main(String[] args) {
        InitLib();
        // arrayList.forEach(Unit::getNAME);
        // arrayList.forEach(n -> n.step(arrayList2));
        Scanner scanner = new Scanner(System.in);
        while (true) {
           // ConsoleView.view();
            makeStep();
            scanner.nextLine();
        }

        // allUnits.forEach(n -> System.out.println(n.toString()));

        // whiteSide.forEach(n -> n.step(darkSide, whiteSide));
    }

    public static void InitLib() {
        MyGdxGame.whiteSide = new ArrayList<>();
        MyGdxGame.darkSide = new ArrayList<>();
        MyGdxGame.allUnits = new ArrayList<>();

        Random rnd = new Random();
        int x = 1;
        int y = 1;
        for (int i = 0; i < MyGdxGame.GANG_SIZE; i++) {
            switch (rnd.nextInt(4)) {
                case 0:
                MyGdxGame.whiteSide.add(new Peasant(MyGdxGame.whiteSide, x, y++, MyGdxGame.GANG_SIZE));
                    break;
                case 1:
                MyGdxGame.whiteSide.add(new Robber(MyGdxGame.whiteSide, x, y++, MyGdxGame.GANG_SIZE));
                    break;
                case 2:
                MyGdxGame.whiteSide.add(new Sniper(MyGdxGame.whiteSide, x, y++, MyGdxGame.GANG_SIZE));
                    break;
                default:
                MyGdxGame.whiteSide.add(new Witcher(MyGdxGame.whiteSide, x, y++, MyGdxGame.GANG_SIZE));
                    break;
            }
        }

        x = MyGdxGame.GANG_SIZE;
        y = 1;
        for (int i = 0; i < MyGdxGame.GANG_SIZE; i++) {
            switch (rnd.nextInt(4)) {
                case 0:
                MyGdxGame.darkSide.add(new Peasant(MyGdxGame.darkSide, x, y++, MyGdxGame.GANG_SIZE));
                    break;
                case 1:
                MyGdxGame.darkSide.add(new SpearMan(MyGdxGame.darkSide, x, y++, MyGdxGame.GANG_SIZE));
                    break;
                case 2:
                MyGdxGame.darkSide.add(new XBowMan(MyGdxGame.darkSide, x, y++, MyGdxGame.GANG_SIZE));
                    break;
                default:
                MyGdxGame.darkSide.add(new Monk(MyGdxGame.darkSide, x, y++, MyGdxGame.GANG_SIZE));
                    break;
            }
        }

        MyGdxGame.allUnits.addAll(MyGdxGame.whiteSide);
        MyGdxGame.allUnits.addAll(MyGdxGame.darkSide);
    }

    public static void makeStep() {
        HashSet<Integer> speedRates = new HashSet<>();
        for (Unit unit : MyGdxGame.allUnits) {
            speedRates.add(unit.getSpeed());
        }

        ArrayList<Integer> speeds = new ArrayList<>(speedRates);
        Collections.sort(speeds, Collections.reverseOrder());

        for (int speed : speeds) {
            ArrayList<Unit> speedArray = new ArrayList<>();
            for (Unit unit : MyGdxGame.allUnits) {
                if (unit.getSpeed() == speed) {
                    speedArray.add(unit);
                }

            }
            Collections.shuffle(speedArray);
            for (Unit unit : speedArray) {
                if (unit.getName().equals(MyGdxGame.darkSide)) {
                    unit.step(MyGdxGame.whiteSide);
                } else {
                    unit.step(MyGdxGame.darkSide);
                }
            }
        }
        // allUnits.sort(new Comparator<Unit>() {
        // @Override
        // public int compare(Unit u1, Unit u2) {
        // if (u1.getSpeed() == u2.getSpeed())
        // return 0;
        // else if (u1.getSpeed() > u2.getSpeed())
        // return 1;
        // else
        // return -1;
        // }
        // });
    }
}
