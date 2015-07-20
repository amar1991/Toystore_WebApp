using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ToyStore
{
    public partial class Paypal : System.Web.UI.Page
    {
        List<string> myList2;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ShippingSession"] == null)
            {
                myList2 = new List<string>();
                Session["ShippingSession"] = myList2;
            }
            else
            {
                myList2 = (List<string>)Session["ShippingSession"];
            }
        }

        protected void btnCommit_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "" && txtPass.Text != "")
            {
                Response.Redirect("~/CompleteOrder.aspx");
            }
            else
            {
                lblError.Text = "Please fill in all fields";
            }
        }
    }
}