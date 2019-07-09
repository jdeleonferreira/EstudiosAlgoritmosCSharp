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

            #region Binary Tree
            BinaryTree tree = new BinaryTree();
            Node bt = null;

            bt = tree.InsertNode(bt, 1);

            Console.WriteLine("B(v):{0}", bt.value);
            Console.WriteLine("B(l):{0}", bt.l);
            Console.WriteLine("B(r):{0}", bt.r);
            #endregion


            Console.ReadLine();

        }
    }
}
