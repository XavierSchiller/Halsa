using System;

class Collatz
{
    public static int Coll(int number)
    {
        int steps = new int();
        steps = 1;
        while (number != 1)
        {
            if (number % 2 == 0)
            {
                number = number / 2;
            }

            else
            {
                number = 3 * number + 1;
            }
            steps++;
        }
        return steps;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number you want to find the steps for:");
        Console.WriteLine(Coll(int.Parse(Console.ReadLine())));
        Console.ReadKey();
    }

}
