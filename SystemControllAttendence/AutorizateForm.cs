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
    public partial class AutorizateForm : Form
    {
        public AutorizateForm()
        {
            InitializeComponent();
        }
        Form1 Form1 = new Form1();
        RegisterEnterOutForm Form2 = new RegisterEnterOutForm();

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            var User = UserManipulation.Instance.Autorization(Login.Text, password.Text);

            if(User != null)
            {
                if(User.roles == Roles.Admin)
                {
                    Visible = false;
                    Form1.ShowDialog();
                    Visible = true;
                }
                else if(User.roles == Roles.User)
                {
                    Visible = false;
                    Form2.ShowDialog();
                    Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInput()
        {
            Login.Text = "Login...";
            password.Text = "password";
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if(Login.Text == "Login...")
            {
                Login.Text = "";
            }
        }

        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Login...";
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if(password.Text == "password")
            {
                password.Text = "";
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.Text = "password";
            }
        }
        
        private void password_KeyPress(object sender, KeyPressEventArgs e)
        {
            BtnLogin_Click(sender, e);
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                BtnLogin_Click(sender, e);
        }
    }
}
