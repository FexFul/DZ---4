using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ___4
{
    internal class Program
    {
        static void getSplitString(String sentence)
        {
            String[] sentenceArray = sentence.Split(' ');
            writeInConsoleSplitSentence(sentenceArray);
        }

        static void writeInConsoleSplitSentence(String[] splitSentence)
        {
            Console.WriteLine("Разделённое предложение: ");
            foreach (String word in splitSentence)
            {
                Console.WriteLine($"{word} ");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение для разделения: ");
            getSplitString(Console.ReadLine()); // Разделяем предложение и выводим в отдельную строку каждое слово

            Console.ReadLine();
        }
    }
}
