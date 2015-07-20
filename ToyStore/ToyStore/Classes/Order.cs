using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToyStore.Classes
{
    public class Order 
    {
/*
            #region Properties

            public List<CartItem> Items { get; private set; }

            #endregion

            #region Singleton Implementation



            // Readonly properties can only be set in initialization or in a constructor
            public static readonly Order Instance;

            // The static constructor is called as soon as the class is loaded into memory
            static Order()
            {
                // If the cart is not in the session, create one and put it there
                // Otherwise, get it from the session
                if (HttpContext.Current.Session["ASPNETShoppingCart"] == null)
                {
                    Instance = new Order();
                    Instance.Items = new List<CartItem>();
                    HttpContext.Current.Session["ASPNETShoppingCart"] = Instance;
                }
                else
                {
                    Instance = (Order)HttpContext.Current.Session["ASPNETShoppingCart"];
                }
            }

            // A protected constructor ensures that an object can't be created from outside
            protected Order() { }

                     /**
     * GetSubTotal() - returns the total price of all of the items
     *                 before tax, shipping, etc.
     
            public decimal GetSubTotal()
            {
                decimal subTotal = 0;
                foreach (CartItem item in Items)
                    subTotal += item.TotalPrice;

                return subTotal;
            }*/

    }

    }
