using System;
using System.Collections.Generic;
using System.Text;

namespace EstudiosAlgoritmosCSharp
{
    class ParImpar
    {
        public bool EsPar(int number)
        {
            bool result = false;

            switch (number % 2)
            {
                case 0:
                    result = true;
                    Console.WriteLine("{0} is an even number", number);
                    break;
                case 1:
                    result = false;
                    Console.WriteLine("{0} is an odd number", number);
                    break;
            }

            return result;

        }

        public string EsEvenOrOdd(int number)
        {
            string result = (number % 2 == 0) ? "Even" : "Odd";

            return result;

        }
    }
}
