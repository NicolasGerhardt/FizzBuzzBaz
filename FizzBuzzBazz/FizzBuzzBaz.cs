using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzBazz
{
    public static class FizzBuzzBaz
    {
        public static string Output(int num)
        {
            // Start empty string
            string output = string.Empty;
            output += ModuloHelper(num, 3, "Fizz");
            output += ModuloHelper(num, 5, "Buzz");
            output += ModuloHelper(num, 7, "Baz");

            if (output == string.Empty)
            {
                return num.ToString();
            }

            return output;
        }

        private static string ModuloHelper(int num, int mod, string output)
        {
            string modS = mod.ToString();
            string numS = num.ToString();

            if (num % mod == 0 || numS.Contains(modS) )
            {
                return output;
            }

            return "";
        }

        
    }
}
