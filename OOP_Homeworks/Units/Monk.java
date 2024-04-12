package OOP_Homeworks.Units;

import java.util.ArrayList;

public class Monk extends MysticalMan {
    public Monk(ArrayList<Unit> name, int x, int y, int ganagSize) {
        super(12, 7, -4, -4, 30, 5, name, 1, x, y, ganagSize);
    }

    public Monk(int attack, int defense, float minDamage, float maxDamage, float hp, int speed, ArrayList<Unit> name,
            int magic, int x, int y, int ganagSize) {
        super(attack, defense, minDamage, maxDamage, hp, speed, name, magic, x, y, ganagSize);
    }

    public void cast() {
        System.out.println("Bum!");
    }

    @Override
    public String getInfo() {
        return "Монах";
    }

}
