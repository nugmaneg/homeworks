/*
Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
*/

using System;

class Program
{
    static void Main()
    {
        char[,] charArray = {
            { 'a', 'b', 'c' },
            { 'd', 'e', 'f' },
            { 'g', 'h', 'i' }
        };

        string result = ConvertCharArrayToString(charArray);
        Console.WriteLine(result);
    }

    static string ConvertCharArrayToString(char[,] charArray)
    {
        int rows = charArray.GetLength(0);
        int cols = charArray.GetLength(1);

        char[] resultArray = new char[rows * cols];
        int index = 0;

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                resultArray[index++] = charArray[i, j];
            }
        }

        return new string(resultArray);
    }
}
