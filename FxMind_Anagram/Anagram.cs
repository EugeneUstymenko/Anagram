using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FxMind_Anagram
{
    public class Anagram
    {
        private static void ReverseWord(char[] charArray)
        {
            int i = charArray.Length - 1;
            int j = 0;

            while (j < i)
            {
                if (!char.IsLetter(charArray[j]))
                {
                    j++;
                }
                else if (!char.IsLetter(charArray[i]))
                    i--;
                else
                {
                    char tmp = charArray[j];
                    charArray[j] = charArray[i];
                    charArray[i] = tmp;
                    j++;
                    i--;
                }
            }
        }
        public string Reverse(string text)
        {
            if(text == null)
            {
                Console.WriteLine("Result: input data is invalid or null");
                throw new ArgumentNullException("input data is invalid or null");
            }
            string[] splitText = text.Split(' ');
            for (int i = 0; i < splitText.Length; i++)
            {
                char[] charArray = splitText[i].ToCharArray();
                ReverseWord(charArray);
                string tmp = new string(charArray);
                while (i < splitText.Length)
                {
                    splitText[i] = tmp;
                    break;
                }
            }
            string reverseText = string.Join(" ", splitText);
            return reverseText;
        }
    }
}
