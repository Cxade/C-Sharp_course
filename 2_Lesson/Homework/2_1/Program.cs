/* Напишите программу, которая принимает на
вход трёхзначное число и на выходе показывает вторую
цифру этого числа */

Console.WriteLine("Write a three-digit number a: ");
int a = int.Parse(Console.ReadLine());
a = (a / 10) % 10;
Console.WriteLine(a);
