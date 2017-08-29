using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace LoggingWithLog4Net
{
    public class StaticLogger
    {
        static ILog log = null;
        //at start of program need to initailize it. Call this function
        public static void Setup(String strLogPath)
        {
            Constants.setStrLogPath(strLogPath);
            log = Log4NetAppender.CreateLogger();
        }
        // appender created in my documents.
        public static void Setup()
        {
            
            log = Log4NetAppender.CreateLogger();
        }
        //Call this Static function from any file. This will log 
        //info message
        public static void LogInfoMessage(String strMessage)
        {
            //initailise logger if null. This will set up in logger in default location
            if(log == null)
                log = Log4NetAppender.CreateLogger();

   
             log.Info(strMessage);
        }

        //error message
        public static void LogErrorMessage(String strMessage)
        {
            //initailise logger if null. This will set up in logger in default location
            if (log == null)
                log = Log4NetAppender.CreateLogger();
      
             log.Error(strMessage);
        }
    }
}
