using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;

namespace TestStackLibraryWPF
{
    class StaticOperations
    {
        private static Window window = null;
    
        //initialising with constructor
        public static void Initialise(Window windowInstance)
        {
            window = windowInstance;   
        }

        public static void ClickOnObject(SearchCriteria objectName)
        {
            try
            {
                IUIItem obj = StaticGetObjects.GetObject(objectName);
                if (obj != null)
                    obj.Click();
            }
            catch (Exception e)
            {

            }

        }

        public static void SetTextInTextbox(SearchCriteria scrObject, String Text)
        {
            try
            {

                TextBox txtObject = StaticGetObjects.GetTextBox(scrObject);
                if (txtObject != null)
                    //txtprofile.ClickAtCenter();
                    txtObject.BulkText = Text;
                txtObject.ClickAtCenter();
            }
            catch (Exception e)
            {

            }
        }
        public static void SetValueInComboBox(SearchCriteria scrObject, String Text)
        {
            try
            {
                ComboBox cbxObject = StaticGetObjects.GetComboBox(scrObject);
                if (cbxObject != null)
                {
                    cbxObject.Select(Text);
                }
            }
            catch (Exception e)
            {

            }
        }
    }


}

