using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FxMind_Anagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the text to be reverse: ");
            string text = Convert.ToString(Console.ReadLine());
            Anagram anagram = new Anagram();
            string revText = anagram.Reverse(text);
            Console.WriteLine("\nResult: " + revText);

            Console.ReadKey();
        }
    } 
}
