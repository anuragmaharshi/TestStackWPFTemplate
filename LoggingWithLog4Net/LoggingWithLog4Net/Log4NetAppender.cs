using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;

namespace LoggingWithLog4Net
{
    public class Log4NetAppender
    {
        private static ILog _logger;
        static String LogPath;
        static Log4NetAppender()
        {
            try
            {
                LogPath = Constants.getStrLogPath();
                var logHierarchy = LogManager.GetRepository() as Hierarchy;
                var layout = new PatternLayout("%date - %level %message %n");
                layout.ActivateOptions();

                FileAppender appender = new FileAppender()
                {
                    Name = "TestLogger",
                    AppendToFile = true,
                    File = LogPath,
                    Layout = layout,
                };

                appender.ActivateOptions();
                logHierarchy.Root.AddAppender(appender);
                logHierarchy.Root.Level = Level.All;
                logHierarchy.Configured = true;
            }
            //if above fails , create logger in my documents
            catch(Exception e)
            {
                LogPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\TestOutput\\Log.txt";
                var logHierarchy = LogManager.GetRepository() as Hierarchy;
                var layout = new PatternLayout("%date - %level %message %n");
                layout.ActivateOptions();

                FileAppender appender = new FileAppender()
                {
                    Name = "TestLogger",
                    AppendToFile = true,
                    File = LogPath,
                    Layout = layout,
                };

                appender.ActivateOptions();
                logHierarchy.Root.AddAppender(appender);
                logHierarchy.Root.Level = Level.All;
                logHierarchy.Configured = true;
            }
          
            
        }

        public static ILog CreateLogger()
        {
            if (_logger == null)
            {
                _logger = LogManager.GetLogger("Logger");
                return _logger;
            }
            else
                return _logger;
        }
    }
}

