using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WPFUIItems;
namespace TestStackLibraryWPF
{
    class ListBoxClass
    {
        // creating a list view obj
        ListBox ListBoxObj = null;

        //initailising the constructor
        public ListBoxClass(ListBox ListViewObj)
        {
            if (ListViewObj != null)
                this.ListBoxObj = ListViewObj;
        }


        //return no of items in list view
        public int GetCountOfItems()
        {

            //if object is not null get count
            if (ListBoxObj != null)
                return ListBoxObj.Items.Count;
            //else return 0
            return 0;
        }


        // when we set parameter value as index = 0, it means that when we leave it blank it will work
        // this function will click on child object by class name
        public void ClickChildItemByClass(int itemNo, String strClassName, int index = 0)
        {
            try
            {
                if (ListBoxObj != null && itemNo <= GetCountOfItems())
                {
                    ListBoxObj.Item(itemNo).Get(SearchCriteria.ByClassName(strClassName).AndIndex(index)).Click();
                }
            }
            catch (Exception e)
            {

            }
        }


        //getting list of textblock
        public ArrayList GetAllChildText(int itemNo)
        {
            ArrayList al = new ArrayList();
            try
            {
                if (ListBoxObj != null && itemNo <= GetCountOfItems())
                {
                    IUIItem[] allTextBlock = ListBoxObj.Item(itemNo).GetMultiple(SearchCriteria.ByClassName("TextBlock"));
                    foreach (IUIItem iUitem in allTextBlock)
                    {
                        al.Add(iUitem.Name);
                    }
                }
                return al;
            }
            catch (Exception e)
            {
                return al;
            }
        }

    }
}
