using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace LoggingWithLog4Net
{
    public class Constants
    {
        //If passed log path fails then keep logs in My documents test output folder
        private static String strLogPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TestOutput\\Log.txt";

        //Setting log path at runtime.
        public static void setStrLogPath(String strPath)
        {
            //not working .. just for refernce keeping it here
            //String str = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;string startupPath = System.IO.Path.GetFullPath(".\\");string startupPath1 = System.IO.Directory.GetParent(@"./").FullName;
            //string startupPath2 = Environment.CurrentDirectory;string path = Path.GetDirectoryName(Assembly.GetAssembly(typeof(Constants)).FullName);
            try
            {
                String s= System.IO.Path.GetFullPath(strPath);
                strLogPath = strPath;
            }
            catch (Exception e)
            {
               
            }
            
        }

        public static String getStrLogPath()
        {
            return strLogPath;
        }
    }

}
