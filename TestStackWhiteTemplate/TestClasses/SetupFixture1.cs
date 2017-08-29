using NUnit.Framework;
using System;
using LoggingWithLog4Net;
using ExcelWithNPOI;
using TestStackLibraryWPF;
using System.IO;

namespace TestStackWhiteTemplate
{
    [SetUpFixture]
    public class SetupFixture1
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            
            //Getting application name from excel
            ExcelRead ExcelObj = new ExcelRead(@ProjectConstants.PathTestData, "Configuration");
            var Config = ExcelObj.GetColumenDataInDict(1);
            ExcelObj.CloseAllConnection();

            //Getting path from excel where logs will be kept.
            string LogPath = Config["TestOutputDirectoryPath"];
            //Creating folder with timeStamp
            string getCurrentTimeStamp = Utility.GeneralUtility.GetDateTime();
            LogPath = Path.Combine(LogPath,  "Log-" + getCurrentTimeStamp);
            Utility.GeneralUtility.CreateFolder(@LogPath);
            StaticLogger.Setup(Path.Combine(LogPath, "Log.txt"));

            //creating folder for screenshots
            ProjectConstants.PathScreenShots = @Path.Combine(LogPath, "Screenshots");
            Utility.GeneralUtility.CreateFolder(@ProjectConstants.PathScreenShots);
            
            //Initializing application
            ApplicationUtility.LaunchApplication(@Path.Combine(Config["ApplicationPath"], Config["ApplicationName"]), ProjectConstants.ApplicationTitle);

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // TODO: Add code here that is run after
            //  all tests in the assembly have been run
            ApplicationUtility.Close();
            StaticLogger.LogInfoMessage("Closing application");
        }
    }
}