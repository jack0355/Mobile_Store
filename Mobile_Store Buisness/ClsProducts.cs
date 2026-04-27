using Mobile_Store_Data_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mobile_Store_Buisness
{
    public  class ClsProducts
    {
        enum enMode { AddNew = 0 , Update =1 }
        enMode _Mode = enMode.AddNew;
        public int ProductID { get; set; }
        public int BrandID { get; set; }
        public int CategoryID { get; set; }
        public string ProductName { get; set; }

        public decimal Price { get; set; }
        public string ImageURL {  get; set; }

        public string Description {  get; set; }

        public bool IsAvailable {  get; set; }

        public ClsProducts()
        {
            _Mode = enMode.AddNew;
            ProductID = -1;
            BrandID = -1;
            CategoryID = -1;
            ProductName = "";
            Price = 0;
            Description = "";
            ImageURL = "";
            IsAvailable = false;

            
        }
        private ClsProducts(int productID, int brandID, int categoryID,
                    string productName, decimal price,
                    string imageURL, string description, bool isAvailable)
        {
            ProductID = productID;
            BrandID = brandID;
            CategoryID = categoryID;
            ProductName = productName;
            Price = price;
            ImageURL = imageURL;
            Description = description;
            IsAvailable=isAvailable ;

            _Mode = enMode.Update;

        }

        private bool AddNewPhone()
        {
            this.ProductID = ClsProductsData.AddNewPhone(this.BrandID, this.CategoryID, this.ProductName, this.Price, this.ImageURL, this.Description, this.IsAvailable);

            return (ProductID != -1);
        }
        public static bool IsPhoneExist(string ProductName)
        {
            return GetPhoneByName(ProductName) != null;
        }
        private bool UpdatePhone()
        {
            return ClsProductsData.UpdatePhone(this.ProductID   ,this.BrandID, this.CategoryID, this.ProductName, this.Price, this.ImageURL, this.Description, this.IsAvailable);
        }

       public static  bool DeletePhone(int ProductID)
       {
            return ClsProductsData.DeletePhone(ProductID);
       }

        public static ClsProducts GetPhoneByID(int ProductID)
        {
            int BrandID = -1 , CategoryID = -1 ;
            string ProductName = "", ImageURL = "", Description = "";
            decimal Price = 0 ;
            bool isAvailable = false;
            bool isFound =  ClsProductsData.GetThePhoneByProductID(ProductID, ref ProductName, ref BrandID, ref CategoryID, ref Price,
                                                                           ref ImageURL, ref Description, ref isAvailable);


            if(isFound)
{
                return new ClsProducts(ProductID, BrandID, CategoryID, ProductName,
                                       Price, ImageURL, Description, isAvailable);
            }
            else
            {
                return null;
            }

        }

        public static ClsProducts GetPhoneByName(string  ProductName)
        {
            int ProductID = -1;
            int BrandID = -1, CategoryID = -1;
            string ImageURL = "", Description = "";
            decimal Price = 0;
            bool isAvailable = false;

            bool isFound = ClsProductsData.GetThePhoneByName(ProductName, ref ProductID, ref BrandID, ref CategoryID, ref Price,
                                                                           ref ImageURL, ref Description, ref isAvailable);
            if(isFound)
            {
                return new ClsProducts(ProductID, BrandID , CategoryID , ProductName , Price, ImageURL,Description, isAvailable);
            }
            else
            {
                return null;
            }

        }

        public static DataTable GetAllPhones()
        {
            return ClsProductsData.GetAllThePhoneProducts();
        }
        public static bool IsPhoneExist(int ProductID)
        {
            return GetPhoneByID(ProductID) != null;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (AddNewPhone())
                    {
                        _Mode = enMode.Update;
                        return true;

                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:
                    return UpdatePhone();

            }
            return false;
        }

    }
}
