package OOP_Homeworks.Units;

public class Peasant extends Unit {
    public Peasant(String name) {
        super(79, 2, 6, name);
    }
        
    @Override
    public String getInfo() {
        return "Peasant!";
    }
    
}
