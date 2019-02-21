using System;
using System.Collections.Generic;
using System.Text;

namespace EstudiosAlgoritmosCSharp
{
    public class NumerosPrimos
    {
        /*
         * 
         * Comprueba si un número entero dado es Primo.
         * 
        */
        public bool EsPrimoDivision(int n)
        {
            int i = 2;
            bool result = true;
            if (n > 0)
            {
                for (i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        result = false;
                    }

                }
            }
            else
            {
                result = false;
            }

            Console.WriteLine("El total de operaciones fue: " + (i - 2));

            return result;
        }


        public bool EsPrimoRecursivo(int n, int? d = 2)
        {
            bool result = true;

            if (n > 0)
            {
                if (n % d != 0 && d <= Math.Sqrt(n))
                {
                    EsPrimoRecursivo(n, d + 1);
                }
                else
                {
                    result = false;
                    Console.WriteLine("El total de operaciones fue: " + (d - 2));
                }

            }
            else
            {
                result = false;
            }

            
            return result;
        }

    }
}
