package OOP_Homeworks.Units;

public class Monk extends Unit{
 

    public Monk(String name) {
        super(79, 2, 6, name);
    }
        
    public void cast(){
        System.out.println("Bum!");
    }

    @Override
    public String getInfo() {
        return "Monk!";
    }
}
