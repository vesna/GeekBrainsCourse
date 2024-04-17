package OOP_Homeworks.Units;

import java.util.ArrayList;

public abstract class MelleUnit extends Unit {
    private int stamina;

    public int getStamina() {
        return stamina;
    }

    public MelleUnit(int attack, int defense, float minDamage, float maxDamage, float hp, int speed,
            ArrayList<Unit> name, int x, int y, int ganagSize, int stamina) {
        super(attack, defense, minDamage, maxDamage, hp, speed, name, x, y, ganagSize);
        this.stamina = stamina;
    }

    @Override
    public String toString() {
        return this.getInfo() + " [stamina=" + stamina + "attack=" + getAttack() + ", defense=" + getDefense()
                + ", minDamage=" + getMinDamage() + "maxDamage=" + getMaxDamage() + ", hp=" + getHp() + ", speed="
                + getSpeed() + ", NAME=" + getClass().getName() + ", x=" + getCoordinates().getX() + ", y="
                + getCoordinates().getY() + ", ganagSize=" + getGanagSize() + "]";
    }

    @Override
    public void step(ArrayList<Unit> rivalTeam) {
        if (/*this.stamina == 0 || */this.getHp() == 0)
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
        if (unitResult == null) {
            return;
        }
        if (this.getCoordinates().distance(unitResult.getCoordinates()) >= 2) {//если расстаяние польше двух клеток
            this.getCoordinates().direction(unitResult.getCoordinates());
        }
      //  System.out.println(getInfo());
        if (this.getCoordinates().distance(unitResult.getCoordinates()) <= 2) { // если расстаяне меньше двух клеток
            if (this.getAttack() == unitResult.getDefense()) {
                this.attack(unitResult, takeMiddleDamage(getMinDamage(), getMaxDamage()));
            } else if (this.getAttack() > unitResult.getDefense()) {
                this.attack(unitResult, getMaxDamage());
            } else {
                this.attack(unitResult, getMinDamage());
            }
        }

        // for (Unit unit : getName()) {
        // if (unit.getInfo().equals("Крестьянин")) {
        // Peasant peasant = (Peasant) unit;
        // int peasantSupply = peasant.getSupply();
        // if (peasantSupply > 0) {
        // peasant.setSupply(peasantSupply - 1);
        // System.out.printf("Peasant found arrow %s\n", this.toString());
        // return;
        // }
        // }
        // }
        //stamina--;
        // System.out.printf("after %s\n", this.toString());
    }
}
