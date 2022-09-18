using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ___4._2
{
    internal class Program
    {

        static void reversWords(String sentence)
        {
            String[] sentenceArray = sentence.Split(' ');
            writeInConsoleReversSentence(sentenceArray);
        }

        static void writeInConsoleReversSentence(String[] splitSentence)
        {
            Console.WriteLine("Разделённое предложение: ");
            for (int i = (splitSentence.Length - 1); i >= 0; i--)
            {
                Console.Write($"{splitSentence[i]} ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение для разделения: ");
            reversWords(Console.ReadLine()); // Разделяем предложение и выводим в обратном порядке в отдельную строку каждое слово

            Console.ReadLine();
        }
    }
}
