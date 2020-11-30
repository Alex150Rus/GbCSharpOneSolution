using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Models.Lesson5task1;

namespace Validators.Lesson5task1
{
    /// <summary>
    /// Валидатор модели Identity, хранящей логин и пароль пользователя
    /// </summary>
    class IdentityValidator
    {
        /// <summary>
        /// Поле хранящее объект класса Identity
        /// </summary>
        Identity identity;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="identity">объект Класса Identity</param>
        public IdentityValidator(Identity identity)
        {
            this.identity = identity;
        }

        /// <summary>
        /// Метод проверяет, без использования регулярных выражений, корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
        /// содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        /// </summary>
        /// <returns>Возвращает true в случае успешной валидации или false в противном случае</returns>
        public bool validateLogin()
        {
            string login = identity.Login;
            char[] array = login.ToCharArray();
            int length = array.Length;

            if (char.IsDigit(login[0])) return false;
            if(length < 2 || length > 9) return false;

            for (int i = 0; i < length; i++)
            {
                if (!char.IsLetterOrDigit(array[i])) return false;
            }

            return true;
        }

        /// <summary>
        /// Метод проверяет, c использованием регулярных выражений, корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, 
        /// содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
        /// </summary>
        /// <returns>Возвращает true в случае успешной валидации или false в противном случае</returns>
        public bool validateLoginUsingRegExp()
        {
            Regex regex = new Regex(@"^[a-zA-Z][a-zA-Z0-9]{1,8}$");
            return regex.IsMatch(identity.Login);
        }
    }
}
