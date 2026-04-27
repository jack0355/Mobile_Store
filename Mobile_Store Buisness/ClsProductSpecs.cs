using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mobile_Store_Data_Access;

namespace Mobile_Store_Buisness
{
    public class ClsProductSpecs
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int SpecID { get; set; }
        public int ProductID { get; set; }
        public string Storage { get; set; }
        public string Ram { get; set; }
        public string ScreenSize { get; set; }
        public string Battery { get; set; }
        public string Color { get; set; }
        public string OS { get; set; }

        public ClsProductSpecs()
        {
            SpecID = -1;
            ProductID = -1;
            Storage = "";
            Ram = "";
            ScreenSize = "";
            Battery = "";
            Color = "";
            OS = "";
            _Mode = enMode.AddNew;
        }

        private ClsProductSpecs(int specID, int productID, string storage,
                                string ram, string screenSize, string battery,
                                string color, string os)
        {
            SpecID = specID;
            ProductID = productID;
            Storage = storage;
            Ram = ram;
            ScreenSize = screenSize;
            Battery = battery;
            Color = color;
            OS = os;
            _Mode = enMode.Update;
        }

        private bool AddNewProduct_Spec()
        {
            this.SpecID = ClsProductSpecsData.AddProduct_Specs(
                          this.ProductID, this.Storage, this.Ram,
                          this.ScreenSize, this.Battery, this.Color, this.OS);
            return (SpecID != -1);
        }

        private bool UpdateProduct_Specs()
        {
            return ClsProductSpecsData.UpdateProduct_Spec(
                   this.SpecID, this.ProductID, this.Storage, this.Ram,
                   this.ScreenSize, this.Battery, this.Color, this.OS);
        }

        public static bool DeleteProduct_Specs(int SpecID)
        {
            return ClsProductSpecsData.DeleteProduct_Specs(SpecID);
        }

        public static ClsProductSpecs GetSpecsByProductID(int ProductID)
        {
            int SpecID = -1;
            string Storage = "", Ram = "", ScreenSize = "",
                   Battery = "", Color = "", OS = "";

            bool isFound = ClsProductSpecsData.GetProduct_SpecsByID(
                           ProductID, ref SpecID, ref Storage, ref Ram,
                           ref ScreenSize, ref Battery, ref Color, ref OS);
            if (isFound)
                return new ClsProductSpecs(SpecID, ProductID, Storage, Ram,
                                           ScreenSize, Battery, Color, OS);
            else
                return null;
        }

        public static bool IsSpecExist(int ProductID)
        {
            return GetSpecsByProductID(ProductID) != null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (AddNewProduct_Spec())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return UpdateProduct_Specs();
            }
            return false;
        }
    }
}