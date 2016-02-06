namespace ApplyALinearFilterToAnImage
{
    using System.Drawing;

    /// <summary>
    /// Make a program which loads a bitmap into memory, then applies a linear filter and saves it into a new file.
    /// You can use the Box Blur Filter
    /// void BlurImage(Bitmap bitmap, string savePath).
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Blurs an image with a specified amount.
        /// </summary>
        /// <param name="image">Bitmap image.</param>
        /// <param name="blurSize">Integer amount.</param>
        /// <returns>Returns a new bitmap image.</returns>
        public static Bitmap Blur(Bitmap image, int blurSize)
        {
            Bitmap blurred = new Bitmap(image.Width, image.Height);
            Rectangle rectangle = new Rectangle(0, 0, image.Width, image.Height);
            using (Graphics graphics = Graphics.FromImage(blurred))
            {
                graphics.DrawImage(image, new Rectangle(0, 0, image.Width, image.Height), new Rectangle(0, 0, image.Width, image.Height), GraphicsUnit.Pixel);
            }

            for (int xx = rectangle.X; xx < rectangle.X + rectangle.Width; xx++)
            {
                for (int yy = rectangle.Y; yy < rectangle.Y + rectangle.Height; yy++)
                {
                    int avgR = 0, avgG = 0, avgB = 0;
                    int blurPixelCount = 0;
                    for (int x = xx; x < xx + blurSize && x < image.Width; x++)
                    {
                        for (int y = yy; y < yy + blurSize && y < image.Height; y++)
                        {
                            Color pixel = blurred.GetPixel(x, y);

                            avgR += pixel.R;
                            avgG += pixel.G;
                            avgB += pixel.B;

                            blurPixelCount++;
                        }
                    }

                    avgR = avgR / blurPixelCount;
                    avgG = avgG / blurPixelCount;
                    avgB = avgB / blurPixelCount;
                    for (int x = xx; x < xx + blurSize && x < image.Width && x < rectangle.Width; x++)
                    {
                        for (int y = yy; y < yy + blurSize && y < image.Height && y < rectangle.Height; y++)
                        {
                            blurred.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                        }
                    }
                }
            }

            blurred.Save("blurred_linux.bmp");
            return blurred;
        }

        /// <summary>
        /// Main Method.
        /// </summary>
        public static void Main()
        {
            Bitmap image = (Bitmap)Image.FromFile("linux_inside.bmp");
            Blur(image, 5);
        }
    }
}
