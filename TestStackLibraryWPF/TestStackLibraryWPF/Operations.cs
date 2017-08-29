using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;
namespace TestStackLibraryWPF

{
    class Operations
    {
        Window window = null;
        GetObjectFromScreen objIUiItem = null;
        //initialising with constructor
        public Operations(Window window)
        {
            this.window = window;
            objIUiItem = new GetObjectFromScreen(window);
        }

        public void ClickOnObject(SearchCriteria objectName)
        {
            try
            {
                IUIItem obj = objIUiItem.GetObject(objectName);
                if (obj != null)
                    obj.Click();
            }
            catch (Exception e)
            {

            }

        }

        public void SetTextInTextbox(SearchCriteria scrObject, String Text)
        {
            try
            {

                TextBox txtObject = objIUiItem.GetTextBox(scrObject);
                if (txtObject != null)
                    //txtprofile.ClickAtCenter();
                    txtObject.BulkText = Text;
                txtObject.ClickAtCenter();
            }
            catch (Exception e)
            {

            }
        }
        public void SetValueInComboBox(SearchCriteria scrObject, String Text)
        {
            try
            {
                ComboBox cbxObject = objIUiItem.GetComboBox(scrObject);
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
