package OOP_Homeworks.Units;

import java.util.ArrayList;

public class Sniper extends Shooter{

    public Sniper(String name){super(79, 1, 6, 9, name);}

    public void shot(){
        System.out.println("Vzhuh!");
    }

    // @Override
    // public void step(ArrayList<Unit> team) {
    //     System.out.println("Sniper shooting!");
    // }

    @Override
    public String getInfo() {
        return "Sniper!";
    }
}
