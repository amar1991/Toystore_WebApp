using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToyStore.Classes;

namespace ToyStore
{
    public partial class CompleteOrder : System.Web.UI.Page
    {
        List<string> myList;
        List<string> myListS;
        DataTable myListOrders;
        DatabaseConnection lemon = new DatabaseConnection();
        Double TotalPrice;
        string[] saveorder = new string[6];

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ShippingSession"] == null)
            {
                myList = new List<string>();
                Session["ShippingSession"] = myList;
            }
            else
            {
                myList = (List<string>)Session["ShippingSession"];
            }

            if (this.Master.Session["cartSession"] == null)
            {
                myListS = new List<string>();
                this.Master.Session["cartSession"] = myListS;
            }
            else
            {
                myListS = (List<string>)Session["cartSession"];
            }

            if (Session["OrderSession"] == null)
            {
                myListOrders = new DataTable();
                Session["OrderSession"] = myListOrders;
            }
            else
            {
                myListOrders = (DataTable) Session["OrderSession"];
            }

            if (Session["TotalSession"] == null)
            {
                TotalPrice = 0.0;
                Session["TotalSession"] = TotalPrice;
            }
            else
            {
                TotalPrice = (Double)Session["TotalSession"];
            }

            int count = 0;
            foreach (var bit in myList)
            {
                saveorder[count] = bit;
                count++;
                txtAreaS.Text += bit + "\n";
            }
            
            
            lemon.insert(saveorder[0],saveorder[1], saveorder[2], saveorder[3], saveorder[4], saveorder[5]);
            int OrderIDNo = lemon.getinfo5("Orders","ID", saveorder[0], saveorder[1], saveorder[2], saveorder[3], saveorder[4], saveorder[5]);
            int ItemID = -1;
            foreach (var bits in myListS)
            {
                
                List<string> temp = lemon.getinfo("Items","ID","ItemName",bits);
                foreach (var bit in temp)
                {
                    ItemID = Int32.Parse(bit);
                }
                lemon.insert(OrderIDNo, ItemID);
            }
            lblTotal.Text = TotalPrice + "";

            //foreach (DataRow row in myListOrders.Rows)
            //{
            //    string temp = row[0].ToString();
                
            //}
            //foreach (var bit in myListOrders)
            //{
                GridView1.DataSource = myListOrders;
                GridView1.DataBind();
            //}

                Session["ShippingSession"] = null;
                this.Master.Session["cartSession"] = null;
                Session["OrderSession"] = null;
                Session["TotalSession"] = null;
        }
    }
}