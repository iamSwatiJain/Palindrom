using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string to check if palindrome:");
            String input = Console.ReadLine();

            Palindrom pal = new Palindrom();

            if (pal.FindPalindrom(input))
                Console.WriteLine("Your string is Palindrome!");
            else
                Console.WriteLine("Your string is NOT Palindrome");
        }
    }
}
