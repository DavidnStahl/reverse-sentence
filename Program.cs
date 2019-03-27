using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversedString2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a sentence: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' '); // vid varje mellanslag delas orden in multiarray
            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " "); // Ge varje ord ett mellanslag i loopen

            }

            Console.ReadLine();
    }   }
}
