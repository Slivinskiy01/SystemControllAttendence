using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemControllAttendence
{
    public partial class AutorizateForm : Form
    {
        public AutorizateForm()
        {
            InitializeComponent();
        }
        Form1 Form = new Form1();
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if ((Login.Text == "admin") && (password.Text == "admin"))
            {
                this.Visible = false;
                Form.ShowDialog();
                this.Visible = true;
            }
            else
            MessageBox.Show("Введенные данные не прошли проверку, на подлиность", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
