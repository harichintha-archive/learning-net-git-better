using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace PreparationForBest
{
    class RecursiveExample
    {
       
       public static void FindFile(string path)
        {
            try
            {
                foreach (string fileName in Directory.GetFiles(path))
                {
                    Console.WriteLine(fileName);
                }
                foreach (string FolderName in Directory.GetDirectories(path))
                {
                    FindFile(FolderName);
                }
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.TargetSite); 

            }
           
        }
    }
}
