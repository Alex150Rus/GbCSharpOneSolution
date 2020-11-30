using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Lesson5task1;
using Validators.Lesson5task1;


namespace Lesson5task1
{
    /// <summary>
    /// Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
    /// содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
    /// а) без использования регулярных выражений;
    /// б) ** с использованием регулярных выражений.

    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите, пожалуйста, login:");
            string login = Console.ReadLine();
            Identity user = new Identity();
            user.Login = login;
            IdentityValidator identityValidator = new IdentityValidator(user);
            Console.WriteLine($"Логин валиден: {identityValidator.validateLogin()}");
            Console.WriteLine($"Логин валиден: {identityValidator.validateLoginUsingRegExp()}");
        }
    }
}
