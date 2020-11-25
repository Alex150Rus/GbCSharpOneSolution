using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    struct Complex
    {
        /// <summary>
        /// Первое действительное число
        /// </summary>
        double im;
        /// <summary>
        /// Второе действительное число
        /// </summary>
        double re;

        /// <summary>
        /// Конструктор структуры Complex
        /// </summary>
        /// <param name="_im">действительное число</param>
        /// <param name="re">действительное число</param>
        public Complex(double _im, double re)
        {
            im = _im;
            this.re = re;
        }

        /// <summary>
        /// Метод сложения двух комлексных чисел
        /// </summary>
        /// <param name="x2">комплексное число</param>
        /// <returns>Комплексное число</returns>
        public Complex Plus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        /// <summary>
        /// Метод вычитания двух комлексных чисел
        /// </summary>
        /// <param name="x2">комплексное число</param>
        /// <returns>Комплексное число</returns>
        public Complex Minus(Complex x2)
        {
            Complex x3 = new Complex();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        /// <summary>
        /// Метод вывода комплексного числа с использование перегрузки метода toString
        /// </summary>
        /// <returns>Комлексное число</returns>
        public override string ToString()
        {
            string sign = re < 0 ? "" : "+";
            return im + sign + re + "i";
        }

        /// <summary>
        /// Метод показывает работу структуры    
        /// </summary>
        public static void ShowHowStructureWorks()
        {
            Console.WriteLine("Введите, пожалуйста, действительные числа");
            double a1 = Helpers.StringHelper.getUserInputAndConvertToDouble("a1");
            double a2 = Helpers.StringHelper.getUserInputAndConvertToDouble("a2");
            double b1 = Helpers.StringHelper.getUserInputAndConvertToDouble("b1");
            double b2 = Helpers.StringHelper.getUserInputAndConvertToDouble("b2");
            Complex x1 = new Complex(a1, a2);
            Console.WriteLine($"Первое комплексное число: {x1}");
            Complex x2 = new Complex(b1, b2);
            Console.WriteLine($"Второе комплексное число: {x2}");
            Complex x3 = x1.Plus(x2);
            Complex x4 = x1.Minus(x2);
            Console.WriteLine($"Сумма двух комплексных чисел: {x3}");
            Console.WriteLine($"Разность двух комплексных чисел: {x4}");
        }
    }
}
