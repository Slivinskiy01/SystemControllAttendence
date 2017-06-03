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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
            
        }

        string PlaceHolder = "";
        public void RemoveText(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            if (placeholderText(a.Text))
            {
                PlaceHolder = a.Text;
                a.Text = "";
            }
        }
        /// <summary>
        /// Метод определяющий являится ли строка
        /// значением placeholde, 
        /// </summary>
        /// <param name="a">string</param>
        /// <returns>bool</returns>
        private bool placeholderText(string a)
        {
            var PlaceHolderText = new string[] 
            {
                "Фамилия",
                "Имя",
                "Отчество",
                "Номер",
            };
            
            for(int i = 0; i< PlaceHolderText.Length; i++)
            {
                if (PlaceHolderText[i] == a)
                    return true;
            }
            return false;
        }

        public void AddText(object sender, EventArgs e)
        {
            TextBox a = (TextBox)sender;
            if(a.Text == "")
                a.Text = PlaceHolder;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Title = "Open Image";
            dlg.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Photo.Image = Image.FromFile(dlg.FileName);

            }
            dlg.Dispose();
        }
        
        private void AddEmployees_Click(object sender, EventArgs e)
        {
            if (Names.Text == "" || DocNumber.Text == "" || placeholderText(DocNumber.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка");
                return;
            }
            var Per = new Personnel()
            {
                Name = Names.Text,
                LastName = LastName.Text,
                MiddleName = MiddleName.Text,
                Position = Position.selectedValue,
                Photo = Helper.imageToByteArray(Photo.Image)
            };

            var Doc = new Document()
            {
                Name = DocName.selectedValue,
                Number = int.Parse(DocNumber.Text),
                Personnel = Per
            };
            
            Enabled = false;
            UseWaitCursor = true;
            EmployeeManipulation.Instance.AddEmployee(Per, Doc);
            UseWaitCursor = false;
            Enabled = true;
            Close();
        }

        private void DocNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void LockInputNumber(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DocNumber_TextChanged(object sender, EventArgs e)
        {
            if (DocNumber.Text != "")
            {
                Zen.Barcode.BarcodeSymbology s = Zen.Barcode.BarcodeSymbology.Code128;
                Zen.Barcode.BarcodeDraw drawObject = Zen.Barcode.BarcodeDrawFactory.GetSymbology(s);
                var metrics = drawObject.GetDefaultMetrics(60);
                metrics.Scale = 2;
                PicerBarCode.Image = drawObject.Draw(DocNumber.Text, metrics);
            }
            else PicerBarCode.Image = null;
        }
    }
}
