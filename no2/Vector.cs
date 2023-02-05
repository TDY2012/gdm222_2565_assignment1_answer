public class Vector
{
    public float x;
    public float y;

    public Vector(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public Vector(double angle, double magnitude)
    {
        this.x = (float)(Math.Cos(angle)*magnitude);
        this.y = (float)(Math.Sin(angle)*magnitude);
    }

    public static Vector operator +(Vector u)
    {
        return u;
    }

    public static Vector operator -(Vector u)
    {
        return new Vector(-u.x, -u.y);
    }

    public static Vector operator +(Vector u, Vector v)
    {
        return new Vector(u.x + v.x, u.y + v.y);
    }

    public static Vector operator -(Vector u, Vector v)
    {
        return u + (-v);
    }

    public static float operator *(Vector u, Vector v)
    {
        return u.x*v.x + u.y*v.y;
    }

    public static Vector operator /(Vector u, float a)
    {
        return new Vector(u.x/a, u.y/a);
    }

    public double Magnitude()
    {
        return Math.Sqrt(this.x*this.x + this.y*this.y);
    }

    public double Angle()
    {
        return Math.Atan2(this.y, this.x);
    }

    public Vector Copy()
    {
        return new Vector(this.x, this.y);
    }

    public override string ToString()
    {
        return String.Format("Vector({0},{1})", this.x, this.y);
    }
}