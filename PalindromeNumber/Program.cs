using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число или слово на проверку: ");
            string str = Console.ReadLine();
            char[] arr = str.ToCharArray();
           
           
            if (IsPalindrom(arr))
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не палиндром");
            Console.ReadKey();
        }

        static bool IsPalindrom(char[] word)
        {
            for (int i = 0; i < word.Length / 2; i++)
                if (word[i] != word[word.Length - 1 - i])
                    return false;
            return true;
        }
    }
}
