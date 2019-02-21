using System;
using System.Collections.Generic;
using System.Text;

namespace EstudiosAlgoritmosCSharp
{
    public class Palindrome
    {
        public bool EsPalindrome(string word)
        {
            bool result = true;

            word = word.Replace(" ", "");

            char[] aw = word.ToCharArray();

            for(int i = 0, j = aw.Length-1; i <= j; i++, j--)
            {
                if (aw[i] != aw[j]) result = false;
            }


            return result;
        }

        public bool EsPalindromeRecursiva(string word)
        {
            bool result = true;
            word = word.Replace(" ", "");
            char[] aw = word.ToCharArray();

            if (aw[0] == aw[aw.Length-1] && aw.Length > 1) {
                EsPalindromeRecursiva(word.Substring(1,word.Length-2));
            }
            else
            {
                result = false;
            }
           


            return result;
        }


    }
}
