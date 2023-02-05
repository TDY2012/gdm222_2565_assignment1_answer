using System;

class Program
{
    static Circle Fractal(Circle circle, int iteration)
    {
        if(iteration > 0)
        {
            Vector u = circle.p - circle.c;
            Vector v = new Vector(u.Angle() + (Math.PI/2), u.Magnitude());
            Circle newCircle = new Circle(circle.c + (v/2), circle.c + v);
            return Fractal(newCircle, iteration-1);
        }

        return circle;
    }

    static void Main(string[] args)
    {
        float cx, cy, px, py;
        cx = float.Parse(Console.ReadLine());
        cy = float.Parse(Console.ReadLine());
        px = float.Parse(Console.ReadLine());
        py = float.Parse(Console.ReadLine());

        Vector c_0 = new Vector(cx, cy);
        Vector p_0 = new Vector(px, py);
        Circle circle_0 = new Circle(c_0, p_0);

        int n = int.Parse(Console.ReadLine());
        Circle circle_n = Fractal(circle_0, n);

        Console.WriteLine(circle_n.c.x);
        Console.WriteLine(circle_n.c.y);
        Console.WriteLine(circle_n.p.x);
        Console.WriteLine(circle_n.p.y);
    }
}