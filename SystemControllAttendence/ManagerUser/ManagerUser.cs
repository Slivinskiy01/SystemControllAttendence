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
using SystemControllAttendence.Properties;

namespace SystemControllAttendence
{
    public partial class ManagerUser : Form
    {
        private void MinimizaidBtnLabel_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ClosedBtnLabe_Click(object sender, EventArgs e)
        {
            Close();
        }

        public ManagerUser()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Clear primari element Form
        /// </summary>
        private void Clear_Form()
        {
            User = null;
            Names.Text = "Имя";
            LastName.Text = "Фамилия";
            Textbox1.Text = "";
            pictureBox1.Image = Resources.user_512_1_;
        }
        /// <summary>
        /// Статическое поле User
        /// </summary>
        static User User;
        /// <summary>
        /// Control exist User
        /// </summary>
        /// <returns>Bool,</returns>
        private bool ControlExistUser()
        {
            if (User != null)
            {
                return true;
            }
            Clear_Form();
            MessageBox.Show("Пользователь не найден", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            return false;
        }
        /// <summary>
        /// Событие при нажатие на кнопку пойска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SerchUser_Click(object sender, EventArgs e)
        {
            if(Textbox1.Text != "")
            User = UserManipulation.Instance.GetUserByEmail(Textbox1.Text);
            if (!ControlExistUser()) return;

                LastName.Text = User.LastName;
                Names.Text = User.Name;
                pictureBox1.Image = Helper.byteArrayToImage(User.Photo);
           
        }

        private void DeletUserBtn_Click(object sender, EventArgs e)
        {
            if (!ControlExistUser()) return;
            UserManipulation.Instance.DeleteUserById(User.Id);
            Clear_Form();
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            if (!ControlExistUser()) return;
            EditUser Edit = new EditUser(User);
            Edit.ShowDialog();
        }
    }
}
