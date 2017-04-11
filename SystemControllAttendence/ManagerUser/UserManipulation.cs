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
        /// <summary>
        /// Метод добавления нового пользователя
        /// </summary>
        /// <param name="_User">Модель пользователя</param>
        public void AddUser(User _User)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите добавить пользователя?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (var Db = new DataBaseModel())
                {
                    var Users = Db.Users.ToList();
                    foreach (var a in Users)
                    {
                        if (_User.Login == a.Login)
                        {
                            MessageBox.Show("Такой логин уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        if (_User.email == a.email)
                        {
                            MessageBox.Show("Такой email уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    Db.Users.Add(_User);
                    try
                    {
                        Db.SaveChanges();
                        MessageBox.Show("Пользователь добавлен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка при добавлении записи в БД", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Изменения не сохранены", "Информация");
            }
        }


    }
}
