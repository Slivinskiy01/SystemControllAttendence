using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Data.Entity;
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

        public User CurentUser { get; set; }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            var User = UserManipulation.Instance.Autorization(Login.Text, password.Text);

            if(User != null)
            {
                ClearInput();
                if (User.roles == Roles.Admin)
                {
                    Visible = false;
                    CurentUser = User;
                    Form1.ShowDialog();
                    Visible = true;
                }
                else if(User.roles == Roles.User)
                {
                    Visible = false;
                    CurentUser = User;
                    Form2.ShowDialog();
                    try
                    {
                        Visible = true;
                    }
                    catch { }
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

        private void Closed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Close_aplication()
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Login.Text != "")
            { 
               try
               {
                    var User = UserManipulation.Instance.Quit_password(Login.Text);

                    if (User == null)
                    {
                        MessageBox.Show("Такого пользователя не существует", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    MailAddress from = new MailAddress("slivinschii03@gmail.com", "Программа учета посещаемости");

                    MailAddress to = new MailAddress(User.email);

                    MailMessage m = new MailMessage(from, to);

                    m.Subject = "Пароль для работы в программе";

                    m.Body = "Ваш пароль для работы в программе <br>Ваш пароль:" + User.Password;

                    m.IsBodyHtml = true;
                    
                
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

                    smtp.Credentials = new NetworkCredential("slivinschii03@gmail.com", "079655686m");

                    smtp.EnableSsl = true;

                    smtp.Send(m);
                    MessageBox.Show("Сообщение с паролем отправленно на почту", "Информация",MessageBoxButtons.OK,MessageBoxIcon.Information);
               }

                catch(Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else MessageBox.Show("Введите логин","", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
