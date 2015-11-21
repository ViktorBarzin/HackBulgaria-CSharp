using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InterpolateImage
{
    class Program
    {
        public static void ResampleImage(Bitmap bitmap, Size newSize, string savePath)
        {
            Bitmap newPic = new Bitmap(newSize.Width, newSize.Height);
            float ratioW = (float)(newSize.Width - 1) / (bitmap.Width - 1);
            float ratioH = (float)(newSize.Height - 1) / (bitmap.Height - 1);
            for (int i = 0; i < newPic.Width; i++)
            {
                for (int k = 0; k < newPic.Height; k++)
                {
                    Color pixel = bitmap.GetPixel((int)Math.Round((float)i / ratioW),
                        (int)Math.Round((float)k / ratioH));
                    newPic.SetPixel(i, k, pixel);
                }
            }
            newPic.Save(savePath);
        }
        static void Main(string[] args)
        {
            Bitmap bmp = (Bitmap)Image.FromFile("linux_inside.bmp");
            Size size = new Size(1000, 500);
            ResampleImage(bmp, size, "rescaled_linux.bmp");
        }
    }
}
