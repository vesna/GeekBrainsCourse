package OOP_Homeworks.Units;

import java.util.ArrayList;

public class Robber extends Unit {

    public Robber(ArrayList<Unit> name, int x, int y, int ganagSize) {
        super(8, 3, 2, 4, 10, 6, name, x, y, ganagSize);
    }

    public Robber(int attack, int defense, float minDamage, float maxDamage, float hp, int speed, ArrayList<Unit> name,
            int x,
            int y, int ganagSize) {
        super(attack, defense, minDamage, maxDamage, hp, speed, name, x, y, ganagSize);
    }

    @Override
    public String getInfo() {
        return "Разбойник";
    }
}
