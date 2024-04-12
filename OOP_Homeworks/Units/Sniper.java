package OOP_Homeworks.Units;

import java.util.ArrayList;

public class Sniper extends Shooter {
    public Sniper(ArrayList<Unit> name, int x, int y, int ganagSize) {
        super(12, 10, 8, 10, 10, 6, name, 32, x, y, ganagSize);
    }

    public Sniper(int attack, int defense, float minDamage, float maxDamage, float hp, int speed, ArrayList<Unit> name,
            int arrows, int x, int y, int ganagSize) {
        super(attack, defense, minDamage, maxDamage, hp, speed, name, arrows, x, y, ganagSize);
    }

    public void shot() {
        System.out.println("Vzhuh!");
    }

    // @Override
    // public void step(ArrayList<Unit> team) {
    // System.out.println("Sniper shooting!");
    // }

    @Override
    public String getInfo() {
        return "Снайпер";
    }
}
