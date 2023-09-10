/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

using System;

class Program {
    static void Main(string[] args) {
        int a = 4;
        if (a % 2 == 0) {
            Console.WriteLine("да");
        } else {
            Console.WriteLine("нет");
        }
    }
}
