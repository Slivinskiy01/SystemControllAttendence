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
    public partial class RegisterEnterOutForm : Form
    {
        public RegisterEnterOutForm()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if(textBox4.Text.Length == 5)
            {
                var Doc = EmployeeManipulation.Instance.GetPersonnelByDocNumber(int.Parse(textBox4.Text));

                if(Doc != null)
                {
                    LastName.Text = Doc.Personnel.LastName;
                    Names.Text = Doc.Personnel.Name;
                    MiddleName.Text = Doc.Personnel.MiddleName;
                    pictureBox1.Image = Helper.byteArrayToImage(Doc.Personnel.Photo);

                    DocName.Text = Doc.Name;
                    DocNumber.Text = Doc.Number.ToString();

                    Status.BackColor = Color.SeaGreen;
                    Status.Text = "Allowed";
                    textBox4.Text = "";
                }
                else
                {
                    Status.BackColor = Color.FromArgb(217, 83, 79);
                    Status.Text = "Locked";
                    FormClear();
                }
            }
        }

        private void FormClear()
        {
            LastName.Text = "";
            Names.Text = "";
            MiddleName.Text = "";
            pictureBox1.Image = Resources.user_512_1_;

            DocName.Text = "";
            DocNumber.Text = "";
            textBox4.Text = "";
        }
    }
}
