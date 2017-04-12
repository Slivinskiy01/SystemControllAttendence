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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод определяющий являится ли строка
        /// значением placeholde, 
        /// </summary>
        /// <param name="a">string</param>
        /// <returns>bool</returns>
        private bool placeholderText(string a)
        {
            var PlaceHolderText = new string[]
            {
                "Фамилия",
                "Имя",
                "Отчество",
                "Номер",
            };

            for (int i = 0; i < PlaceHolderText.Length; i++)
            {
                if (PlaceHolderText[i] == a)
                    return true;
            }
            return false;
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

        private void LockInputNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        string PlaceHolder = "";
        private void RemoveText(object sender, EventArgs e)
        {
       
            TextBox a = (TextBox)sender;
            if (placeholderText(a.Text))
            {
                PlaceHolder = a.Text;
                a.Text = "";
            }
        }

        private void AddText(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            if (a.Text == "")
                a.Text = PlaceHolder;
        }

        private void Minim_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Closed_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Событие при нажатие на клавишу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddUserBtn_Click(object sender, EventArgs e)
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
                UserManipulation.Instance.AddUser(_User);
                Close();
            }
        }
    }
}
