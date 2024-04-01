package Java_Homeworks.Seminar06;

public class Laptop {
    //private int id;
    private String name;
    private int ram;
    private int storageCap;
    private String os;
    private String color;
    private double diagonal;
    private int price;
    
    public Laptop(String name, int ram, int storageCap, String os, String color, double diagonal, int price) {
        this.name = name;
        this.ram = ram;
        this.storageCap = storageCap;
        this.os = os;
        this.color = color;
        this.diagonal = diagonal;
        this.price = price;
    }

    public String getName() {
        return name;
    }

    public int getRam() {
        return ram;
    }

    public int getStorageCap() {
        return storageCap;
    }

    public String getOs() {
        return os;
    }

    public String getColor() {
        return color;
    }

    public double getDiagonal() {
        return diagonal;
    }

    public int getPrice() {
        return price;
    }

    @Override
    public int hashCode() {
        final int prime = 31;
        int result = 1;
        result = prime * result + ((name == null) ? 0 : name.hashCode());
        result = prime * result + ram;
        result = prime * result + storageCap;
        result = prime * result + ((os == null) ? 0 : os.hashCode());
        result = prime * result + ((color == null) ? 0 : color.hashCode());
        long temp;
        temp = Double.doubleToLongBits(diagonal);
        result = prime * result + (int) (temp ^ (temp >>> 32));
        result = prime * result + price;
        return result;
    }

    @Override
    public boolean equals(Object obj) {
        if (this == obj)
            return true;
        if (obj == null)
            return false;
        if (getClass() != obj.getClass())
            return false;
        Laptop other = (Laptop) obj;
        if (name == null) {
            if (other.name != null)
                return false;
        } else if (!name.equals(other.name))
            return false;
        if (ram != other.ram)
            return false;
        if (storageCap != other.storageCap)
            return false;
        if (os == null) {
            if (other.os != null)
                return false;
        } else if (!os.equals(other.os))
            return false;
        if (color == null) {
            if (other.color != null)
                return false;
        } else if (!color.equals(other.color))
            return false;
        if (Double.doubleToLongBits(diagonal) != Double.doubleToLongBits(other.diagonal))
            return false;
        if (price != other.price)
            return false;
        return true;
    }

    @Override
    public String toString() {
        return "Laptop [name=" + name + ", ram=" + ram + ", storageCap=" + storageCap + ", os=" + os + ", color="
                + color + ", diagonal=" + diagonal + ", price=" + price + "]";
    }

    
    
}
