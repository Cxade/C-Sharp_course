void Method(int a)
{
    if (a % 7 == 0 && a % 23 == 0)
        Console.WriteLine("Кратно");
    else
    {
        Console.WriteLine("Не кратно");
    }
}
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Method(N);