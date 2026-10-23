using System;

class Program
{
    static double Calculate(double a, double b)
    {
        return Math.Pow(a - b, 2);
    }

    static void Main()
    {
        Console.Write("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double R = Calculate(a, b);

        Console.WriteLine("R = " + R);
    }
}