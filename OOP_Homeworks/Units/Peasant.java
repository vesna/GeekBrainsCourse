package OOP_Homeworks.Units;

import java.util.ArrayList;

public class Peasant extends Unit {
    private int supply; // доставка

    public int getSupply() {
        return supply;
    }

    public void setSupply(int supply) {
        this.supply = supply;
    }

    public Peasant(ArrayList<Unit> name, int x, int y, int ganagSize) {
        super(1, 1, 1, 1, 1, 3, name, x, y, ganagSize);
        this.supply = 1;
    }

    public Peasant(int attack, int defense, float minDamage, float maxDamage, float hp, int speed, ArrayList<Unit> name,
            int supply, int x, int y, int ganagSize) {
        super(attack, defense, minDamage, maxDamage, hp, speed, name, x, y, ganagSize);
        this.supply = supply;
    }

    @Override
    public String getInfo() {
        return "Крестьянин";
    }

    @Override
    public String toString() {
        return this.getInfo() + " [supply=" + getSupply() + ", attack=" + getAttack() + ", defense=" + getDefense()
                + ", minDamage=" + getMinDamage() + "maxDamage=" + getMaxDamage() + ", hp=" + getHp()
                + ", speed=" + getSpeed() + ", NAME=" + getClass().getName() + ", x=" + getCoordinates().getX() + ", y="
                + getCoordinates().getY() + ", ganagSize=" + getGanagSize() + "]";
    }

    @Override
    public void step(ArrayList<Unit> team) {
        this.supply = 1;
    }

}
