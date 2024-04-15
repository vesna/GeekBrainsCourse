package com.mygdx.game.lib;

import java.util.ArrayList;

public abstract class Shooter extends Unit {

    protected int arrows;

    public int getArrows() {
        return arrows;
    }

    public Shooter(int attack, int defense, float minDamage, float maxDamage, float hp, int speed, ArrayList<Unit> name,
            int arrows, int x, int y, int ganagSize) {
        super(attack, defense, minDamage, maxDamage, hp, speed, name, x, y, ganagSize);
        this.arrows = arrows;
    }

    @Override
    public String toString() {
        return this.getInfo() + " [arrows=" + arrows + "attack=" + getAttack() + ", defense=" + getDefense()
                + ", minDamage=" + getMinDamage() + "maxDamage=" + getMaxDamage() + ", hp=" + getHp() + ", speed="
                + getSpeed() + ", NAME=" + getClass().getName() + ", x=" + getCoordinates().getX() + ", y="
                + getCoordinates().getY() + ", ganagSize=" + getGanagSize() + "]";
    }

    @Override
    public void step(ArrayList<Unit> rivalTeam) {
        if (this.arrows == 0 || this.getHp() == 0)
            return;

        Unit unitResult = null;
        for (Unit unit : rivalTeam) {
            if (unit.getHp() > 0) {
                if (unitResult == null) {
                    unitResult = unit;
                } else if (this.getCoordinates().distance(unit.getCoordinates()) < this.getCoordinates()
                        .distance(unitResult.getCoordinates())) {
                    unitResult = unit;
                }
            }
        }

        if(unitResult == null){
            return;
        }
        if (this.getAttack() == unitResult.getDefense()) {
            this.attack(unitResult, takeMiddleDamage(getMinDamage(), getMaxDamage()));
        } else if (this.getAttack() > unitResult.getDefense()) {
            this.attack(unitResult, getMaxDamage());
        } else {
            this.attack(unitResult, getMinDamage());
        }
        //System.out.println(getInfo());
        for (Unit unit : getName()) {
            if (unit.getInfo().equals("Крестьянин")) {
                Peasant peasant = (Peasant) unit;
                int peasantSupply = peasant.getSupply();
                if (peasantSupply > 0) {
                    peasant.setSupply(peasantSupply - 1);
                   // System.out.printf("Peasant found arrow %s\n", this.toString());
                    return;
                }
            }
        }
        arrows--;
       // System.out.printf("after %s\n", this.toString());
    }
}
