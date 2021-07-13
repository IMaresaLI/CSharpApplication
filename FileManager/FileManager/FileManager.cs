using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileManager
{
    public class FileManager
    {
        public List<string> GetAllDirectory(string path, string search,string FileExtention="GetAll")
        {
            List<string> FileRepo = new List<string> { };

            try
            {
                if (search == "Search")
                {
                    string rootPath = (path);
                    string[] dirs = { };

                    dirs = Directory.GetDirectories(rootPath, "*");

                    foreach (string dir in dirs)
                    {
                        if (FileExtention == "GetAll")
                        {
                            foreach (var item in Directory.GetFiles(dir, "*", SearchOption.AllDirectories))
                            {
                                FileRepo.Add(item);
                            }
                        }
                        else
                        {
                            foreach (var item in Directory.GetFiles(dir, $"*{FileExtention}", SearchOption.AllDirectories))
                            {
                                FileRepo.Add(item);
                            }
                        }
                    }
                }else
                {
                    string rootPath = (path);
                    string[] dirs = { };
                    if (FileExtention != "GetAll")
                    {
                        dirs = Directory.GetDirectories(rootPath, "*");

                        foreach (string dir in dirs)
                        {
                            foreach (var item in Directory.GetFiles(dir, $"{search}{FileExtention}", SearchOption.AllDirectories))
                            {
                                FileRepo.Add(item);
                            }
                        }

                    }else
                    {
                        dirs = Directory.GetDirectories(rootPath, "*");

                        foreach (string dir in dirs)
                        {
                            foreach (var item in Directory.GetFiles(dir, $"{search}*", SearchOption.AllDirectories))
                            {
                                FileRepo.Add(item);
                            }
                        }

                    }

                }
            }
            catch (Exception)
            {
            }
            return FileRepo;
        }



        //string[] dirs = Directory.GetDirectories(rootPath,"*",SearchOption.AllDirectories);

        //foreach (string dir in dirs)
        //{
        //    Console.WriteLine(dir);
        //}

        //var files = Directory.GetFiles(rootPath, "*.py", SearchOption.AllDirectories);

        //foreach (string file in files)
        //{
        //    //Console.WriteLine(file);
        //    //Console.WriteLine(Path.GetFileName(file));
        //    //Console.WriteLine(Path.GetFullPath(file));
        //    var info = new FileInfo(file);


        //    Console.WriteLine($"{Path.GetFileName(file)} : {info.Length} bytes");
        //}
        //string newPath = @"E:\Programlama\Programs\chatApp\chhha";
        //bool directoryExists = Directory.Exists(newPath);

        //if (directoryExists)
        //{
        //    Console.WriteLine("The Directory exists");
        //    Directory.Delete(newPath);
        //    Console.WriteLine($"{newPath} Klasörü Silindi.");
        //}
        //else
        //{
        //    Console.WriteLine("The Directory does not exists");
        //    Directory.CreateDirectory(newPath);
        //    Console.WriteLine($"{newPath} Klasörü oluşturuldu.");
        //}

    }

}
