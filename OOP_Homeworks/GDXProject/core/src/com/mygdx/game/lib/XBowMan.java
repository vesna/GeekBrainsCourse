package com.mygdx.game.lib;

import java.util.ArrayList;

public class XBowMan extends Shooter {

    public XBowMan(ArrayList<Unit> name, int x, int y, int ganagSize) {
        super(6, 3, 2, 3, 10, 4, name, 16, x, y, ganagSize);
    }

    public XBowMan(int attack, int defense, float minDamage, float maxDamage, float hp, int speed, ArrayList<Unit> name,
            int arrows, int x, int y, int ganagSize) {
        super(attack, defense, minDamage, maxDamage, hp, speed, name, arrows, x, y, ganagSize);
    }

    // @Override
    // public void step(ArrayList<Unit> team) {
    // System.out.println("XBowMan shooting!");
    // }

    @Override
    public String getInfo() {
        return "Арбалетчик";
    }
}
