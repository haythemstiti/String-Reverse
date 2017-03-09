using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Reverse
{
    class Program
    {
         private static string Reverse(string word)
        {
            string initialWord = "";
            
            for(int i = word.Length; i >0; i--)
            {
                initialWord += word.ElementAt(i-1);
            }
            return initialWord;
        }

        static void Main(String[] args)
        {
            Console.WriteLine("Enter a word");
            string word = Console.ReadLine();
            string finalWord = Reverse(word);
            Console.WriteLine("The word reversed: " + finalWord);
        }
    }
}
