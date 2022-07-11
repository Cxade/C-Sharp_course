// Задача 8 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Write a number N: ");
int N = int.Parse(Console.ReadLine());
int count = 2;
while (count<=N)
{
  Console.WriteLine(count);
  count +=2;
}