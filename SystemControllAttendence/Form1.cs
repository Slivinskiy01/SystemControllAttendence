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
            bunifuFlatButton1.selected = true;
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
    }
}
