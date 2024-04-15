package com.mygdx.game.lib;

import java.util.ArrayList;

public abstract class MysticalUnit extends Unit {
    private int magic; // магия

    public int getMagic() {
        return magic;
    }

    public MysticalUnit(int attack, int defense, float minDamage, float maxDamage, float hp, int speed, ArrayList<Unit> name,
            int magic, int x, int y, int ganagSize) {
        super(attack, defense, minDamage, maxDamage, hp, speed, name, x, y, ganagSize);
        this.magic = magic;
    }

    @Override
    public String toString() {
        return this.getInfo() + " [magic=" + magic + ", attack=" + getAttack() + ", defense=" + getDefense() +
                ", minDamage=" + getMinDamage() + "maxDamage=" + getMaxDamage() + ", hp=" + getHp() + ", speed="
                + getSpeed() + ", NAME=" + getClass().getName() + ", x=" + getCoordinates().getX() + ", y="
                + getCoordinates().getY() + ", ganagSize=" + getGanagSize() + "]";
    }

}
