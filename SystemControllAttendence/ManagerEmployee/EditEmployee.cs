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
    public partial class EditEmployee : Form
    {
        static Document Document;

        public EditEmployee(Document Doc)
        {
            InitializeComponent();
            
            if (Doc != null)
            {
                LastName.Text = Doc.Personnel.LastName;
                Names.Text = Doc.Personnel.Name;
                MiddleName.Text = Doc.Personnel.MiddleName;

                DocNumber.Text = Doc.Number.ToString();
                DocName.Text = Doc.Name;

                Photo.Image = Helper.byteArrayToImage(Doc.Personnel.Photo);
                Document = Doc;
            }
        }

        private void Close(object sender, EventArgs e)
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
        /// <summary>
        /// Сохранение изминений
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveChange_Click(object sender, EventArgs e)
        {
            var LastDoc = new Document() {
                Name = DocName.Text,
                Number = int.Parse(DocNumber.Text),
                Personnel = new Personnel()
                {
                    Name = Names.Text,
                    LastName = LastName.Text,
                    MiddleName = MiddleName.Text,
                    Photo = Helper.imageToByteArray(Photo.Image)
                }    
            };
            
            EmployeeManipulation.Instance.EditEmployee(Document, LastDoc);
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
    }
}
