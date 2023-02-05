using System;

class Program
{
    static float f(float x)
    {
        if(x*x <= 4)
        {
            return 2;
        }
        else
        {
            return 1 + f(x - 4*Math.Sign(x));
        }
    }

    static void Main(string[] args)
    {
        float x = float.Parse(Console.ReadLine());
        Console.WriteLine(f(x));
    }
}