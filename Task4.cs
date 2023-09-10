/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int num3 = int.Parse(Console.ReadLine());

        int max = Math.Max(Math.Max(num1, num2), num3);

        Console.WriteLine($"Максимальное число: {max}");
    }
}
