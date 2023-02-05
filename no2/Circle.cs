public class Circle
{
    public Vector c;
    public Vector p;

    public Circle(Vector c, Vector p)
    {
        this.c = c.Copy();
        this.p = p.Copy();
    }

    public override string ToString()
    {
        return String.Format("Circle({0},{1})", this.c.ToString(), this.p.ToString());
    }
}