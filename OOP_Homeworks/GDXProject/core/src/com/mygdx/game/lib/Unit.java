package com.mygdx.game.lib;

import java.util.ArrayList;

public abstract class Unit implements UnitInterface {

    private int attack; // атака
    private int defense; // защита
    private float minDamage; // урон min
    private float maxDamage; // урон max
    private float hp; // жизнь
    private int speed; // скорость
    private Coordinates coordinates;
    private int ganagSize;
    private final ArrayList<Unit> name;

    public ArrayList<Unit> getName() {
        return name;
    }

    public Coordinates getCoordinates() {
        return coordinates;
    }

    public int getGanagSize() {
        return ganagSize;
    }

    public int getAttack() {
        return attack;
    }

    public int getDefense() {
        return defense;
    }

    public float getMinDamage() {
        return minDamage;
    }

    public float getMaxDamage() {
        return maxDamage;
    }

    public float getHp() {
        return hp;
    }

    public int getSpeed() {
        return speed;
    }

    public Unit(int attack, int defense, float minDamage, float maxDamage, float hp, int speed, ArrayList<Unit> name, int x,
            int y, int ganagSize) {
        this.attack = attack;
        this.defense = defense;
        this.minDamage = minDamage;
        this.maxDamage = maxDamage;
        this.hp = hp;
        this.speed = speed;
        this.name = name;
        coordinates = new Coordinates(x, y);
        this.ganagSize = ganagSize;
    }

    @Override
    public void step(ArrayList<Unit> team) {
      //  System.out.println("Step!");
    }

    public float takeMiddleDamage(float minDamage, float maxDamage) {
        return (maxDamage + minDamage) / 2;
    }

    public void attack(Unit target, float causedDamage) {
        // System.out.printf("\n%s attack %s \t", this.getInfo(), target.getInfo());
        // System.out.printf("Power of knock = %f\n", causedDamage);
        // System.out.printf("%s before hp = %.0f\n", target.getInfo(), target.hp);
        if (target.hp - causedDamage > 0)
            target.hp -= causedDamage;
        else
            target.hp = 0;
        //System.out.printf("%s after hp = %.0f\n", target.getInfo(), target.hp);
    }

    @Override
    public String toString() {
        return this.getInfo() + " [attack=" + attack + ", defense=" + defense + ", minDamage=" + minDamage
                + "maxDamage=" + maxDamage + ", hp=" + hp + ", speed=" + speed + ", NAME=" + getClass().getName() + ", x="
                + coordinates.getX() + ", y=" + coordinates.getY() + ", ganagSize=" + ganagSize + "]";
    }
}
