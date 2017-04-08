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
            EditEmployee EditEmployee = new EditEmployee(Doc);
            EditEmployee.ShowDialog();
        }
    }
}
