using System;

namespace _153_RecursiveMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 5;

            Console.WriteLine("Non recursive way");
            Console.WriteLine(FactorialNonRecursive(number));

            Console.WriteLine("Recursive way");
            Console.WriteLine(Factorial(number));
        }

        //Non-Recursive way
        public static int FactorialNonRecursive(int n)
        {
            if (n == 0)
                return 1;
            int value = 1;
            for (int i = n; i > 0; i--)
            {
                value *= i;
                Console.WriteLine(i);
            }
            return value;
        }

        //Recursive Way
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
    }
}
