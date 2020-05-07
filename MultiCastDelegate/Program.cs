using System;

namespace MultiCastDelegate
{   public delegate void CalculationDelegate(int x, int y);
    class Program
    {
        static void Main(string[] args)
        {
            CalculationDelegate calculationDelegate = addition;
            calculationDelegate += multiplication;

            calculationDelegate(5,6);

             void addition(int a, int b)
            {
                int add = a + b;
                Console.WriteLine($"The addition is {add}");
            }

             void multiplication(int a, int b)
            {
                int mult = a * b;
                Console.WriteLine($"The multiplication is {mult}");
            }
        }
    }
}
