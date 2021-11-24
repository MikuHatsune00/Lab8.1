using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\kzyukina\\OneDrive - DAE\\Документы\\06_TEST";            
            string directoryName;
            string directoryName1;
            string fileName1;
           if (Directory.Exists(path))
            {
                directoryName = Path.GetFileName(path);
                Console.WriteLine("Папка {0} содержит:", directoryName);
                Console.WriteLine("Папки:");
                string[] dirs = Directory.GetDirectories(path);
                foreach (string s in dirs)
                {
                    directoryName1 = Path.GetFileName(s);
                    Console.WriteLine(directoryName1);
                }
                Console.WriteLine();
                Console.WriteLine("Файлы");
                string[] fileName = Directory.GetFiles(path);
                foreach (string s in fileName)
                {
                    fileName1 = Path.GetFileName(s);
                    Console.WriteLine(fileName1);
                }

                Console.WriteLine();
                string[] subdirectoryName = Directory.GetFiles(path,"*",SearchOption.AllDirectories);
                Console.WriteLine(String.Join(Environment.NewLine, subdirectoryName));

                Console.ReadKey();


            }
            
            

        }
    }
}

