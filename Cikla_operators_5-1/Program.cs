using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ievadiet skaitli: ");
        int n = int.Parse(Console.ReadLine());
        int faktorials = 1;

        for (int i = 1; i <= n; i++)
        {
            faktorials *= i;
            Console.WriteLine($"{i} * {faktorials} = {faktorials}");
        }
    }
}
