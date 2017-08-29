using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStackWhiteTemplate.Utility
{
    class GeneralUtility
    {
        public static String GetDateTime()
        {
            String strDateTime = DateTime.Now.Year.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Day.ToString() + "_" + DateTime.Now.Hour.ToString()  +"-"+ DateTime.Now.Minute.ToString() + "-" + DateTime.Now.Second.ToString();
            return strDateTime;
        }

        public static void CreateFolder(String pathString)
        {
            System.IO.Directory.CreateDirectory(pathString);
        }
    }
}