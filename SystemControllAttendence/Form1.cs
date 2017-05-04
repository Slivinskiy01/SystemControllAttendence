﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemControllAttendence.DataModell;
using System.Data.Entity;

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

                MenuLogo.Visible = false;
                LeftPanel.Width = 50;
                LeftPanel.Visible = false;
                LeftPanelTransition.ShowSync(LeftPanel);
            }
            else
            {

                LeftPanel.Width = 220;
                LeftPanel.Visible = false;
                LeftPanelTransition.ShowSync(LeftPanel);
                LeftPanelLogoTransition.ShowSync(MenuLogo);
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
        ManagerEmployee ManEmp = new ManagerEmployee();
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ManEmp.ShowDialog();
            this.Visible = true;

        }
        AddEmployee AddEmployee = new AddEmployee();
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            AddEmployee.ShowDialog();
            this.Visible = true;
        }
        AddUser AddUser = new AddUser();
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            Visible = false;
            AddUser.ShowDialog();
            Visible = true;
        }
        ManagerUser ManagerUser = new ManagerUser();
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Visible = false;
            ManagerUser.ShowDialog();
            Visible = true;
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(""+bunifuDatepicker2.Value);
            DateTime Lol = bunifuDatepicker2.Value;
        }


        static Document Doc;
        private void SerchUser_Click(object sender, EventArgs e)
        {
            if (Textbox1.Text != "")
                Doc = EmployeeManipulation.Instance.GetPersonnelByDocNumber(int.Parse(Textbox1.Text));
            if (Doc != null)
            {
                LastName.Text = Doc.Personnel.LastName;
                Names.Text = Doc.Personnel.Name;
                pictureBox5.Image = Helper.byteArrayToImage(Doc.Personnel.Photo);
            }
        }

        private void Textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {
            checkClear();
            bunifuCheckbox1.Checked = true;
            panel4.Visible = true;
        }
        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            checkClear();
            bunifuCheckbox2.Checked = true;
        }
        private void checkClear()
        {
            bunifuCheckbox2.Checked = false;
            bunifuCheckbox1.Checked = false;
            panel4.Visible = false;
        }
        
        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            if (Doc != null)
            {
                saveFileDialog1.Filter = "Word | *.docx";
                saveFileDialog1.DefaultExt = "docx";
                DialogResult Save = MessageBox.Show("Выберите путь для сохранения файла", "Сохранение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (Save == DialogResult.OK)
                {
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return;
                    // получаем выбранный файл
                    string filenameSave = saveFileDialog1.FileName;
                    Helper.GenerateReport(bunifuDatepicker1.Value, bunifuDatepicker2.Value, Doc, filenameSave);
                }
                
            }

        }
    }
}
