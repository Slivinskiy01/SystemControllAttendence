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
            if (a.Text == "Фамилия" || a.Text == "Имя" || a.Text == "Отчество" || a.Text == "Номер")
            {
                PlaceHolder = a.Text;
                a.Text = "";
            }
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
                pictureBox1.Image = Image.FromFile(dlg.FileName);

            }
            dlg.Dispose();
        }
    }
}
