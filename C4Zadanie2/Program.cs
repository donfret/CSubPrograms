using System;
/*проверка коммита*/
class Program
{
    static void Calculate(double a, double b)
    {
        double R = Math.Pow(a - b, 2);
        Console.WriteLine("R = " + R);
    }

    static void Main()
    {
        Console.Write("Введите a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Calculate(a, b);
    }
}