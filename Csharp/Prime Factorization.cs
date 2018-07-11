using System;
using System.Collections.Generic;

namespace Getting_used_to_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prime factors for:");
            string instring = Console.ReadLine();
            int input = int.Parse(instring);
            int[] PF = Factors(input);
            List<int> Primefactors = new List<int>();
            for (int i = 0; i < PF.Length; i++)
            {
                if (IsPrime(PF[i]) == true)
                    Primefactors.Add(PF[i]);
            }
            int[] PFA = Primefactors.ToArray();
            for (int i= 0; i < PFA.Length; i++) { 
                Console.WriteLine(PFA[i]);
            }
            Console.ReadLine();
        }

        static int[] Factors(int number)
        {
            List<int> PrimeFactorsA = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) //Changing loop to include every divisor. 
                    PrimeFactorsA.Add(i);
            }
            int[] rettarr = PrimeFactorsA.ToArray();
            return rettarr;
        }

        static bool IsPrime(int number)
        {
            bool numisprime = true;
            if (number == 2 || number == 1)
                return true;
            if (number % 2 == 0) return false;
            for (int i = 3; i < Math.Sqrt(number); i+=2)
            {
                if (number % i == 0)
                {
                    numisprime = false;
                }
            }
            return numisprime;
        }
    }
}
