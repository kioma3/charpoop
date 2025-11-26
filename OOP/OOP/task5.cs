using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class task5
    {
        public static int Word(string word, out int consonantAmount)
        {
            int vowelAmount = 0;

            consonantAmount = 0;

            char[] characters = word.ToCharArray();

            for (int i = 0; i < characters.Length; i++)
            {
                if (characters[i] == 'a' || characters[i] == 'e' || characters[i] == 'i' || characters[i] == 'o' || characters[i] == 'u')
                {
                    vowelAmount += 1;
                }
                else
                {
                    consonantAmount += 1;
                }
            }

            return vowelAmount;
        }
    }
}
