using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class ComplexClass
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
        /// Свойство im
        /// </summary>
        public double Im
        {
            get { return im; }
            set { im = value; }
        }

        /// <summary>
        /// Свойство re
        /// </summary>
        public double Re
        {
            get { return re; }
            set { re = value; }
        }

        public ComplexClass()
        {
            im = 0;
            re = 0;
        }

        /// <summary>
        /// Конструктор класса Complex
        /// </summary>
        /// <param name="_im">действительное число</param>
        /// <param name="re">действительное число</param>
        public ComplexClass(double _im, double re)
        {
            im = _im;
            this.re = re;
        }

        /// <summary>
        /// Метод сложения двух комлексных чисел
        /// </summary>
        /// <param name="x2">комплексное число</param>
        /// <returns>Комплексное число</returns>
        public ComplexClass Plus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = x2.im + im;
            x3.re = x2.re + re;
            return x3;
        }

        /// <summary>
        /// Метод вычитания двух комлексных чисел
        /// </summary>
        /// <param name="x2">комплексное число</param>
        /// <returns>Комплексное число</returns>
        public ComplexClass Minus(ComplexClass x2)
        {
            ComplexClass x3 = new ComplexClass();
            x3.im = im - x2.im;
            x3.re = re - x2.re;
            return x3;
        }

        /// <summary>
        /// Метод умножения двух комплексных чисел
        /// </summary>
        /// <param name="x2">комплексное число</param>
        /// <returns>Результат произведения двух комлексных чисел</returns>
        public ComplexClass Multiply(ComplexClass x2) {
            ComplexClass x3 = new ComplexClass();
            x3.im = im * x2.im - re * x2.re;
            x3.re = im * x2.re + re * x2.im;
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
        /// Метод показывает работу класса    
        /// </summary>
        public static void ShowHowComplexClassWorks()
        {
            Console.WriteLine("А тепреь продемонстрируем работу ComplexClass. Введите, пожалуйста, действительные числа");
            ComplexClass x1 = getComplexNumber("a1", "a2");
            Console.WriteLine($"Первое комплексное число: {x1}");
            ComplexClass x2 = getComplexNumber("b1", "b2");
            Console.WriteLine($"Второе комплексное число: {x2}");
            ComplexClass x3 = x1.Plus(x2);
            ComplexClass x4 = x1.Minus(x2);
            ComplexClass x5 = x1.Multiply(x2);
            Console.WriteLine($"Сумма двух комплексных чисел: {x3}");
            Console.WriteLine($"Разность двух комплексных чисел: {x4}");
            Console.WriteLine($"Произведение двух комплексных чисел: {x5}");
        }

        /// <summary>
        /// Метод генерирует комплексное число по пользовательскому вводу
        /// </summary>
        /// <param name="variableName1"></param>
        /// <param name="variableName2"></param>
        /// <returns>Комплексное число</returns>
        public static ComplexClass getComplexNumber(string variableName1, string variableName2)
        {
            double a1 = Helpers.StringHelper.getUserInputAndConvertToDouble(variableName1);
            double a2 = Helpers.StringHelper.getUserInputAndConvertToDouble(variableName2);
            return new ComplexClass(a1, a2);
        }

        /// <summary>
        /// Метод демонстрирует работу класса ComplexClass используя switch
        /// </summary>
        public static void ShowComplexClassWorksUsingSwitch()
        {
            Console.WriteLine();
            Console.WriteLine("А теперь продемонстрируем работу ComplexClass используя switch. Введите, пожалуйста, действительные числа");
            ComplexClass x1 = getComplexNumber("a1", "a2");
            Console.WriteLine($"Первое комплексное число: {x1}");
            ComplexClass x2 = getComplexNumber("b1", "b2");
            Console.WriteLine($"Второе комплексное число: {x2}");

            bool flag;
            do
            {
                Console.WriteLine("Введите операцию(возможные варианты: сложение, вычитание, умножение):");
                string option = Console.ReadLine();
                switch(option) {
                    case "сложение":
                        Console.WriteLine($"Сумма двух комплексных чисел: {x1.Plus(x2)}");
                        flag = true;
                        break;
                    case "вычитание":
                        Console.WriteLine($"Разность двух комплексных чисел: {x1.Minus(x2)}");
                        flag = true;
                        break;
                    case "умножение":
                        Console.WriteLine($"Произведение двух комплексных чисел: { x1.Multiply(x2)}");
                        flag = true;
                        break;
                    default:
                        flag = false;
                        break;
                }
            } while (!flag);
        }
    }
}
