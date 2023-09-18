/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 3, 7, 23, 12 };
        int sum1 = SumOfElementsAtOddPositions(array1);
        Console.WriteLine($"Сумма элементов на нечётных позициях: {sum1}");

        int[] array2 = { -4, -6, 89, 6 };
        int sum2 = SumOfElementsAtOddPositions(array2);
        Console.WriteLine($"Сумма элементов на нечётных позициях: {sum2}");
    }

    static int SumOfElementsAtOddPositions(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i += 2)
        {
            sum += arr[i];
        }
        return sum;
    }
}
