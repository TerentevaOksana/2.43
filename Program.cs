using System;
class program
{
    static void Main(string[] args)
    {
        int a, b, x;
        Console.WriteLine("Введите значение a");
        a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите значение b");
        b = int.Parse(Console.ReadLine());
        x = ((a % b) * (b % a) + 1);
        Console.WriteLine(x);
        Console.ReadLine();

    }
}
