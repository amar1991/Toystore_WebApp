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
    public partial class Category : System.Web.UI.Page
    {
        DatabaseConnection lemon = new DatabaseConnection();

        List<string> myListS;

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

            if (!Page.IsPostBack)
            {
                loadList();
                ddlist.SelectedIndex = 0;
                ddlist_SelectedIndexChanged(null, null);
            }
        }

        public List<string> getListItems(string table, string col)
        {
            List<string> temp = new List<string>();
            //temp = Controller1.getinfo(table, col);
            temp = lemon.getinfo(table, col);
            return temp;
        }

        public void loadList()
        {
            //ListBox1.Items.Clear();
            String ItemTemp;
            List<string> AddData = new List<string>();

            AddData = getListItems("Category", "CatName");
            foreach (var bit in AddData)
            {
                ItemTemp = bit;
                ddlist.Items.Add(ItemTemp);
            }


        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "addToCart")
            {
                // Retrieve the row index stored in the 
                // CommandArgument property.
                int index = Convert.ToInt32(e.CommandArgument);

                string name = GridView1.Rows[index].Cells[1].Text;
                // Retrieve the row that contains the button 
                // from the Rows collection.
                //GridViewRow row = GridView1.Rows[index];

                // Add code here to add the item to the shopping cart.
                
                List<string> AddData = new List<string>();
                String ItemTemp;

                AddData = lemon.getinfo("Items", "ItemName", "ItemName", name);
                myListS = (List<string>)this.Master.Session["CartSession"];
                foreach (var bit in AddData)
                {
                    ItemTemp = bit;
                    myListS.Add(ItemTemp);
                }

                Response.Redirect(Request.RawUrl);

            }

        }

        protected void ddlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> AddData = new List<string>();
            String item = ddlist.SelectedItem.Text.ToString();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("PicDir", typeof(string)));
            dt.Columns.Add(new DataColumn("ItemName", typeof(string)));
            dt.Columns.Add(new DataColumn("Price(PerUnit)", typeof(string)));
            dt.Columns.Add(new DataColumn("Description", typeof(string)));
            

            AddData = lemon.getinfo("Category", "ID", "CatName", item);
            int catvalue = -1;
            foreach (var bit in AddData)
            {
                catvalue = Int32.Parse(bit);
            }
            string temp = catvalue.ToString();

            AddData = lemon.getinfo4("Items", "ItemName", "Price(PerUnit)", "Description", "Categories", temp);
            string[] dataarray = AddData.ToArray();
            
            //foreach (var bits in AddData)
            //{
            int count = 1;
            for (int i = 0; i < dataarray.Length; i++)
            {
                    DataRow dr = dt.NewRow();
                    
                    dr["ItemName"] = dataarray[i] + "";
                    i++;
                    dr["Price(PerUnit)"] = "£" + dataarray[i] + "";
                    i++;
                    dr["Description"] = dataarray[i] + "";
                    i++;
                    dr["PicDir"] = ResolveUrl("~/PicFiles/" + dataarray[i]);

                    //if (count == 0)
                    //{
                        dt.Rows.Add(dr);
                    //}
                    //else
                    //{
                      //  DataRow dm = dr;
                       // dt.Rows.Add(dm);
                    //}
                    //dt.Rows.InsertAt(dr, count);
                    count++;
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}