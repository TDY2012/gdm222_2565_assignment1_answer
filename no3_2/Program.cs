using System;

class Program
{
    static float f(float x)
    {
        if(x > -1 && x <= 0)
        {
            return (float)Math.Sqrt(1-x*x);
        }
        else if(x > 0 && x <= 1)
        {
            return -(float)Math.Sqrt(1-x*x);
        }
        else if(x <= -1)
        {
            return f(x+2);
        }
        else
        {
            return f(x-2);
        }
    }

    static void Main(string[] args)
    {
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine(f(x));
    }
}