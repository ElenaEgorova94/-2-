﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine());

switch (N)
{
    case 1:
        Console.WriteLine("Это не выходной день");
        break;
    case 2:
        Console.WriteLine("Это не выходной день");
        break;
    case 3:
        Console.WriteLine("Это не выходной день");
        break;
    case 4:
        Console.WriteLine("Это не выходной день");
        break;
    case 5:
        Console.WriteLine("Это не выходной день");
        break;
    case 6:
        Console.WriteLine("Ура! Это выходной день!");
        break;
    case 7:
        Console.WriteLine("Ура! Это выходной день!");
        break;
        default:
        Console.WriteLine("Неккоректно введено число, введите число от 1 до 7");
        break;
}
