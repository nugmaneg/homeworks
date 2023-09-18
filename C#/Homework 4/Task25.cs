/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число A: ");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите степень B: ");
        int B = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for (int i = 0; i < B; i++)
        {
            result *= A;
        }

        Console.WriteLine($"Результат: {result}");
    }
}
