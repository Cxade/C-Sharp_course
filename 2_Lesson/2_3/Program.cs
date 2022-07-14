Console.WriteLine("Write a number a: ");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Write a number b: ");
int b = int.Parse(Console.ReadLine());

if (a % b == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine(a % b);
}

/*
РЕШЕНИЕ НА СЕМИНАРЕ
void Method1 (int a, int b)
{
    if (a % b == 0)
    Console.WriteLine ("Кратно");
    else 
    {
        Console.WriteLine ($"не кратно, остаток {a % b}");
    }
}
Method1 (35, 4);
*/