using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMareigua
{
    public class Task3
    {
        //Contructor
        public Task3(){}

        public void Reverse()
        {
            Console.WriteLine("Type a word please!\n");
            string wordToReverse;
            wordToReverse = Console.ReadLine();
            Console.WriteLine("Reversing the word {0} get: {1}", wordToReverse, ReverseWord(wordToReverse));
        }

        private string ReverseWord(string word)
        {
            var chars = word.ToCharArray();
            string reverseWord = "";

            for (int i = chars.Length - 1; i >= 0; i--)
            {
                reverseWord += chars[i];
            }

            return reverseWord;
        }


    }
}
