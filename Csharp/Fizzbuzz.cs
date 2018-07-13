using System;

class Collatz
{
    static void Main()
    {
        Console.WriteLine("Please input the number of digits you want to find:");
        string No = Console.ReadLine();
        int Limit = int.Parse(No);
        for (int i = 1; i < Limit; i++)
        {
            string ToPrint = String.Empty;
            if (i % 3 == 0)
                ToPrint = ToPrint + "Fizz";
            if (i % 5 == 0)
                ToPrint = ToPrint + "Buzz";
            //Prints.
            if (ToPrint != String.Empty)
            {
                Console.WriteLine(ToPrint);
            }
            else
            {
                Console.WriteLine(i);
            }
        }
        Console.ReadKey();
    }
}
