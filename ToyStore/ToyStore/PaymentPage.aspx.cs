using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToyStore.Classes;

namespace ToyStore
{
    public partial class PaymentPage : System.Web.UI.Page
    {
        List<string> myListS;
        List<string> myList2;
        Double TotalPrice;
        DataTable myListOrder;
        DataTable dt;
        DatabaseConnection lemon = new DatabaseConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Master.Session["cartSession"] == null)
            {
                myListS = new List<string>();
                this.Master.Session["cartSession"] = myListS;
            }
            else
            {
                myListS = (List<string>)Session["cartSession"];
            }

            if (Session["ShippingSession"] == null)
            {
                myList2 = new List<string>();
                Session["ShippingSession"] = myList2;
            }
            else
            {
                myList2 = (List<string>)Session["ShippingSession"];
            }

            if (Session["OrderSession"] == null)
            {
                myListOrder = new DataTable();
                Session["OrderSession"] = myListOrder;
            }
            else
            {
                myListOrder = (DataTable)Session["OrderSession"];
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

            if (myListS.Count() >= 1)
            {
                double subTotal = 0.0;
                dt = new DataTable();
                dt.Columns.Add(new DataColumn("ItemName", typeof(string)));
                dt.Columns.Add(new DataColumn("Price(PerUnit)", typeof(string)));
                dt.Columns.Add(new DataColumn("Description", typeof(string)));
                dt.Columns.Add(new DataColumn("PicDir", typeof(string)));

                List<string> AddData = new List<string>();
                foreach (var bit in myListS)
                {



                    //DataSet dsPerson = new DataSet();
                    //List<string> AddData = new List<string>();

                    //SqlDataAdapter da = new SqlDataAdapter(lemon.getinfo3("Items", "ItemName", "Price(PerUnit)", "Description", "ItemName", bit)); 
                    AddData = lemon.getinfo4("Items", "ItemName", "Price(PerUnit)", "Description", "ItemName", "'" + bit + "'");
                    string[] dataarray = AddData.ToArray();
                    DataRow dr = dt.NewRow();
                    //foreach (var bits in AddData)
                    //{

                    dr["ItemName"] = dataarray[0] + "";
                    dr["Price(PerUnit)"] = "£" + dataarray[1] + "";
                    dr["Description"] = dataarray[2] + "";
                    dr["PicDir"] = ResolveUrl("~/PicFiles/" + dataarray[3]);
                    dt.Rows.Add(dr);
                    //}
                    subTotal += double.Parse(dataarray[1]);

                }
                GridView1.DataSource = dt;
                //myListOrder = dt;
                Session["OrderSession"] = dt;
                GridView1.DataBind();
                
                lblTotal.Text = "£" + subTotal;
            }
            else
            {
                lblEmpty.Text = "   You Have No Items In The Shopping Basket";
            }
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Remove")
            {
                // Retrieve the row index stored in the 
                // CommandArgument property.
                int index = Convert.ToInt32(e.CommandArgument);
                myListS = (List<string>)Session["cartSession"];

                myListS.RemoveAt(index);
                GridView1.DeleteRow(index);
                GridView1.DataBind();
                
                Response.Redirect(Request.RawUrl);
                // Retrieve the row that contains the button 
                // from the Rows collection.
                //GridViewRow row = GridView1.Rows[index];
                
                // Add code here to add the item to the shopping cart.
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }
       
        protected void btnBuy_Click(object sender, EventArgs e)
        {

            if (txtFname.Text != "" && txtLname.Text != "" && txtNo.Text != "" && txtRoad.Text != "" && txtRoad.Text != "" && txtPostCode.Text != "" && myListS.Count() >= 1)
            {
                string optionPay = DropDownList1.SelectedItem.Text.ToString();

                //myList2 = (List<string>)Session["ShippingSession"];
                myList2.Add(txtFname.Text);
                myList2.Add(txtLname.Text);
                myList2.Add(txtNo.Text);
                myList2.Add(txtRoad.Text);
                myList2.Add(txtCity.Text);
                myList2.Add(txtPostCode.Text);
                string newString = lblTotal.Text.Replace("£", "");
                Session["TotalSession"] = Double.Parse(newString);
                /*
                //myListOrder = (List<DataTable>)Session["OrderSession"];
                DataTable dp = new DataTable();
                foreach (GridViewRow row in GridView1.Rows)
                {
                    int count = 0;
                    DataRow dr;
                    dr = dp.NewRow();
                    foreach (DataControlFieldCell cell in row.Cells)
                    {
                        dr[count] = cell;
                        count++;
                    }
                    dp.Rows.Add(dr);
                }
                myListOrder.Add(dp);
                */
                if (optionPay == "Debit")
                {
                    Response.Redirect("~/Debit.aspx");
                }
                else if (optionPay == "Credit")
                {
                    Response.Redirect("~/Credit.aspx");
                }
                else if (optionPay == "Paypal")
                {
                    Response.Redirect("~/Paypal.aspx");
                    //Response.Redirect("http://www.paypal.co.uk");
                }

                
            }
            else
            {
                lblEmpty.Font.Bold = true;
                lblEmpty.Text = "To Confirm Order there Must be Items in the Basket";
                //lblError.Text = "Fill in All Fields";
                //Response.Redirect(Request.RawUrl);

            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}