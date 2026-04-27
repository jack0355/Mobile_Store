using System;
using System.Data;
using Mobile_Store_DataAccess;

namespace Mobile_Store_Buisness
{
   
    public class ClsOrders
    {
        public enum enOrderStatus
        {
            Pending = 1,
            Shipped = 2,
            Cancelled = 3
        }
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int OrderID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal TotalAmount { get; set; }

        public enOrderStatus Status { get; set; }
        public ClsOrders()
        {
            this.OrderID = -1;
            this.CustomerName = "";
            this.CustomerPhone = "";
            this.CustomerAddress = "";
            this.OrderDate = DateTime.Now;
            this.TotalAmount = 0;
        }


      
        private ClsOrders(int orderID, string customerName, string customerPhone, string customerAddress,
                           DateTime orderDate, decimal totalAmount, byte Status)
        {
            this.OrderID = orderID;
            this.CustomerName = customerName;
            this.CustomerPhone = customerPhone; 
            this.CustomerAddress = customerAddress;
            this.OrderDate = orderDate;
            this.TotalAmount = totalAmount;
            this.Status = (enOrderStatus)Status;
            this.Mode = enMode.Update; 
        }

        public static ClsOrders Find(int OrderID)
        {
            string name = "", address = "", phone = "";
            DateTime date = DateTime.Now;
            decimal total = 0;
            byte status = 1;

         
            if (ClsOrderData.GetOrderInfoByID(OrderID, ref name, ref phone, ref address, ref date, ref total, ref status))
            {
                return new ClsOrders(OrderID, name, phone, address, date, total, status);
            }
            return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    this.OrderID = ClsOrderData.AddNewOrder(
                        this.CustomerName, this.CustomerPhone, this.CustomerAddress,
                        this.OrderDate, this.TotalAmount, (byte)this.Status);

                    if (this.OrderID != -1)
                    {
                        Mode = enMode.Update; // Switch mode after successful add
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return ClsOrderData.UpdateOrder(
                        this.OrderID, this.CustomerName, this.CustomerPhone, this.CustomerAddress,
                        this.OrderDate, this.TotalAmount, (byte)this.Status);
            }

            return false;
        }
        public static DataTable GetAllOrders()
        {
            return ClsOrderData.GetAllOrders();
        }

        public static bool DeleteOrders(int OrderID)
        {
            return ClsOrderData.DeleteOrder(OrderID);
        }

        public static DataTable GetCustomerOrders()
        {
            return ClsOrderData.GetCustomerOrders();
        }
    }
}