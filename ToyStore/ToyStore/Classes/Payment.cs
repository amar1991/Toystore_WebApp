using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToyStore.Classes
{
    public class Payment : Invoice , Delivery, Notification
    {
        int PaymentID;
        double TotalPayment;
        String PaymentDetails;
        String Payment_Type;

        public void Get_OrderList() 
        {

        }

        public void Create_Reciept()
        {

        }

        public void Calculate_Total_Vat() 
        {

        }

        public void Get_Customer()
        {

        }

        public void Get_Shipment()
        {

        }
    }
}