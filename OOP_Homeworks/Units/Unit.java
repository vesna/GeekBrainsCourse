package OOP_Homeworks.Units;

import java.util.ArrayList;
import java.util.Random;

public abstract class Unit implements UnitInterface{
    protected float hp;
    protected int speed;
    protected int damage;
    protected final String NAME;
    

    public Unit(float hp, int speed, int damage, String name) {
        this.hp = hp;
        this.speed = speed;
        this.damage = damage;

        NAME = name;
    }

    @Override
    public void step(ArrayList<Unit> team, ArrayList<Unit> friends) {
        System.out.println("Step!");
        
    }

    public String getNAME() {
        return NAME;
    }

    public int getSpeed() {
        return speed;
    }

    public void takeDamage(int damage) {
        if(this.hp - damage > 0) this.hp -= damage;
        else this.hp = 0;
    }
    
    public void attack(Unit target, int damage){
        Random rnd = new Random();
        int causedDamage = rnd.nextInt(1, damage);
        System.out.printf("%s attack %s \t", this.getClass().getSimpleName(), target.getClass().getSimpleName());
        System.out.printf("Power of knock = %d\n", causedDamage);
        System.out.printf("%s hp = %.0f\n", target.getClass().getSimpleName(), target.hp);
        target.takeDamage(causedDamage);
    }
}
