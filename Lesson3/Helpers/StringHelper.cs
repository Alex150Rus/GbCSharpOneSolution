using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3.Helpers
{
    /// <summary>
    /// Класс для обработки строк
    /// </summary>
    class StringHelper
    {
        /// <summary>
        /// Принимает имя переменной, обрабатывает пользовательский ввод и возвращает число типа double
        /// </summary>
        /// <param name="variableName">Имя переменной</param>
        /// <returns>Число типа double</returns>
        public static double getUserInputAndConvertToDouble(string variableName)
        {
            bool flag;
            double a;
            do
            {
                Console.Write($"{variableName}:");
                string s = Console.ReadLine();
                flag = double.TryParse(s, out a);
            } while (!flag);

            return a;
        }
    }
}
