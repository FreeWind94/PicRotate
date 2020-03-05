using System;
using System.Drawing;

namespace PicRotate
{
    class RotateTools
    {
        static public void Rotate(string imagePath)
        {
            try
            {
                Bitmap image = new Bitmap(imagePath, true);
                image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                Console.WriteLine("Поворот изображения: " + imagePath);
                string imageNewPath = imagePath.Replace(".bmp", "_rotaded.bmp");
                image.Save(imageNewPath, System.Drawing.Imaging.ImageFormat.Bmp);
                Console.WriteLine("Изображение: " + imagePath + " успешно повёрнуто и сохранено как: " + imageNewPath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
