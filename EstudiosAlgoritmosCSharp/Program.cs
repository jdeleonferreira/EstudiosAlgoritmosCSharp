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

            Console.WriteLine(np.EsPrimoRecursivo(11));
            Console.WriteLine(p.EsPalindromeRecursiva("dav ad"));
            Console.ReadLine();
        }
    }
}
