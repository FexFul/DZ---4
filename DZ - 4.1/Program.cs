using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ___4
{
    internal class Program
    {
        static String[] GetSplitString(String sentence)
        {

            String[] sentenceArray = sentence.Split(' ');
            return sentenceArray;
        }

        static void WriteInConsoleSplitSentence(String[] splitSentence)
        {
            Console.WriteLine("Разделённое предложение: ");
            foreach (String word in splitSentence)
            {
                System.Console.WriteLine($"{word} ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение для разделения: ");
            WriteInConsoleSplitSentence(GetSplitString(Console.ReadLine()));


            Console.ReadLine();
        }
    }
}
