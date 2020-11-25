using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4CWarrays
{
    class MyArray
    {
        int[] array;

        /// <summary>
        /// Конструктор заполняет массив определёнными значениями
        /// </summary>
        /// <param name="length">Длина массива</param>
        /// <param name="element">Элемент массива</param>
        public MyArray(int length, int element)
        {
            array = new int[length];
            for (int i = 0; i < length; i++)
            {
                array[i] = element;
            }
        }

        /// <summary>
        /// Конструктор заполняет массив случайными значениями от min до max
        /// </summary>
        /// <param name="length">Длина массива</param>
        /// <param name="min">Минимальное случайное число</param>
        /// <param name="max">Максимальное случайное число</param>
        public MyArray(int length, int min, int max)
        {
            array = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                array[i] = rnd.Next(min, max);
            }
        }

        /// <summary>
        /// Свойство класса: максимальный элемент массива
        /// </summary>
        public int Max {
            get
            {
                int max = array[0];
                foreach (int elem in array)
                {
                    if (elem > max)
                        max = elem;
                }
                return max;
            }
        }

        /// <summary>
        /// Свойство класса: минимальный элемент массива
        /// </summary>
        public int Min
        {
            get
            {
                int min = array[0];
                foreach (int elem in array)
                {
                    if (elem < min)
                        min = elem;
                }
                return min;
            }
        }

        /// <summary>
        /// Свойство: среднее значение суммы элементов массива
        /// </summary>
        public double Average
        {
            get
            {
                int sum = 0;
                foreach (int elem in array)
                    sum += elem;
                return (double)sum / array.Length;
            }
        }

        /// <summary>
        /// Свойство: количество положительных элементов в массиве
        /// </summary>
        public int CountPositiv {
            get
            {
                int count = 0;
                foreach (int elem in array)
                    if (elem > 0) count++;
                return count;
            }
        }

        /// <summary>
        /// Индексируемое свойство
        /// </summary>
        /// <param name="i">индекс</param>
        /// <returns>Элемент массива по указанному индексу</returns>
        public int this[int i]
        {
            get { return array[i]; }
        }

        /// <summary>
        /// Сортировка массива методом пузырька
        /// </summary>
        public void BubbleSort()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length-1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int t = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = t;
                    }
                }
            }
        }

        /// <summary>
        /// Перегрузка метода toString
        /// </summary>
        /// <returns>Строковое представление массива</returns>
        public override string ToString()
        {
            string s = "";
            foreach (int elem in array)
                s += elem + " ";
            return s;
        }

        /// <summary>
        /// Выводит на экран элементы массива
        /// </summary>
        public void Print()
        {
            foreach (int elem in array)
            {
                Console.WriteLine(elem);
            }
            Console.WriteLine();
        }
    }
}
