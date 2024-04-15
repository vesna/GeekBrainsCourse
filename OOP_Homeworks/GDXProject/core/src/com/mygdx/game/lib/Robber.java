package com.mygdx.game.lib;

import java.util.ArrayList;

public class Robber extends MelleUnit {

    public Robber(ArrayList<Unit> name, int x, int y, int ganagSize) {
        super(8, 3, 2, 4, 10, 6, name, x, y, ganagSize, 1);
    }

    public Robber(int attack, int defense, float minDamage, float maxDamage, float hp, int speed, ArrayList<Unit> name,
            int x, int y, int ganagSize, int stamina) {
        super(attack, defense, minDamage, maxDamage, hp, speed, name, x, y, ganagSize, stamina);
    }

    @Override
    public String getInfo() {
        return "Разбойник";
    }
}
