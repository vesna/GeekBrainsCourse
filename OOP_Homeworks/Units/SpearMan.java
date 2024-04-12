package OOP_Homeworks.Units;

import java.util.ArrayList;

public class SpearMan extends Unit {
    public SpearMan(ArrayList<Unit> name, int x, int y, int ganagSize) {
        super(4, 5, 1, 3, 10, 4, name, x, y, ganagSize);
    }

    public SpearMan(int attack, int defense, float minDamage, float maxDamage, float hp, int speed, ArrayList<Unit> name,
            int x, int y, int ganagSize) {
        super(attack, defense, minDamage, maxDamage, hp, speed, name, x, y, ganagSize);
    }

    @Override
    public String getInfo() {
        return "Копейщик";
    }
}
