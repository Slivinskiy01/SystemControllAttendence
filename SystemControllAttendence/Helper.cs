using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemControllAttendence.DataModell;
using SystemControllAttendence.Properties;
using System.Data.Entity;
using System.Windows.Forms;
using System.IO;

namespace SystemControllAttendence
{
   public class Helper
    {
        /// <summary>
        /// Метод конвертации изображения в байтовый масив
        /// </summary>
        /// <param name="imageIn">Imagine</param>
        /// <returns>Byte Array</returns>
        public static byte[] imageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }
        /// <summary>
        /// Метод конвертации байтового масива в изображение 
        /// </summary>
        /// <param name="byteArrayIn">Byte Array</param>
        /// <returns>Imagine</returns>
        public static Image byteArrayToImage(byte[] byteArrayIn)
        {
            if (byteArrayIn == null) return Resources.user_512_1_;//Временный код

            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        /// <summary>
        /// Генерация отчета по одному сотруднику за определенный промежуток времении
        /// </summary>
        /// <param name="FirstTime">Начальная дата промежутка</param>
        /// <param name="LastTime">Конечная дата промежутка</param>
        /// <param name="Doc">Модель документа включающая в себя модель сотрудника</param>
        public static void GenerateReport(DateTime FirstTime, DateTime LastTime, DataModell.Document Doc, string filenameSave)
        {
            var app = new Microsoft.Office.Interop.Word.Application();
            app.Visible = false;

            
                var doc = app.Documents.Open(Environment.CurrentDirectory+@"\SingleEmployeeRep.docx");
                //var doc = app.Documents.Add(Visible: true);
                //Range r = doc.Range();
                //r.Text = " gf";
                Table table = doc.Tables[1];
                //var table = doc.Tables.Add(r, 1, 5);
            
            var db = new DataBaseModel();
            int i = 1;
            int TotalDayPrezent = 0, TotalDayNoExit = 0, TotalLypsedDay = 0;
            try
            {
                var Per = db.Personnels.Include(x => x.Attendances).
                            Where(x => x.Id == Doc.Personnel.Id).FirstOrDefault();
                for (DateTime Ft = FirstTime; Ft <= LastTime; Ft = Ft.AddDays(1))
                {
                   if (Ft.DayOfWeek != DayOfWeek.Sunday)
                    { 
                        var FirstAtte = Per.Attendances.Where(x => x.LoginTime.Value.Date == Ft.Date).FirstOrDefault();
                        var LastAtte = Per.Attendances.Where(x => x.LoginTime.Value.Date == Ft.Date).LastOrDefault();
                        if (FirstAtte != null)
                            {
                                    i++;
                                    table.Rows.Add();
                                    table.Cell(i, 1).Range.Text = (i - 1).ToString();
                                    table.Cell(i, 2).Range.Text = String.Format("{0:dd/MM/yyyy}", Ft);
                                    table.Cell(i, 3).Range.Text = String.Format("{0:T}", FirstAtte.LoginTime.Value);
                                    TotalDayPrezent++;
                                if (LastAtte.OutTime != null)
                                {
                                    table.Cell(i, 4).Range.Text = String.Format("{0:T}", LastAtte.OutTime.Value);
                                    TimeSpan Diferent = LastAtte.OutTime.Value - FirstAtte.LoginTime.Value;
                                    table.Cell(i, 5).Range.Text = Convert.ToString(Diferent.Hours + ":" + Diferent.Minutes + ":" + Diferent.Seconds);
                                }
                                else
                                {
                                    table.Cell(i, 4).Range.Text = String.Format("{0:T}", LastAtte.LoginTime.Value);
                                    TimeSpan Diferent = LastAtte.LoginTime.Value - FirstAtte.LoginTime.Value;
                                    table.Cell(i, 5).Range.Text = Convert.ToString(Diferent.Hours + ":" + Diferent.Minutes + ":" + Diferent.Seconds);
                                TotalDayNoExit++;
                                }
                            }
                            else
                            {
                                i++;
                                table.Rows.Add();
                                table.Cell(i, 1).Range.Text = (i - 1).ToString();
                                table.Cell(i, 2).Range.Text = String.Format("{0:dd/MM/yyyy}", Ft);
                                table.Cell(i, 3).Range.Text = "Lipsed";
                                table.Cell(i, 4).Range.Text = "";
                                table.Cell(i, 5).Range.Text = "0";
                                TotalLypsedDay++;
                            }
                    }
                }
                ReplaceWordSub("{Name}", Per.Name, doc);
                ReplaceWordSub("{LastName}", Per.LastName, doc);
                ReplaceWordSub("{MiddleName}", Per.MiddleName, doc);
                ReplaceWordSub("{position}", Per.Position, doc);
                ReplaceWordSub("{FirstDate}", String.Format("{0:dd/MM/yyyy}", FirstTime), doc);
                ReplaceWordSub("{LastDate}", String.Format("{0:dd/MM/yyyy}", LastTime), doc);
                ReplaceWordSub("{TotalDayPrezent}", TotalDayPrezent.ToString(), doc);
                    ReplaceWordSub("{TotalDayNoExit}", TotalDayNoExit.ToString(), doc);
                    ReplaceWordSub("{TotalLypsedDay}", TotalLypsedDay.ToString(), doc);
                    doc.SaveAs(filenameSave);
                    doc.Close();
                MessageBox.Show("Файл Сохранен");
            }
            catch
            {
                MessageBox.Show(" При генерации отчёта произошла ошибка ", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
               doc.Close();
            }
        }


        public static void GenerateGroopReport()
        {
            

            var db = new DataBaseModel();

            var Per = db.Personnels.Include(x => x.Attendances).ToList();

            var app = new Microsoft.Office.Interop.Word.Application();
            app.Visible = false;


            var doc = app.Documents.Open(Environment.CurrentDirectory + @"\GroupAplicationReport.docx");
            
            Table table = doc.Tables[1];


            int i = 3, PerPresent = 0;

            foreach (var a in Per)
            {
                table.Rows.Add();
                table.Cell(i, 1).Range.Text = a.LastName+" "+a.Name;

                
                for (int j = 1; j <= DateTime.DaysInMonth(2017, 5); j++)
                {
                    foreach (var b in a.Attendances)
                    {
                        if (b.LoginTime.Value.Month == DateTime.Now.Month)
                        {
                            if (b.LoginTime.Value.Day == j)
                            {
                                MessageBox.Show("lol" + b.LoginTime.Value.Day);
                                PerPresent++;
                                table.Cell(i, j+1).Range.Text = "";
                            }
                            else table.Cell(i, j+1).Range.Text = "Н";
                        }
                    }
                }
            }

            table.Cell(i, 33).Range.Text = ""+(DateTime.DaysInMonth(2017, 5) - PerPresent);
            ReplaceWordSub("{Departaments}", "413 Группа", doc);
            ReplaceWordSub("{Monath}", DateTime.Now.Month+"", doc);

            doc.SaveAs(@"C:\Users\Maxim\Desktop\1.docx");
            doc.Close();
            //
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="stubToReplace"></param>
        /// <param name="text"></param>
        /// <param name="WordDocument"></param>
        private static void ReplaceWordSub(string stubToReplace, string text, Microsoft.Office.Interop.Word.Document WordDocument)
        {
            var range = WordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

    }
}
