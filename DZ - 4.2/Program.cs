using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ___4._2
{
    internal class Program
    {

        static String[] GetSplitString(String sentence)
        {

            String[] sentenceArray = sentence.Split(' ');
            return sentenceArray;
        }

        static void WriteInConsoleReversSentence(String[] splitSentence)
        {
            Console.WriteLine("Разделённое предложение: ");
            for (int i = (splitSentence.Length - 1); i >= 0; i--)
            {
                System.Console.Write($"{splitSentence[i]} ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение для разделения: ");
            WriteInConsoleReversSentence(GetSplitString(Console.ReadLine()));


            Console.ReadLine();
        }
    }
}
