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
    public partial class ManagerEmployee : Form
    {
        public ManagerEmployee()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        static Document Doc;
        private void SerchPersonel_Click(object sender, EventArgs e)
        {
            if(Textbox1.Text != "")
            Doc = EmployeeManipulation.Instance.GetPersonnelByDocNumber(int.Parse(Textbox1.Text));
            if (Doc != null)
            {
                LastName.Text = Doc.Personnel.LastName;
                Names.Text = Doc.Personnel.Name;
                MiddleName.Text = Doc.Personnel.MiddleName;

                pictureBox1.Image = Helper.byteArrayToImage(Doc.Personnel.Photo);
            }
        }

        
        private void EditEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (Doc != null)
            {
                Position EditEmployee = new Position(Doc);
                EditEmployee.ShowDialog();
            }
            else MessageBox.Show("Студент (сотрудник) не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DeletEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (Doc != null)
            {
                EmployeeManipulation.Instance.DelletPersonnelById(Doc.Personnel.Id);
                MessageBox.Show("Студент (сотрудник) был удален", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Form();
            }
            else MessageBox.Show("Студент (сотрудник) не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Clear_Form()
        {
            Doc = null;
            Names.Text = "Имя";
            LastName.Text = "Фамилия";
            MiddleName.Text = "Отчество";
            Textbox1.Text = "";
            pictureBox1.Image = Resources.user_512_1_;
        }

        private void Textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
