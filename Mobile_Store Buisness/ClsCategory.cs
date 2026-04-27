using Mobile_Store_Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Store_Buisness
{
    public class ClsCategory
    {
        public int _CategoryID { get; set; }
        public string _CategoryName { get; set; }

        public ClsCategory()
        {
            _CategoryID = -1;
            _CategoryName = "";
        }

        public ClsCategory(int _CategoryID, string _CategoryName)
        {
            this._CategoryID = _CategoryID;
            this._CategoryName = _CategoryName;
        }

        public static ClsCategory GetCategoryByID(int CategoryID)
        {
            string CategoryName = "";
            bool isFound = ClsCategorData.GetCategoryByID(CategoryID, ref CategoryName);

            if (isFound)
                return new ClsCategory(CategoryID, CategoryName);
            else
                return null;
        }

        public static ClsCategory GetCategoryByName(string CategoryName)
        {
            int CategoryID = -1;

            bool isFound = ClsCategorData.GetCategoryBYName(CategoryName, ref CategoryID);

            if(isFound)
            {
                return new ClsCategory(CategoryID , CategoryName);

            }
            else
            {
                return null;
            }
        }


        public static DataTable GetAllCategories()
        {
            return ClsCategorData.GetAllCategories();   
        }

    }
}
