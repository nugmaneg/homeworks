/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 };

        double max = FindMax(array);
        double min = FindMin(array);

        double difference = max - min;
        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    }

    static double FindMax(double[] arr)
    {
        double max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }

    static double FindMin(double[] arr)
    {
        double min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
                min = arr[i];
        }
        return min;
    }
}
