/*
Make a program which loads a bitmap into memory, converts it to a grayscale image and then saves it to a file.

void GreyScaleImage(Bitmap bitmap, string savePath)
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GrayscaleImage
{
    class Program
    {
        public static void GreyScaleImage(Bitmap bmp, string savePath)
        {
            
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int k = 0; k < bmp.Height; k++)
                {
                    Color pixel = bmp.GetPixel(i, k);
                    byte gray = (byte)(pixel.G * 0.33 + pixel.B * 0.33 + pixel.R * 0.33);
                    Color newPixel = Color.FromArgb(gray,gray,gray);
                    bmp.SetPixel(i, k, newPixel);
                }
            }
            bmp.Save(savePath);
        }
        static void Main(string[] args)
        {
            Bitmap bmp = (Bitmap)Image.FromFile("linux_inside.bmp");
            GreyScaleImage(bmp, "newLinux.bmp");

        }
    }
}
