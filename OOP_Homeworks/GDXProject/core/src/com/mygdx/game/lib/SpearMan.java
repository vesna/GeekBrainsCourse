package com.mygdx.game.lib;

import java.util.ArrayList;

public class SpearMan extends MelleUnit {
    public SpearMan(ArrayList<Unit> name, int x, int y, int ganagSize) {
        super(4, 5, 1, 3, 10, 4, name, x, y, ganagSize, 1);
    }

    public SpearMan(int attack, int defense, float minDamage, float maxDamage, float hp, int speed, ArrayList<Unit> name,
            int x, int y, int ganagSize, int stamina) {
        super(attack, defense, minDamage, maxDamage, hp, speed, name, x, y, ganagSize, stamina);
    }

    @Override
    public String getInfo() {
        return "Копейщик";
    }
}
