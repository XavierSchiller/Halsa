using System;

class Program
{
    public class complex {
        public float real;
        public float imaginary;
        public complex(float num1, float num2)
        {
            real = num1;
            imaginary = num2;
        }

        public complex()
        {
            real = imaginary = 0;
        }

        public static complex operator +(complex a, complex b)
        {
            complex result = new complex
            {
                real = a.real + b.real,
                imaginary = a.imaginary + b.imaginary
            };
            return result;
        }
        
        public static complex operator -(complex a, complex b)
        {
            complex result = new complex
            {
                real = a.real - b.real,
                imaginary = a.imaginary - b.imaginary
            };
            return result;
        }
        public static complex operator *(complex a, complex b)
        {
            complex result = new complex
            {
                real = (a.real * b.real) - (a.imaginary * b.imaginary),
                imaginary = (a.real*b.imaginary) + (a.imaginary*b.real)
            };
            return result;
        }
        public static complex operator !(complex a)
        {
            complex result = new complex
            { 
                real = a.real,
                imaginary = -a.imaginary
            };
            return result;
        }

        public static complex operator -(complex a)
        {
            complex result = new complex
            {
                real = -a.real,
                imaginary = -a.imaginary
            };
            return result;
        }

        public static complex operator ++(complex a)
        {
            complex result = new complex
            {
                real = a.real/((float)Math.Pow(a.real,2) + (float)Math.Pow(a.imaginary,2)),
                imaginary = -a.imaginary / ((float)Math.Pow(a.real, 2) + (float)Math.Pow(a.imaginary, 2))
            };
            return result;
        }

        public static void WriteLine(complex a)
        {
            if(a.imaginary >0)
            Console.Write(a.real + "+" + a.imaginary + "i");

            if (a.imaginary < 0)
                Console.Write(a.real + "-" + Math.Abs(a.imaginary) + "i");
        }
    };

    public static void Main()
    {
        Console.WriteLine("Enter the two imaginary numbers seperated by ',' and in format of (a+ib)");
        string input = Console.ReadLine();
        string[] Im = input.Split(',');
        string[] IM1 = Im[0].Split("+i");
        string[] IM2 = Im[1].Split("+i");
        complex[] numbers = new complex[2] 
        {
            new complex(),
            new complex()
        };
        numbers[0].real = int.Parse(IM1[0]);
        numbers[0].imaginary = int.Parse(IM1[1]);
        numbers[1].real = int.Parse(IM2[0]);
        numbers[1].imaginary = int.Parse(IM2[1]);
        Console.WriteLine("Provide the operation to perform:");
        ConsoleKeyInfo Operation = Console.ReadKey();
        complex result = new complex();
        switch (Operation.KeyChar)
        {
            case '+': result = numbers[0] + numbers[1];
                break;
            case '-':result = numbers[0] - numbers[1];
                break;
            case '*':result = numbers[0] * numbers[1];
                break;
            case '_':result = ++numbers[0];
                break;
            case '!':result = !numbers[0];
                break;
            default:Console.WriteLine("Not a valid Operator.");
                break;
        }
        Console.WriteLine(Environment.NewLine);
        complex.WriteLine(result);
        Console.ReadKey();

    }
}
