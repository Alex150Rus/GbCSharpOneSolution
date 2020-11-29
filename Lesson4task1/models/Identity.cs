using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Lesson5task1
{
    /// <summary>
    /// Модель для хранения логина и пароля пользователя
    /// </summary>
    class Identity
    {
        /// <summary>
        /// поле логин
        /// </summary>
        string login;
        /// <summary>
        /// поле пароль
        /// </summary>
        string password;

        /// <summary>
        /// Свойство для установки или получения значения логина
        /// </summary>
        public string Login {
            get { return login; }
            set { login = value; }
        }
    }
}
