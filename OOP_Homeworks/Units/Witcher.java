package OOP_Homeworks.Units;

import java.util.ArrayList;

public class Witcher extends MysticalUnit {
    public Witcher(ArrayList<Unit> name, int x, int y, int ganagSize) {
        super(17, 12, -5, -5, 30, 9, name, 1, x, y, ganagSize);
    }

    public Witcher(int attack, int defense, float minDamage, float maxDamage, float hp, int speed, ArrayList<Unit> name,
            int magic, int x, int y, int ganagSize) {
        super(attack, defense, minDamage, maxDamage, hp, speed, name, magic, x, y, ganagSize);
    }

    @Override
    public String getInfo() {
        return "Ведьмак";
    }

}
