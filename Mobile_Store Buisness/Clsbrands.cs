using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Mobile_Store_Data_Access;

namespace Mobile_Store_Buisness
{
    public class Clsbrands
    {
        public int _BrandID { get; set; }

        public string BrandName { get; set; }

        public string LogoURL { get; set; }

       public Clsbrands() 
        
        {
            _BrandID = -1;
            BrandName = "";
            LogoURL = "";

        }

        private Clsbrands(int BrandID , string BrandName ,  string LogoURL)
        {
            this._BrandID = BrandID;
            this.BrandName = BrandName;
            this.LogoURL = LogoURL;

        }


       public static Clsbrands  GetbrandById(int BrandID)
        {
            string BrandName = ""; string LogoURL = "";
            if(ClsBrandsAccess.GetBrandsByID(BrandID , ref BrandName , ref LogoURL))
            {
                return new Clsbrands(BrandID, BrandName, LogoURL);
            }
            else
            {
                return null;
            }
       }

        public  static  Clsbrands GetBrandByName(string BrandName)
        {
            int BrandID = -1; string LogoURL = "";
            if (ClsBrandsAccess.GetBrandByName(BrandName, ref BrandID, ref LogoURL))
            {
                return new Clsbrands(BrandID, BrandName, LogoURL);


            }
            else
            {
                return null;
            }

        }

        public static DataTable GetAllBrands()
        {
            return ClsBrandsAccess.GetAllBrands();
        }

    }
}
