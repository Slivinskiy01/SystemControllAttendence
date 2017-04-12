using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemControllAttendence.DataModell;
namespace SystemControllAttendence
{
    public partial class EditUser : Form
    {
        public EditUser(User _User)
        {
            InitializeComponent();
            User = _User;

            Names.Text = _User.Name;
            LastName.Text = _User.LastName;

            Login.Text = _User.Login;
            Password.Text = _User.Password;
            Email.Text = _User.email;

            Photo.Image = Helper.byteArrayToImage(_User.Photo);
            Rolles.selectedIndex = (int)User.roles;
        }

        public static User User;

        private void Closed_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Photo_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Photo.Image = Image.FromFile(dlg.FileName);
            }
            dlg.Dispose();
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            if (Login.Text != "" && Password.Text != "")
            {
                Roles _Rol;
                if (Rolles.selectedIndex == 0)
                    _Rol = Roles.Admin;
                else
                    _Rol = Roles.User;

                User _User = new User()
                {
                    LastName = LastName.Text,
                    Name = Names.Text,

                    Photo = Helper.imageToByteArray(Photo.Image),
                    roles = _Rol,

                    email = Email.Text,
                    Login = Login.Text,
                    Password = Password.Text
                };
                UserManipulation.Instance.EditUser(User.Id, _User);
            }
            Close();
        }
    }
}
