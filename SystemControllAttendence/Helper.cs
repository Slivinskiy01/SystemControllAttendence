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

        public static void GenerateReport(DateTime FirstTime, DateTime LastTime, DataModell.Document Doc)
        {
            var app = new Microsoft.Office.Interop.Word.Application();
            app.Visible = false;
            var doc = app.Documents.Open(@"C:\Users\Developer\Source\Repos\SystemControllAttendence\SystemControllAttendence\bin\Debug\SingleEmployeeRep.docx");
            //var doc = app.Documents.Add(Visible: true);
            //Range r = doc.Range();
            //r.Text = " gf";
            Table table = doc.Tables[1];
            //var table = doc.Tables.Add(r, 1, 5);

            int i = 1;
            int TotalDayPrezent = 0, TotalDayNoExit = 0, TotalLypsedDay = 0;
            try
            {
                for (DateTime Ft = FirstTime; Ft <= LastTime; Ft = Ft.AddDays(1))
                {
                   if (Ft.DayOfWeek != DayOfWeek.Sunday)                   
                    using (var db = new DataBaseModel())
                    {

                        var Per = db.Personnels.Include(x => x.Attendances).
                            Where(x => x.Id == Doc.Personnel.Id).FirstOrDefault();
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
                                    table.Cell(i, 4).Range.Text = "Not Exit";
                                    table.Cell(i, 5).Range.Text = "NaN";
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
                        
                        ReplaceWordSub("{Name}", Per.Name, doc);
                        ReplaceWordSub("{LastName}", Per.LastName, doc);
                        ReplaceWordSub("{MiddleName}", Per.MiddleName, doc);
                        ReplaceWordSub("{position}", Per.Position, doc);
                            ReplaceWordSub("{FirstDate}", String.Format("{0:dd/MM/yyyy}", FirstTime), doc);
                            ReplaceWordSub("{LastDate}", String.Format("{0:dd/MM/yyyy}", LastTime), doc);
                    }
            }
                ReplaceWordSub("{TotalDayPrezent}", TotalDayPrezent.ToString(), doc);
                ReplaceWordSub("{TotalDayNoExit}", TotalDayNoExit.ToString(), doc);
                ReplaceWordSub("{TotalLypsedDay}", TotalLypsedDay.ToString(), doc);
                doc.SaveAs(@"C:\Users\Developer\Desktop\1.docx");
            doc.Close();
            }
            catch
            {

                MessageBox.Show(" ! ");
               doc.Close();
            }
        }

        private static void ReplaceWordSub(string stubToReplace, string text, Microsoft.Office.Interop.Word.Document WordDocument)
        {
            var range = WordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }

    }
}
