package Geometry.Vertices;

public class Vertex3D extends Geometry.Vertices.Vertex {

    private double x;
    private double y;
    private double z;

    public Vertex3D(double x, double y, double z) {
        super(x, y);
        this.x = super.getX();
        this.y = super.getY();
        this.setZ(z);
    }

    public double getZ() {
        return this.z;
    }

    public void setZ(double z) {
        this.z = z;
    }
}

