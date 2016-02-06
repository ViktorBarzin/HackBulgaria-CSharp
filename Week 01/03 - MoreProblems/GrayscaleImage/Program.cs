namespace GrayscaleImage
{
    using System.Drawing;

    /// <summary>
    /// Make a program which loads a bitmap into memory, converts it to a grayscale image and then saves it to a file.
    /// void GreyScaleImage(Bitmap bitmap, string savePath).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Applies a greyscale filter to a bitmap image.
        /// </summary>
        /// <param name="bmp">Bitmap image.</param>
        /// <param name="savePath">String save path.</param>
        public static void GreyScaleImage(Bitmap bmp, string savePath)
        {
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int k = 0; k < bmp.Height; k++)
                {
                    Color pixel = bmp.GetPixel(i, k);
                    byte gray = (byte)((pixel.G * 0.33) + (pixel.B * 0.33) + (pixel.R * 0.33));
                    Color newPixel = Color.FromArgb(gray, gray, gray);
                    bmp.SetPixel(i, k, newPixel);
                }
            }

            bmp.Save(savePath);
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Bitmap bmp = (Bitmap)Image.FromFile("linux_inside.bmp");
            GreyScaleImage(bmp, "newLinux.bmp");
        }
    }
}
