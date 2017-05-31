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

            LastNameCurentUser.Text = Program.AutorizateForms.CurentUser.LastName;
            NameCurentUser.Text = Program.AutorizateForms.CurentUser.Name;
            PhotoCurentUser.Image = Helper.byteArrayToImage(Program.AutorizateForms.CurentUser.Photo);
            CurentUserRolles.Text = "Администратор";
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

        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            ManagerEmployee ManEmp = new ManagerEmployee();
            this.Visible = false;
            ManEmp.ShowDialog();
            this.Visible = true;

        }
        
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            AddEmployee AddEmployee = new AddEmployee();
            this.Visible = false;
            AddEmployee.ShowDialog();
            this.Visible = true;
        }
        
        private void AddUserBtn_Click(object sender, EventArgs e)
        {
            AddUser AddUser = new AddUser();
            Visible = false;
            AddUser.ShowDialog();
            Visible = true;
        }
       
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ManagerUser ManagerUser = new ManagerUser();
            Visible = false;
            ManagerUser.ShowDialog();
            Visible = true;
        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
           
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
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
        }
        private void bunifuCheckbox2_OnChange(object sender, EventArgs e)
        {
            checkClear();
            bunifuCheckbox2.Checked = true;
            panel8.Visible = true;
            panel8.Size = new Size(321,272);
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            dateTimePicker3.Format = DateTimePickerFormat.Custom;
            dateTimePicker3.CustomFormat = "MM/yyyy";
        }
        private void checkClear()
        {
            panel8.Size = new Size(1, 272);
            bunifuCheckbox2.Checked = false;
            bunifuCheckbox1.Checked = false;
            panel4.Visible = false;
        }
        
        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
           

        }

        private void StringBarCode_TextChanged(object sender, EventArgs e)
        {
            if (StringBarCode.Text != "")
            {
                Zen.Barcode.BarcodeSymbology s = Zen.Barcode.BarcodeSymbology.Code128;
                Zen.Barcode.BarcodeDraw drawObject = Zen.Barcode.BarcodeDrawFactory.GetSymbology(s);
                var metrics = drawObject.GetDefaultMetrics(60);
                metrics.Scale = 2;
                PicerBarCode.Image = drawObject.Draw(StringBarCode.Text, metrics);
            }
            else PicerBarCode.Image = null;
        }

        private void BtnPrinterShowDialog_Click(object sender, EventArgs e)
        {
            // printPreviewDialog1.Document = PicerBarCode.Image;
            try
            {
                printDocument1.DocumentName = PicerBarCode.Image.ToString();
                printDialog1.Document = printDocument1;
                printPreviewDialog1.Document = printDialog1.Document;
                printPreviewDialog1.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Ошибка печати", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(PicerBarCode.Image, 30, 30);
        }

        private void SerchUser_Click_1(object sender, EventArgs e)
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (Doc != null)
            {
                saveFileDialog1.Filter = "Word | *.docx";
                saveFileDialog1.DefaultExt = "docx";
                /*
                DialogResult Save = MessageBox.Show("Выберите путь для сохранения файла", "Сохранение",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
                if (Save == DialogResult.OK)
                {*/
                    if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                        return;
                        
                // получаем выбранный файл
                string filenameSave = saveFileDialog1.FileName;
                Helper.GenerateReport(dateTimePicker1.Value, dateTimePicker2.Value, Doc, filenameSave);
                //}
            }
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Helper.GenerateGroopReport(dateTimePicker3.Value);
        }
    }
}
