using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.WindowItems;

namespace TestStackLibraryWPF
{
    public class ApplicationUtility
    {
        private static Application app = null;
        private static Window window = null;

        //assumption it should be called only once 
        public static void LaunchApplication(string AppPath,string AppName)
        {
            try
            {
                app = Application.Launch(AppPath);
                window = app.GetWindow(AppName, InitializeOption.NoCache);
                StaticGetObjects.Initialize(window);
                StaticOperations.Initialise(window);

            }
            catch (Exception e) { }
           
        }

        public static Window GetWindowInstance()
        {
            return window;
        }

        public static void Close()
        {
            try
            {
                window.Close();
                app.Close();
            }
            catch (Exception e) { }
            
        }
    }
}
