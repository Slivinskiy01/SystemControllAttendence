using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemControllAttendence.DataModell;
namespace SystemControllAttendence
{
    public class UserManipulation
    {
        /// <summary>
        /// Staric 
        /// </summary>
        public static UserManipulation Instance = new UserManipulation();
        /// <summary>
        /// Метод авторизации, Возврашаеть модель пользователя если он прошел авторизацию,
        /// иначе Null
        /// </summary>
        /// <param name="login">Логин</param>
        /// <param name="password">Пароль</param>
        /// <returns></returns>
        public User Autorization(string login, string password)
        {
            using (var db = new DataBaseModel())
            {
                var User = db.Users.Where(x => x.Login == login).FirstOrDefault();

                if(User != null)
                {
                    if (User.Password != password)
                        return null;
                    return User;
                }
            }
            return null;
        }
    }
}
