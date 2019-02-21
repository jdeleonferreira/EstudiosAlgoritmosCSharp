using System;
using System.Collections.Generic;
using System.Text;

namespace EstudiosAlgoritmosCSharp
{
    public class Factorial
    {
        public int GetFactorial(int n = 1)
        {
            int result = n;

            if (n >= 1)
            {
                for (int i = 1; i < n; i++)
                {
                    result = result * i;
                }
            }

            return result;
        }
        public int GetFactorialRecursivo(int n = 1)
        {
            if (n == 0) return 1;
            else
                return n * GetFactorial(n - 1);
        }
    }
}
