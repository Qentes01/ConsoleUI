using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            string rootPath = @"C:\Users\opilane\source\repos\TiTpe21\Demos\FileSystem";

            //string[] dirs = Directory.GetDirectories(rootPath,"*",SearchOption.AllDirectories);

            //foreach (string dir in dirs)
            // {
            //    Console.WriteLine(dir);
            // }

            //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

            //foreach (string file in files)
            // {
            //Console.WriteLine(file);
            //Console.WriteLine(Path.GetFileName(file));
            //Console.WriteLine(Path.GetFileNameWithoutExtension(file));
            //Console.WriteLine(Path.GetDirectoryName(file));
            //var info = new FileInfo(file);

            //Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");

            //  }

            //string newPath = @"C:\Users\opilane\source\repos\TiTpe21\Demos\FileSystem\SubFolderC\SubSubFolderD";
            //Directory.CreateDirectory(newPath);

            //bool directoryExists = Directory.Exists(newPath);

            //if (directoryExists)
            //{
            //    Console.WriteLine("The Directory exists");
            //}
            //else
            //{
            //    Console.WriteLine("The directory does not exist");
            //    Directory.CreateDirectory(newPath);
            //}

            //string[] files = Directory.GetFiles(rootPath);
            //string destinationFolder = @"C:\Users\opilane\source\repos\TiTpe21\Demos\FileSystem\SubFolderA";

            //foreach (string file in files)
            //{
            //    File.Copy(file, $"{destinationFolder}{Path.GetFileName(file) }", true);
            //}
            //for (int i = 0; i < Files.length; i++)
            //{
            //    File.Copy(files[i], $"{destinationFolder}{ i }.txt", true);
            //}
            //foreach (string file in files)
            //{
            //    File.Move(file, $"{destinationFolder}{Path.GetFileName(file) }", true);
            //}


            var files = Directory.GetFiles(rootPath, "*folder*.*", SearchOption.AllDirectories);

            foreach (string file in files)
            {
                Console.WriteLine(file);
                Console.WriteLine(Path.GetFileName(file));
                Console.WriteLine(Path.GetFileNameWithoutExtension(file));
                Console.WriteLine(Path.GetDirectoryName(file));
                var info = new FileInfo(file);

                Console.WriteLine($"{Path.GetFileName(file)}: {info.Length} bytes");

            }



            Console.ReadLine();


        }
    }
}
