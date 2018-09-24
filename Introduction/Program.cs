using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows";
            //ShowLargeFilesWithoutLINQ(path);
            ShowLargeFilesWithLINQ(path);
        }

        private static void ShowLargeFilesWithLINQ(string path)
        {
            // Method Syntax - LINQ
            var query = new DirectoryInfo(path).GetFiles()
                        .OrderByDescending(f => f.Length)
                        .Take(5);

            // Query Syntax - LINQ
            var query2 = from file in new DirectoryInfo(path).GetFiles()
                         where file.Name.ToUpper().StartsWith("N")
                         orderby file.Length descending
                         select file;

            foreach (var file in query2.Take(5))
            {
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N0}");
            }
        }

        private static void ShowLargeFilesWithoutLINQ(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            FileInfo[] files = directory.GetFiles();
            Array.Sort(files, new FileInfoComparerOnLength());
            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name,-20} : {file.Length,10:N0}");
            }

        }
    }

    public class FileInfoComparerOnLength : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            return y.Length.CompareTo(x.Length);
        }
    }
}
