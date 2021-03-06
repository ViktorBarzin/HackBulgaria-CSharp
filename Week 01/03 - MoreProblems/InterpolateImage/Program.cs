﻿namespace InterpolateImage
{
    using System;
    using System.Drawing;

    /// <summary>
    /// Make a program which loads a bitmap into memory, then rescales it into a new bitmap
    /// using the nearest <![CDATA[neighbour]]> interpolation.
    /// void ResampleImage(Bitmap bitmap, Size newSize, string savePath).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Resizes a bitmap image.
        /// </summary>
        /// <param name="bitmap">Bitmap image to be resized.</param>
        /// <param name="newSize">New Size of the bitmap image.</param>
        /// <param name="savePath">String save path.</param>
        public static void ResampleImage(Bitmap bitmap, Size newSize, string savePath)
        {
            Bitmap newPic = new Bitmap(newSize.Width, newSize.Height);
            float ratioW = (float)(newSize.Width - 1) / (bitmap.Width - 1);
            float ratioH = (float)(newSize.Height - 1) / (bitmap.Height - 1);
            for (int i = 0; i < newPic.Width; i++)
            {
                for (int k = 0; k < newPic.Height; k++)
                {
                    Color pixel = bitmap.GetPixel((int)Math.Round(i / ratioW), (int)Math.Round(k / ratioH));
                    newPic.SetPixel(i, k, pixel);
                }
            }

            newPic.Save(savePath);
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Bitmap bmp = (Bitmap)Image.FromFile("linux_inside.bmp");
            Size size = new Size(1000, 500);
            ResampleImage(bmp, size, "rescaled_linux.bmp");
        }
    }
}
