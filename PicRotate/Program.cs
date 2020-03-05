using System;
using System.IO;
using System.Threading.Tasks;

namespace PicRotate
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path;
                if (args.Length == 1)
                {
                    path = args[0];
                }
                else
                {
                    throw new ArgumentException("Ошибка: Программа должна быть запушена с одним параметром: путь к диррентории в которой она должна работать.");
                }

                if (!Directory.Exists(path))
                {
                    Console.WriteLine("Директории: " + path + " не существует.");
                }


                Console.WriteLine("Запуск программы в директории: " + path);
                string[] files = Directory.GetFiles(path, "*.bmp");
                Console.WriteLine("Найдено " + files.Length + " файлов формата bmp");
                Parallel.ForEach(files, RotateTools.Rotate);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.Write("Завершено! Для выхода нажмите любую клавишу...");
            Console.ReadKey();

        }
    }
}