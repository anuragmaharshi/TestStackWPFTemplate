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
    class StaticGetObjects
    {
        private static Window window = null;

        //initialising with constructor
        public static void Initialize(Window windowInstance)
        {
            window = windowInstance;
        }


        //this function return IUItem object if obect is found
        //else it returns null

        public static IUIItem GetObject(SearchCriteria searchCriteria)
        {
            try
            {
                if (window.Exists(searchCriteria))
                {
                    return window.Get(searchCriteria);
                }
            }
            catch (Exception e)
            {
                return null;
            }

            return null;
        }


        public static Button GetButton(SearchCriteria searchCriteria)
        {
            try
            {
                return (Button)GetObject(searchCriteria);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static TextBox GetTextBox(SearchCriteria searchCriteria)
        {
            try
            {
                return (TextBox)GetObject(searchCriteria);
            }
            catch (Exception e)
            {
                return null;
            }

        }

        public static ListBox GetListView(SearchCriteria searchCriteria)
        {
            try
            {
                return (ListBox)GetObject(searchCriteria);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static ComboBox GetComboBox(SearchCriteria searchCriteria)
        {
            try
            {
                return (ComboBox)GetObject(searchCriteria);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}

   

