using System;

class Program
{
    static double Add(double a, double b)
    {
        return a + b;
    }

    static double Subtract(double a, double b)
    {
        return a - b;
    }

    static double Multiply(double a, double b)
    {
        return a * b;
    }

    static double Divide(double a, double b)
    {
        return a / b;
    }

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Калькулятор");
            Console.WriteLine("1 - Сложение");
            Console.WriteLine("2 - Вычитание");
            Console.WriteLine("3 - Умножение");
            Console.WriteLine("4 - Деление");
            Console.WriteLine("0 - Выход");
            Console.Write("Выберите операцию: ");

            string choice = Console.ReadLine();

            if (choice == "0")
            {
                Console.WriteLine("Программа завершена.");
                break;
            }

            if (choice != "1" && choice != "2" &&
                choice != "3" && choice != "4")
            {
                Console.WriteLine("Неверный выбор операции.");
                continue;
            }

            Console.Write("Введите первое число: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double result = 0;
            bool valid = true;

            switch (choice)
            {
                case "1":
                    result = Add(a, b);
                    break;

                case "2":
                    result = Subtract(a, b);
                    break;

                case "3":
                    result = Multiply(a, b);
                    break;

                case "4":
                    if (b == 0)
                    {
                        Console.WriteLine(
                            "Ошибка: деление на ноль невозможно.");
                        valid = false;
                    }
                    else
                    {
                        result = Divide(a, b);
                    }
                    break;
            }

            if (valid)
            {
                Console.WriteLine("Результат: " + result);
            }

            Console.WriteLine("Нажмите Enter, чтобы продолжить...");
            Console.ReadLine();
        }
    }
}
