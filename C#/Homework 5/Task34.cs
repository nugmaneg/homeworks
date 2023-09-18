/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 345, 897, 568, 234 };

        int countEven = CountEvenNumbers(array);
        Console.WriteLine($"Количество чётных чисел в массиве: {countEven}");
    }

    static int CountEvenNumbers(int[] arr)
    {
        int count = 0;
        foreach (var num in arr)
        {
            if (num % 2 == 0)
                count++;
        }
        return count;
    }
}
