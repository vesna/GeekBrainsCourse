package OOP_Homeworks.Units;

import java.util.ArrayList;

public abstract class Shooter extends Unit{

    protected int arrows;

    public Shooter(float hp, int speed, int damage, int arrows, String name) {
        super(hp, speed, damage, name);
        this.arrows = arrows;
    }
    
    @Override
    public void step(ArrayList<Unit> team, ArrayList<Unit> friends) {
        if(this.arrows > 0 && this.hp > 0){
            System.out.println("Shooter can shooting!");
            for (Unit unit : team) {
                if(unit.hp > 0) {
                    System.out.printf("%s has hp %.0f\n", unit.getNAME(), unit.hp);
                    this.attack(unit, this.damage);
                    System.out.printf("before %s\n", this.toString());
                    this.arrows--;
                    break;
                }                
            }

            for (Unit unit : friends) {
                if(unit.getInfo().equals("Peasant!")){
                    this.arrows++;
                    System.out.printf("Peasant found arrow %s\n", this.toString());
                    return;
                }
            }
            System.out.printf("after %s\n", this.toString());
        }
    }

    @Override
    public String toString() {
        return this.getInfo() + " [arrows=" + arrows + "]";
    }

    
    
}
