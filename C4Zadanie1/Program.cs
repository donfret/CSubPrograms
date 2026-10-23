using System;

class Program
{
    static void Calculate()
    {
        Console.Write("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        double R = Math.Pow(a - b, 2);

        Console.WriteLine("R = " + R);
    }

    static void Main()
    {
        Calculate();
    }
}