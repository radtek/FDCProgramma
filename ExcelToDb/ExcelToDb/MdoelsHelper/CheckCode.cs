using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace CheckCode.Code
{
    public class CheckCode
    {
        /// <summary>
        /// 图片中的随机码--小写
        /// </summary>
        private string _ImgCode = "";
        public string ImgCode
        {
            get { return _ImgCode; }
            set { _ImgCode = value; }
        }
        #region RndCodeImg
        /// <summary>
        /// 在本地生成验证码图片
        /// </summary>
        /// <param name="CodeLength">验证码中的字符个数</param>
        /// <param name="ImgWidth">图片宽</param>
        /// <param name="ImgHeight">图片长</param>
        public byte[] RndCodeImg(int CodeLength,int ImgWidth,int ImgHeight)
        {
            int intLength = CodeLength;               //长度
            Random RND = new Random();
            using (Bitmap bm = new Bitmap(ImgWidth, ImgHeight))
            {
                using (Graphics gArea = Graphics.FromImage(bm))
                {
                    using (SolidBrush sBrush = new SolidBrush(Color.FromArgb(141, 238, 238)))
                    {
                        gArea.FillRectangle(sBrush, 0, 0, bm.Width, bm.Height);
                        Font font = new Font(FontFamily.GenericSerif, 48, FontStyle.Bold, GraphicsUnit.Pixel);                        
                        StringBuilder sBuilder = new StringBuilder();
                        //合法随机显示字符列表
                        string strLetters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                        //将随机生成的字符串绘制到图片上
                        for (int i = 0; i < intLength; i++)
                        {
                            string CurrChar = strLetters.Substring(RND.Next(0, strLetters.Length - 1), 1);
                            gArea.DrawString(CurrChar, font, new SolidBrush(Color.Black), i * 38, RND.Next(0, 15));
                            sBuilder.Append(CurrChar); //保存输出的字符。
                        }
                        //生成干扰线条                        
                        for (int i = 0; i < 10; i++)
                        {
                            Color theC = Color.FromArgb(RND.Next(0, 255), RND.Next(0, 255), RND.Next(0, 255));
                            using (Pen pen = new Pen(new SolidBrush(theC), 2))
                            {
                                gArea.DrawLine(pen, new Point(RND.Next(0, bm.Width), RND.Next(0, bm.Height)), new Point(RND.Next(0, bm.Width), RND.Next(0, bm.Height)));
                            }
                        }
                        
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bm.Save(ms, ImageFormat.Gif);
                            //记录图片随机码
                            this.ImgCode = sBuilder.ToString().ToUpper();
                            return ms.ToArray();
                        }


                        
                    }
                }
            }
        }
        /// <summary>
        /// Convert Byte[] to Image
        /// </summary>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public  Image BytesToImage(byte[] buffer)
        {
            MemoryStream ms = new MemoryStream(buffer);
            Image image = System.Drawing.Image.FromStream(ms);
            return image;
        }
        /// <summary>
        /// Convert Byte[] to a picture and Store it in file
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="buffer"></param>
        /// <returns></returns>
        public  string CreateImageFromBytes(string fileName, byte[] buffer)
        {
            string file = fileName;
            Image image = BytesToImage(buffer);
            ImageFormat format = image.RawFormat;
            if (format.Equals(ImageFormat.Jpeg))
            {
                file += ".jpeg";
            }
            else if (format.Equals(ImageFormat.Png))
            {
                file += ".png";
            }
            else if (format.Equals(ImageFormat.Bmp))
            {
                file += ".bmp";
            }
            else if (format.Equals(ImageFormat.Gif))
            {
                file += ".gif";
            }
            else if (format.Equals(ImageFormat.Icon))
            {
                file += ".icon";
            }
            System.IO.FileInfo info = new System.IO.FileInfo(file);
            System.IO.Directory.CreateDirectory(info.Directory.FullName);
            File.WriteAllBytes(file, buffer);
            return file;
        }
        #endregion

    }
}