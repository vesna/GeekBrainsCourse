package OOP_Homeworks.Units;

import java.util.ArrayList;

public class XBowMan extends Shooter{
    public XBowMan(String name){
        super(79, 2, 6, 9, name);
    }

    // @Override
    // public void step(ArrayList<Unit> team) {
    //     System.out.println("XBowMan shooting!");
    // }

    @Override
    public String getInfo() {
        return "XBowMan!";
    }
}
