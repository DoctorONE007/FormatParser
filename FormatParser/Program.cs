using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatParser
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                string PathToFolder = "";
                string[] allfiles = Directory.GetFiles(PathToFolder);

                FileProcessor fp = new FileProcessor();

                foreach (string filename in allfiles)
                {
                    fp.ProcessFile(filename);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The process failed: {0}", e.ToString());
            }
            Console.ReadKey();
        }
    }
}
