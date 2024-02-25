/*
Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
*/

using System;

class Program
{
    static void Main()
    {
        string inputString = "HelloWorld";
        string result = ConvertToLowerCase(inputString);
        Console.WriteLine(result);
    }

    static string ConvertToLowerCase(string input)
    {
        return input.ToLower();
    }
}
