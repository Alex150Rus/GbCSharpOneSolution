using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5task2
{
    /// <summary>
    /// статический класс Message, содержащий cтатические методы для обработки текста
    /// </summary>
    static class Message
    {
        /// <summary>
        /// Вывести только те слова сообщения,  которые содержат не более n букв.
        /// </summary>
        static public string getWordsByLimitedQtyOfLetters(string message, int limit)
        {
            StringBuilder a = new StringBuilder();
            string[] array = message.Split(' ');
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                if (isTheWordLengthInsideLimit(array[i], limit)) a.AppendFormat($"{array[i]} ");
            }
            return a.ToString();
        }

        /// <summary>
        /// Проверяем содержит ли слово не более заданного количества букв
        /// </summary>
        /// <param name="word">Проверяемое слово</param>
        /// <param name="limit">Заданное количество букв</param>
        /// <returns>Возвращает true, если слово в заданном лимите по количеству букв, иначе false</returns>
        static bool isTheWordLengthInsideLimit(string word, int limit)
        {
            char[] array = word.ToCharArray();
            int length = array.Length;
            int count = 0;
            for (int i = 0; i < length; i++)
            {
                if (char.IsLetter(array[i])) count++;
            }

            return count <= limit;
        }

        /// <summary>
        /// Удаляет из сообщения все слова, которые заканчиваются на заданный символ.
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <param name="symbol">Символ, на котроый не должно заканчиваться слово</param>
        /// <returns>Возвращает все слова, которые не заканчиваются на заданный символ</returns>
        public static string getWordsWhichDontEndWithDefSymbol(string message, char symbol)
        {
            StringBuilder a = new StringBuilder();
            string[] array = message.Split(' ');
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                if (array[i].LastIndexOf(symbol) != array[i].Length - 1) a.AppendFormat($"{array[i]} ");
            }
            return a.ToString();
        }

        /// <summary>
        /// Находит самое длинное слово сообщения
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <returns>Возвращает самое длинное слово сообщения</returns>
        public static string getTheLongestWord(string message)
        {
            string[] array = message.Split(' ');
            int length = array.Length;
            string longestWord = "";
            int counter = 0;
            for (int i = 0; i < length; i++)
            {
                string word = array[i];
                int arrLength = word.Length;
                if (arrLength > 0 && char.IsPunctuation(word[arrLength - 1]))
                {
                    word = word.Remove(arrLength - 1);
                    arrLength = word.Length;
                }

                if (counter < arrLength)
                {
                    longestWord = word;
                    counter = arrLength;
                }
            }
            return longestWord;
        }

        /// <summary>
        /// Формирует строку с помощью StringBuilder из самых длинных слов сообщения.
        /// </summary>
        /// <param name="message"></param>
        /// <returns>Возвращает строку из самых длинных слов сообщения</returns>

        public static string getAllLongestWords(string message)
        {
            StringBuilder a = new StringBuilder();
            int longestWordLength = Message.getTheLongestWord(message).Length;
            string[] array = message.Split(' ');
            int length = array.Length;
            for (int i = 0; i < length; i++)
            {
                string word = array[i];
                int arrLength = word.Length;
                if (arrLength > 0 && char.IsPunctuation(word[arrLength - 1]))
                {
                    word = word.Remove(arrLength - 1);
                    arrLength = word.Length;
                }
                if (longestWordLength == arrLength) a.AppendFormat($"{word} ");

            }
            return a.ToString();
        }

        /// <summary>
        /// метод, который производит частотный анализ текста.В качестве параметра в него передается массив слов и текст, 
        /// в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст.
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <param name="words">Массив слов</param>
        /// <returns>Возвращает сколько раз каждое из слов массива входит в текст</returns>
        public static string frequency(string message, string[] words)
        {
            var dict = new Dictionary<string, int>();

            string[] array = message.Split(' ');
            int length = array.Length;
            int wordsArrLength = words.Length;
            for (int i = 0; i < length; i++)
            {

                string word = array[i];
                int arrLength = word.Length;
                if (arrLength > 0 && char.IsPunctuation(word[arrLength - 1])) word = word.Remove(arrLength - 1);
               
                for (int j = 0; j < wordsArrLength; j++)
                {
                    if(words[j].Equals(word))
                    {
                        if (dict.ContainsKey(word)) dict[word]++;
                        else dict.Add(word, 1);
                    }
                }
            }

            StringBuilder a = new StringBuilder();
            foreach (var item in dict)
            {
                a.AppendFormat($"{item.Key} встречается {item.Value} раз; ");
            }
            return a.ToString();
        }
    }
}
