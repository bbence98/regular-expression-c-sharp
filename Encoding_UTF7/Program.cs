using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Encoding_UTF7
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileName = @"D:\Documents\Codecool\.NET module\SI weeks\Regular Expression\";
            StreamReader stRead = new StreamReader(FileName + ".gitignore");

            StreamWriter stWrite = new StreamWriter(FileName + ".gitignore_utf7.txt", false, Encoding.UTF7);

            string line;
            while ((line = stRead.ReadLine()) != null)
            {
                stWrite.WriteLine(line);
            }
            Console.WriteLine("File had been encoded to: " + FileName + ".gitignore_utf7.txt");
            stWrite.Close();
            
            Console.ReadKey();
        }
    }
}
