// Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number b: ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number c: ");
int c = int.Parse(Console.ReadLine());
int max = 0;
if (a == b && b == c)
    Console.WriteLine($"{a} = {b} = {c}");
if (a > b)
    max = a;
else
    max = b;
if (max < c)
    max = c;
Console.WriteLine(max);