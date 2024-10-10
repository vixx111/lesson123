using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение x: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите значение y: ");
        double y = Convert.ToDouble(Console.ReadLine());
        double l = 1.51 * Math.Cos(Math.Pow(x, 2)) + 2 * Math.Pow(y, 3);
        Console.WriteLine($"Значение L равно {l}.");
    }
}