using System;
using System.IO;

namespace streamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"C:\Users\Emanuel\OneDrive - Universidade Federal do Rio Grande do Sul\Cources and others\C#\Text\File1.txt";
            string targetpath = @"C:\Users\Emanuel\OneDrive - Universidade Federal do Rio Grande do Sul\Cources and others\C#\Text\File2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcepath);

                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
