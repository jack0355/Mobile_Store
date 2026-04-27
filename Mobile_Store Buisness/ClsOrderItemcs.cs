using System;
using System.Data;
using Mobile_Store_DataAccess;

namespace Mobile_Store_Buisness
{
    public class ClsOrderItem
    {
        public int OrderItemID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public ClsOrderItem()
        {
            this.OrderItemID = -1;
            this.OrderID = -1;
            this.ProductID = -1;
            this.ProductName = "";
            this.Quantity = 0;
            this.UnitPrice = 0;
            this.TotalPrice = 0;
        }

        public static DataTable GetItemsByOrderID(int OrderID)
        {
           
            return ClsOrderItemData.GetItemsByOrderID(OrderID);
        }

        public bool Save()
        {
           
            return ClsOrderItemData.AddNewOrderItem(this.OrderID, this.ProductID, this.ProductName, this.Quantity, this.UnitPrice, this.TotalPrice);
        }
    }
}