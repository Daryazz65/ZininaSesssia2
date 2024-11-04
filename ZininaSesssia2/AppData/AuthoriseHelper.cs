using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZininaSesssia2.Model;

namespace ZininaSesssia2.AppData
{
    internal class AuthoriseHelper
    {
        public static User selectedUser;
        private static ZininaSessia2Entities _context = App.GetContext();
        /// <summary> 
        /// Авторизует пользователя.
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Authorise(string login, string password, string role)
        {
            if (login == string.Empty || password == string.Empty)
            {
                MessageBoxHelper.Error("Не все поля для ввода были заполнены.");
                return false;
            }
            //else
            //{
            //    if (role == "Cотрудник методички")
            //    {
            //        List<User> users = _context.Users.ToList();
            //        foreach (User us in users)
            //        {
            //            if (login == us.Id && password == us.Password)
            //            {
            //                selectedUser = us;
            //                return true;
            //            }
            //        }
            //        if (selectedUser == null)
            //        {
            //            MessageBoxHelper.Error("Неправильно введен логин или пароль");
            //            return false;
            //        }
            //    }
            else
            {
                if (role == "Сотрудник методического отдела")
                {
                    List<User> users = _context.Users.ToList();
                    foreach (User us in users)
                    {
                        if (login == us.Id.ToString() && password == us.Password)
                        {
                            selectedUser = us;
                            return true;
                        }
                    }
                    if (selectedUser == null)
                    {
                        MessageBoxHelper.Error("Неправильно введен логин или пароль");
                        return false;
                    }
                }

                else
                {
                    return false;
                }
                if (selectedUser != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        /// <summary>
        /// Генерирует текст капчи.
        /// </summary>
        /// <returns></returns>
        public static string GenerateCaptcha()
        {
            List<char> chars = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                                                    'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
                                                    '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
            Random random = new Random();
            string output = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                output += chars[random.Next(0, chars.Count)];
            }
            return output;
        }
    }
}