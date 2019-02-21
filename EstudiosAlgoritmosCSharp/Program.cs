using System;

namespace EstudiosAlgoritmosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            NumerosPrimos np = new NumerosPrimos();
            Palindrome p = new Palindrome();
            Factorial f = new Factorial();


            Console.WriteLine(np.EsPrimoRecursivo(11));
            Console.WriteLine(p.EsPalindromeRecursiva("dav ad"));
            Console.WriteLine(f.GetFactorial(5));
            Console.WriteLine(f.GetFactorialRecursivo(5));
            Console.ReadLine();
        }
    }
}
