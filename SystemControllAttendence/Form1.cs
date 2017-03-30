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
        private void Form1_Load(object sender, EventArgs e)
        {
            HomeBtn.selected = true;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

      /// <summary>
      /// Анимирования выдвижения панели
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
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
        
        /// <summary>
        /// События при нажатию на кнопку Домой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            StealthControllPanel();
            Homes.Visible = true;
        }
        /// <summary>
        /// События при нажатие на кнопку Управление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ManagerBtn_Click(object sender, EventArgs e)
        {
            StealthControllPanel();
            Managers.Visible = true;
        }
        /// <summary>
        /// Оттчет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReptBtn_Click(object sender, EventArgs e)
        {
            StealthControllPanel();
            Rept.Visible = true;
        }
        /// <summary>
        /// Кнопка нстроек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetingBtn_Click(object sender, EventArgs e)
        {
            StealthControllPanel();
            Setings.Visible = true;
        }
        /// <summary>
        /// Метод скрывает все панели
        /// </summary>
        private void StealthControllPanel()
        {
            Homes.Visible = false;
            Managers.Visible = false;
            Rept.Visible = false;
            Setings.Visible = false;
        }

        
    }
}
