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
        public static UserManipulation Instance = new UserManipulation();

        public User Autorization(string login, string password)
        {
            using(var db = new DataBaseModel())
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
