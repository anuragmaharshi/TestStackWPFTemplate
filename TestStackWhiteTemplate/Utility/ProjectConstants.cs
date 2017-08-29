using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestStackWhiteTemplate
{
    class ProjectConstants
    {
        public static string BasePath = AppDomain.CurrentDomain.BaseDirectory;
        public static string PathTillBin = System.IO.Directory.GetParent(BasePath).Parent.Parent.FullName;//Path till Bin
        public static string PathReources = Path.Combine(PathTillBin, "Resources");
        public static string PathTestData = Path.GetFullPath(Path.Combine(PathReources, "TestData.xlsx"));

        public static string PathScreenShots = Path.Combine(PathTillBin, "ScreenShots" + Utility.GeneralUtility.GetDateTime());
        public static string ApplicationTitle = "";
    }
}
