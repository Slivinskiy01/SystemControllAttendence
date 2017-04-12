using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemControllAttendence.Properties;

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
    }
}
