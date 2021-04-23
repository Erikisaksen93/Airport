using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Text;

namespace Airport
{
    class BagIdGenerator
    {
        private static Random rnd = new Random();

        public static string Generate(int letters, int numbers)
        {
            var id = string.Empty;
            id += GenerateCharacters(letters);
            id += GenerateNumbers(numbers);

            return id;
        }

        private static string GenerateNumbers(int numbers)
        {
            var output = string.Empty;
            for (int i = 0; i < numbers; i++)
            {
                output += rnd.Next(0, 10);
            }

            return output;
        }

        private static string GenerateCharacters(int letters)
        {
            var output = string.Empty;
            for (int i = 0; i < letters; i++)
            {
                output += (char)rnd.Next(65, 91);
            }

            return output;
        }
    }
    
}
