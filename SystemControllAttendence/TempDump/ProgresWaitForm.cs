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
    public partial class ProgresWaitForm : Form
    {
        public ProgresWaitForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.AllowTransparency = true;
           // this.BackColor = Color.AliceBlue;//цвет фона  
            //this.TransparencyKey = this.BackColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bunifuCircleProgressbar1.Value < 100)
            {
                bunifuCircleProgressbar1.Value += 4;
            }
            else
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(bunifuCircleProgressbar1.Value > 0)
            {
                bunifuCircleProgressbar1.Value -= 1;
            }
            else
            {
                timer2.Stop();
                timer1.Start();
            }
        }
    }
}
