using System;

class Program
{
    static void Main()
    {
        string password;

        do
        {
            Console.Write("Ange lösenord: ");
            password = Console.ReadLine();
        } while (password != "hemligt");

        Console.WriteLine("Du angav rätt lösenord!");
    }
}

