using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Lab2
    {
        /**summary 
         * Write a program to count no. of palindrome wordds in the given string.
         * Welcome All liril is soap Malayalam madam is heading company
        **/
        public void CheckPaLindrome(string s)
        {
            string[] word = s.Split(' '); // split the sentence into words
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                string w = word[i].ToLower();  // converts the word to lower case
                string rev = "";

                for (int j = w.Length - 1; j >= 0; j--)
                {
                    rev = rev + w[j];
                }


                if (w.Equals(rev))
                {
                    count++;
                }
            }

            Console.WriteLine("Number of palindrome words in the given string is " + count);
        }


        static void Main()
        {
            Console.WriteLine("Enter the string");
            String s = Console.ReadLine();
            Lab2 l = new Lab2();
            l.CheckPaLindrome(s);
        }
    }
}