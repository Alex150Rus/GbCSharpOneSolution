using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5task2
{
    /// <summary>
    /// Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
    ///а) Вывести только те слова сообщения,  которые содержат не более n букв.
    ///б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    ///в) Найти самое длинное слово сообщения.
    ///г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
    ///д) *** Создать метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.Здесь требуется использовать класс Dictionary.

    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сообщение");
            string message = Console.ReadLine();
            int limit = 5;
            message = Message.getWordsByLimitedQtyOfLetters(message, limit);
            Console.WriteLine($"Выводим только те слова сообщения,  которые содержат не более { limit } букв: { message }");
            Console.WriteLine();

            char symbol = 'd';
            Console.WriteLine($"Удалили все слова, которые заканчиваются на { symbol }: { Message.getWordsWhichDontEndWithDefSymbol(message, symbol)}");
            Console.WriteLine();
            Console.WriteLine($"Самое длинное слово: { Message.getTheLongestWord(message) }");
            Console.WriteLine($"Самые длинные слова: { Message.getAllLongestWords(message)}");
            string[] words = new string[] { "on", "to" };
            Console.WriteLine($"{Message.frequency(message, words)}");

        }
    }
}
