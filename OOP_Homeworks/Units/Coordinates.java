package OOP_Homeworks.Units;

public class Coordinates {
    private int x;
    private int y;

    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    public Coordinates(int x, int y) {
        this.x = x;
        this.y = y;
    }

    public float distance(Coordinates other) {
        return (float)Math.sqrt((other.x - x) * (other.x - x) + (other.y - y) * (other.y - y));
    }

    public boolean isEquals(Coordinates position) {
        if(position.getX() == x && position.getY() == y){
            return true;
        }
        return false;
    }

}
