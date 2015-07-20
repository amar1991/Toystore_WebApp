using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToyStore.Classes;


namespace ToyStore
{
    public partial class Search : System.Web.UI.Page
    {
        DatabaseConnection lemon = new DatabaseConnection();
        
        List<string> myListS;
        int myListint;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            //ListBox1.Items.Clear();
            if (this.Master.Session["cartSession"] == null)
            {
                myListS = new List<string>();
                this.Master.Session["cartSession"] = myListS;
            }
            else
            {
                myListS = (List<string>)Session["cartSession"];
            }

            if (Session["intSession"] == null)
            {
                myListint = new Int32();
                Session["intSession"] = myListint;
            }
            else
            {
                myListint = (Int32)Session["intSession"];
            }

            if (!Page.IsPostBack)
            {
                loadList();
                ListBox1.SelectedIndex = 0;
                ListBox1_SelectedItemChanged(null, null);
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

            AddData = getListItems("Items", "ItemName");
            foreach (var bit in AddData)
            {
                ItemTemp = bit;
                ListBox1.Items.Add(ItemTemp);
            }


        }

        protected void ListBox1_SelectedItemChanged(object sender, System.EventArgs e)
        {
            
            ListBox2.Items.Clear();
            String item = ListBox1.SelectedItem.Text.ToString();
            String ItemTemp;
            String Imgpic = "";
            List<string> AddData = new List<string>();

            AddData = lemon.getinfo("Items", "ItemName", "ItemName" ,item);
            foreach (var bit in AddData)
            {
                ItemTemp = "Item Name: " + bit;
                ListBox2.Items.Add(ItemTemp);
            }

            AddData = lemon.getinfo("Items", "Categories", "ItemName", item);
            int catvalue = -1;
            foreach (var bit in AddData)
            {
                catvalue = Int32.Parse(bit);
            }
            string temp = catvalue.ToString();
            AddData = lemon.getinfo2("Category", "CatName", "ID", temp );
            foreach (var bit in AddData)
            {
                ItemTemp = "Items Category: " + bit;
                ListBox2.Items.Add(ItemTemp);
            }

            AddData = lemon.getinfo("Items", "Price(PerUnit)", "ItemName", item);
            foreach (var bit in AddData)
            {
                ItemTemp = "Items Price: " + bit;
                ListBox2.Items.Add(ItemTemp);
            }

            AddData = lemon.getinfo("Items", "Description", "ItemName", item);
            foreach (var bit in AddData)
            {
                ItemTemp = "Item Description: \n" + bit;
                ListBox2.Items.Add(ItemTemp);
            }
            AddData = lemon.getinfo("Items", "PicDir", "ItemName", item);
            foreach (var bit in AddData)
            {
                Imgpic = bit;
            }

            Image1.ImageUrl = "~/PicFiles/" + Imgpic;
            myListint = ListBox1.SelectedIndex;
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            String ItemTemp;
            ListBox1.Items.Clear();
            List<string> AddData = new List<string>();

            AddData = getListItems("Items", "ItemName");
            foreach (var bit in AddData)
            {
                if (bit.ToLower().Contains(txtboxsearch.Text.ToLower()))
                {
                    ItemTemp = bit;
                    ListBox1.Items.Add(ItemTemp);
                }
                else
                {
                    //Label1.Text = bit;
                }
            }
        }

        protected void txtboxsearch_TextChanged(object sender, EventArgs e)
        {
            String ItemTemp;
            ListBox1.Items.Clear();
            List<string> AddData = new List<string>();

            AddData = getListItems("Items", "ItemName");
            foreach (var bit in AddData)
            {
                if (bit.ToLower().Contains(txtboxsearch.Text.ToLower()))
                {
                    ItemTemp = bit;
                    ListBox1.Items.Add(ItemTemp);
                }
                else
                {
                    //Label1.Text = bit;
                }
            }
        }

        protected void btnAddto_Click(object sender, EventArgs e)
        {
            String item = ListBox1.SelectedItem.Text.ToString();
            List<string> AddData = new List<string>();
            String ItemTemp;

            AddData = lemon.getinfo("Items", "ItemName", "ItemName", item);
            myListS = (List<string>)this.Master.Session["CartSession"];
            foreach (var bit in AddData)
            {
                ItemTemp = bit;
                myListS.Add(ItemTemp);
            }
            //this.Master.Session["CartSession"] = myListBasket;
            //AutoPostBackControl.
            myListint = ListBox1.SelectedIndex;
            Response.Redirect(Request.RawUrl);
            //ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), "DoPostBack", "__doPostBack(" + sender + "," + e + ")", true);
            //__dopostback(sender,e);
            //href="javascript:__doPostBack('btnAddto','')"
        }

    }
}