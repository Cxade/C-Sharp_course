//Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Write number a: ");
int a = int.Parse(Console.ReadLine());
if (a / 100 == 0)
Console.WriteLine("Третьей цифры нет");
else
{
while (a / 1000 > 0)
a = a / 10;
Console.WriteLine(a % 10);
}
