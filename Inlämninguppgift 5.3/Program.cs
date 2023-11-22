using System;
class program
{
    static void Main()
    {
        Console.WriteLine("skriv in 5 städer");

        string[] städer = new string[5];

        for (int i = 0; i < städer.Length; i++)
        {
            Console.WriteLine($"Skriv in stad {i + 1}");
            städer[i] = Console.ReadLine();
        }

        Console.WriteLine("Här är de städer du skrev in");

        foreach (string stad in städer)
        {
            Console.WriteLine(stad);
        }
    }
}