﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Complex.ShowHowStructureWorks();
            Console.WriteLine();
            ComplexClass.ShowHowComplexClassWorks();
            ComplexClass.ShowComplexClassWorksUsingSwitch();
        }
    }
}
