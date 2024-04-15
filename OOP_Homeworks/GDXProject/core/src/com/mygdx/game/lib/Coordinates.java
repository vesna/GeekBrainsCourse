package com.mygdx.game.lib;

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
        return (float) Math.sqrt((other.x - x) * (other.x - x) + (other.y - y) * (other.y - y));
    }

    public boolean isEquals(Coordinates other) {
        if (other.getX() == x && other.getY() == y) {
            return true;
        }
        return false;
    }

    public void direction(Coordinates other) {
        if (Math.abs(x - other.x) > Math.abs(y - other.y)) { // двигаемся по x
            if (x < other.x)
                x += 1;
            else
                x -= 1;
        } else { // двигаемся по y
            if (y < other.y)
                y += 1;
            else
                y -= 1;
        }
    }

}
