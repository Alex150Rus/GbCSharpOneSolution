using System;
using System.Collections.Generic;
using System.Linq;

namespace ArrayLibrary
{
    public class MyArray
    {
        int[] array;

        /// <summary>
        /// Конструктор создаёт массив заданной длины
        /// </summary>
        /// <param name="length"></param>
        public MyArray (int length)
        {
            array = new int[length];
        }

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
        /// Конструктор, создающий массив определённого размера и заполняющий массив числами от начального значения с заданным шагом
        /// </summary>
        /// <param name="length"></param>
        /// <param name="step"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        public MyArray(int length, int step, int min, int max)
        {
            array = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                if (i % step == 0) array[i] = rnd.Next(min, max);
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
        /// Свойство: сумма элементов массива с типом int
        /// </summary>
        public int Sum
        {
            get
            {
                return array.Sum();
            }
        }

        /// <summary>
        /// Свойство: возвращает количество максимальных эелементов в массиве
        /// </summary>
        public int MaxCount
        {
            get { return qtyOfMaxElems(); }
        }

        /// <summary>
        /// Метод для подсчёта количества максимальных эелементов в массиве
        /// </summary>
        /// <returns>Количество максимальных эелементов в массиве</returns>
        public int qtyOfMaxElems()
        {
            int count = 0;
            int max = array.Max();
            foreach (int elem in array)
                if (elem == max) count++;
            return count;
        }

        /// <summary>
        /// метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый массив, остается без изменений)
        /// </summary>
        /// <returns>массив с измененными знаками у всех элементов массива</returns>
        public MyArray Inverse()
        {
            MyArray newInverseArray = new MyArray(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                newInverseArray[i] = -array[i];
            }
            return newInverseArray;
        }

        /// <summary>
        /// Метод увеличивает каждый элемент массива в заданное количество раз
        /// </summary>
        /// <param name="factor">Множитель</param>
        public void Multy(int factor)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] *= factor;
            }
        }

        /// <summary>
        /// Метод подсчитывает частоту вхождения каждого элемента в массив
        /// </summary>
        public void frequency() {
            var dict = new Dictionary<int, int>();
            foreach (var item in array)
            {
                if (dict.ContainsKey(item)) dict[item]++;
                else dict.Add(item, 1);
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " встречается " + item.Value + " раз");
            }
        }

        /// <summary>
        /// Индексируемое свойство
        /// </summary>
        /// <param name="i">индекс</param>
        /// <returns>Возможность устанавливать и получать элемент массива по указанному индексу</returns>
        public int this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
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
