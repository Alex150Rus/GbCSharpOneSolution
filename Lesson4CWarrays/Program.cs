using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrayLibrary;

namespace Lesson4CWarrays
{
    class Program
    {
        static void Main(string[] args)
        {
          
            MyArray array = new MyArray(5, 7);
            array.Print();
            Console.WriteLine($"Макс: {array.Max}");
            Console.WriteLine($"Мин: {array.Min}");
            Console.WriteLine($"Среднее: {array.Average}");
            Console.WriteLine();

            MyArray array2 = new MyArray(8, -5, 11);
            array2.Print();
            Console.WriteLine($"Макс: {array2.Max}");
            Console.WriteLine($"Мин: {array2.Min}");
            Console.WriteLine($"Среднее: {array2.Average}");
            Console.WriteLine($"Количество положительных элементов массива: {array2.CountPositiv}");
            array2.BubbleSort();
            Console.WriteLine(array2);
            Console.WriteLine($"Пятый элемент массива: {array2[5]}");
            Console.WriteLine();

            MyArray array3 = new MyArray(15, 3, -4, 9);
            Console.WriteLine(array3.ToString());
            Console.WriteLine(array2.Sum);
            Console.WriteLine();
            Console.WriteLine("Получим новый массив с изменёнными знаками:");
            Console.WriteLine(array2.ToString());
            Console.WriteLine(array2.Inverse().ToString());
            Console.WriteLine(array2.ToString());
            array2.Multy(5);
            Console.WriteLine(array2.ToString());

            array2.frequency();
            Console.WriteLine(array2.MaxCount);
        }

    }
}
