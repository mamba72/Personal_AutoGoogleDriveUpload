using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace FrameworkDriveUpload
{
    class FileLocator
    {
        static string picDirectoryPath;

        public static string getPicDirectoryPath()
        {
            return picDirectoryPath;
        }


        public static void CreateNewLocatorThread()
        {
            Thread locatorThread = new Thread(new ThreadStart(FindFiles));
        }

        private static void FindFiles()
        {
            try
            {
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
