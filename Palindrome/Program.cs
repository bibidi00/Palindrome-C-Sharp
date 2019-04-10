using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(is_palindrome("John"));      // false
            Console.WriteLine(is_palindrome("Hannah"));    // true
            Console.WriteLine(is_palindrome("Kiwik"));     // true
            Console.ReadKey();
        }

        public static Boolean is_palindrome(String word)
        {
            String reverseword = "";
            Char[] array = word.ToLower().ToCharArray();
            Array.Reverse(array);
            foreach(Char a in array)
            {
                reverseword += a.ToString();
            }

            return word.ToLower().Equals(reverseword);
        }
    }
}
