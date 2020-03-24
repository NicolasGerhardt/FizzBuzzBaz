using System;

namespace FizzBuzzBazz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 105; i++)
            {
                Console.WriteLine($"{i}. {FizzBuzzBaz.Output(i)}");
            }
        }
    }
}
