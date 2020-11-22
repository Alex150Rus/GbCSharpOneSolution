using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson3Point2
{
    class Program
    {
        /// <summary>
        /// С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
        /// Требуется подсчитать сумму всех нечётных положительных чисел. 
        /// Сами числа и сумму вывести на экран
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool flag = true;
            double sum = 0;
            string numbers = "";
            do
            {
                double key = GetNumber();
                numbers += key + " ";
                if (key % 2 != 0)
                    sum += key;
               
                if (key == 0)
                    flag = false;
            } while (flag);
            Console.WriteLine(numbers);
            Console.WriteLine($"Сумма всех нечётных положительных чисел {sum}");
        }

        /// <summary>
        /// Метод возвращает число, введённое пользователем
        /// </summary>
        /// <returns>Число, введённое пользователем</returns>
        public static double GetNumber()
        {
            bool flag;
            double result;
            do
            {
                string key = Console.ReadLine();
                flag = double.TryParse(key, out result);
            } while (!flag);
            return result;
        }
    }
}
