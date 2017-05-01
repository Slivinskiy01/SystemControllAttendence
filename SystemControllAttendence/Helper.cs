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

        public static void GenerateReport()
        {
            var app = new Microsoft.Office.Interop.Word.Application();
            app.Visible = false;
            var doc = app.Documents.Open(@"C:\Users\Developer\Source\Repos\SystemControllAttendence\SystemControllAttendence\bin\Debug\SingleEmployeeRep.docx");
            Table table = doc.Tables[1];

            int i = 1;
            try
            {
                using (var db = new DataBaseModel())
                {

                    var Per = db.Personnels.Include(x => x.Attendances).Where(x => x.Id == 1).FirstOrDefault();

                    foreach (var a in Per.Attendances)
                    {
                        i++;
                        table.Rows.Add();
                        table.Cell(i, 1).Range.Text = (i - 1).ToString();
                        table.Cell(i, 2).Range.Text = String.Format("{0:MM/dd/yyyy}", a.LoginTime.Value);
                        table.Cell(i, 3).Range.Text = String.Format("{0:T}", a.LoginTime.Value);
                        table.Cell(i, 4).Range.Text = String.Format("{0:T}", a.OutTime.Value);
                        TimeSpan Diferent = a.OutTime.Value - a.LoginTime.Value;
                        table.Cell(i, 5).Range.Text = Convert.ToString(Diferent.Hours + ":" + Diferent.Minutes + ":" + Diferent.Seconds);
                    }
                    ReplaceWordSub("{Name}", Per.Name, doc);
                    ReplaceWordSub("{LastName}", Per.LastName, doc);
                    ReplaceWordSub("{MiddleName}", Per.MiddleName, doc);
                    ReplaceWordSub("{position}", Per.Position, doc);

                    doc.SaveAs(@"C:\Users\Developer\Desktop\1.docx");
                    doc.Close();

                }
            }
            catch
            {
                doc.Close();
                MessageBox.Show(" ! ");
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
