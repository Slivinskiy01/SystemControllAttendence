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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
           
            Close();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HomeBtn.selected = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if(LeftPanel.Width == 220)
            {

                LeftPanel.Width = 50;
                LeftPanel.Visible = false;
                LeftPanelTransition.ShowSync(LeftPanel);
                MenuLogo.Visible = false;
            }
            else
            {

                LeftPanel.Width = 220;
                LeftPanel.Visible = false;
                LeftPanelTransition.ShowSync(LeftPanel);
            }
        }

        private void SerchInput_Validated(object sender, EventArgs e)
        {
            if (SerchInput.text == "")
                SerchInput.text = "Serch...";
            
        }

        private void SerchInput_Enter(object sender, EventArgs e)
        {
            if (SerchInput.text == "Serch...")
                SerchInput.text = "";
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            homeUserControl1.Visible = true;
            mannagerControl1.Visible = false;
        }

        private void ManagerBtn_Click(object sender, EventArgs e)
        {
            homeUserControl1.Visible = false;
            mannagerControl1.Visible = true;
        }
    }
}
