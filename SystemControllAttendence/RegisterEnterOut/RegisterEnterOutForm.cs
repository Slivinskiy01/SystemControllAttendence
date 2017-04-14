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
        /// <summary>
        /// Evet, register Enter & Out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    PositionName.Text = Doc.Personnel.Position;

                    DocName.Text = Doc.Name;
                    DocNumber.Text = Doc.Number.ToString();

                    Status.BackColor = Color.SeaGreen;
                    Status.Text = "Allowed";
                    textBox4.Text = "";
                    
                    using(var db = new DataBaseModel())
                    {
                        var Per = db.Personnels.Find(Doc.Personnel.Id);
                        var At = db.Attendances.ToList();
                        Attendance LastAten = Per.Attendances.ToList().LastOrDefault();
                        
                        if (LastAten != null)
                        {
                           if(LastAten.LoginTime != null && LastAten.OutTime != null)
                            {
                                var Atend = new Attendance()
                                {
                                    DayWeek = DateTime.Now.DayOfWeek.ToString(),
                                    LoginTime = DateTime.Now,
                                    OutTime = null,
                                    Personnel = Per
                                };
                                db.Attendances.Add(Atend);
                                db.SaveChanges();
                            }
                           else if (LastAten.LoginTime != null && LastAten.OutTime == null)
                            {
                                var AtendEdit = db.Attendances.Single(x => x.Id ==LastAten.Id);
                                AtendEdit.OutTime = DateTime.Now;
                                db.SaveChanges();
                            }
                        }
                        else
                        {
                            var Atend = new Attendance()
                            {
                                DayWeek = DateTime.Now.DayOfWeek.ToString(),
                                LoginTime = DateTime.Now,
                                OutTime = null,
                                Personnel = Per
                                
                            };
                            db.Attendances.Add(Atend);
                            db.SaveChanges();
                        }
                    }
                }
                else
                {
                    Status.BackColor = Color.FromArgb(217, 83, 79);
                    Status.Text = "Locked";
                    FormClear();
                }
            }
        }
        /// <summary>
        /// Clear Form
        /// </summary>
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
        /// <summary>
        /// Event Key Press, Lock Input char
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SecureInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
