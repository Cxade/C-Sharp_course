/*Задача 4: Напишите программу, которая принимает на
вход цифру, обозначающую день недели, и проверяет,
является ли этот день выходным.*/

Console.WriteLine("Write number a: ");
int a = int.Parse(Console.ReadLine());
if (a == 6 || a == 7)
    Console.WriteLine("Выходной");
else if (0 < a && a < 6)
    Console.WriteLine("Будний");
else
    Console.WriteLine("Введите число от 1 до 7");
