using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data;


namespace ToyStore.Classes 
{
    class DatabaseConnection
    {
        OleDbCommand myCommand;
        string myQuery = "";
        OleDbConnection myConnection;
        List<String> myList;
        //Session["listSession"];

        public DatabaseConnection()
        {

            SetDB();
            //string myQuery = "INSERT INTO UserTable( UserName, UserPassword, NoOfLogins, JoinDate) 	VALUES ( '“ TextBox1.Text + "' , '" + TextBox2.Text + "', 0, '" +  	DateTime.Now.Date + "')"; 




        }
    
        public void SetDB()
        {
            var path = new Uri(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)).LocalPath;
            var path2 = HttpContext.Current.Server.MapPath("~/");
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " + path2 + "/DataBase/ToyStore.accdb"; // put your path
            myConnection = new OleDbConnection(connString);
            try
            {
                myConnection.Open();
                //myCommand.ExecuteNonQuery();
                //MessageBox.Show("successful registration");
            }
            catch (Exception ex)
            {
                string script = "<script>alert('" + ex.Message + "');</script>";
            }

        }

        public void DeleteOrder(string table, string from, string from2)
        {
            SetDB();
            myQuery = "DELETE From " + table + " WHERE " + from + " = '" + from2 + "'";
            myCommand = new OleDbCommand(myQuery, myConnection);
            OleDbDataReader reader = myCommand.ExecuteReader();
            myConnection.Close();
        }
/*
        public List<string> getinfo(string table, string colume, string from, string from2,string hold)
        {
            //myConnection.Open();
            //getCon();
            //string strtemp = "";
            SetDB();
            myList = new List<String>();
            myQuery = "SELECT * From " + table + " WHERE " + from + " = '" + from2 + "'";
            myCommand = new OleDbCommand(myQuery, myConnection);
            OleDbDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                String temp = reader[colume].ToString();
                myList.Add(temp);
                //strtemp = strtemp + "," + reader["SpeciesName"];
            }
            myConnection.Close();
            //Session["listSession"] = myList;  
            return myList;
        }
 * 
*/
        public List<string> getinfo2(string table, string colume, string from, string from2)
        {
            //myConnection.Open();
            //getCon();
            //string strtemp = "";
            SetDB();
            myList = new List<String>();
            myQuery = "SELECT * From " + table + " WHERE " + from + " = " + from2 + "";
            myCommand = new OleDbCommand(myQuery, myConnection);
            OleDbDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                String temp = reader[colume].ToString();
                myList.Add(temp);
                //strtemp = strtemp + "," + reader["SpeciesName"];
            }
            myConnection.Close();
            //Session["listSession"] = myList;  
            return myList;
        }

        public List<string> getinfo(string table, string colume, string from, string from2)
        {
            //myConnection.Open();
            //getCon();
            //string strtemp = "";
            SetDB();
            myList = new List<String>();
            myQuery = "SELECT * From " + table + " WHERE "+ from + " = '" + from2 + "'";
            myCommand = new OleDbCommand(myQuery, myConnection);
            OleDbDataReader reader = myCommand.ExecuteReader();

            while (reader.Read())
            {
                String temp = reader[colume].ToString();
                myList.Add(temp);
                //strtemp = strtemp + "," + reader["SpeciesName"];
            }
            myConnection.Close();
            //Session["listSession"] = myList;  
            return myList;
        }

        public DataTable getinfo3(string table, string col1, string col2, string col3, string from, string from2)
        {
            //myConnection.Open();
            //getCon();
            //string strtemp = "";
            SetDB();
            DataTable dt = new DataTable();
            dt.Columns.Add(new DataColumn("ItemName", typeof(string)));
            dt.Columns.Add(new DataColumn("Price", typeof(double)));
            dt.Columns.Add(new DataColumn("Description", typeof(string)));
            dt.Columns.Add(new DataColumn("PictureURL", typeof(string)));
            //myList = new List<string>();
            myQuery = "SELECT * From " + table + " WHERE "+ from + " = '" + from2 + "'";
            myCommand = new OleDbCommand(myQuery, myConnection);
            OleDbDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                DataRow dr = dt.NewRow();
                dr["ItemName"] = reader[col1];
                dr["Price"] = reader[col2];
                dr["Description"] = reader[col3];
                dr["PictureURL"] = "~/PicFiles/" + reader["PicDir"];
                dt.Rows.Add(dr);
            }
            //myList.Add(reader);
            myConnection.Close();
            return dt;
            //Session["listSession"] = myList;  
            //return myList;

        }

        public List<string> getinfo4(string table, string col1, string col2, string col3, string from, string from2)
        {
            //myConnection.Open();
            //getCon();
            //string strtemp = "";
            SetDB();
            
            myList = new List<string>();
            myQuery = "SELECT * From " + table + " WHERE " + from + " = " + from2 + "";
            myCommand = new OleDbCommand(myQuery, myConnection);
            OleDbDataReader reader = myCommand.ExecuteReader();
            while (reader.Read())
            {
                myList.Add(reader[col1].ToString());
                myList.Add(reader[col2].ToString());
                myList.Add(reader[col3].ToString());
                myList.Add(reader["PicDir"].ToString());
            }
            //myList.Add(reader);
            myConnection.Close();
            //return dt;
            //Session["listSession"] = myList;  
            return myList;

        }

        public List<string> getinfo(string table, string colume)
        {
            //myConnection.Open();
            //getCon();
            //string strtemp = "";
            SetDB();
            myList = new List<String>();
            myQuery = "SELECT * From " + table ; //+ " WHERE "+ from + " = " + from2 + "";
            myCommand = new OleDbCommand(myQuery, myConnection);
            OleDbDataReader reader = myCommand.ExecuteReader();
            
            while (reader.Read())
            {
                String temp = reader[colume].ToString();
                myList.Add(temp);
                //strtemp = strtemp + "," + reader["SpeciesName"];
            }
            myConnection.Close();
            //Session["listSession"] = myList;  
            return myList;
        }
/*
        public List<string> getinfo(string table,string colume, string from)
        {
            //myConnection.Open();
            //getCon();
            //string strtemp = "";
            SetDB();
            myList = new List<String>();
            if (from != null)
            {
                myQuery = "SELECT * From Item WHERE ItemName = '" + from + "'";
                myCommand = new OleDbCommand(myQuery, myConnection);
                OleDbDataReader reader2 = myCommand.ExecuteReader();
                string temper = null;
                while (reader2.Read())
                {
                    temper = reader2["ID"].ToString();
                }
                myQuery = "SELECT * FROM " + table + " WHERE SpeciesID = " + temper;
            }
            else
            {
                myQuery = "SELECT * FROM " + table;
            }
            myCommand = new OleDbCommand(myQuery, myConnection);
            OleDbDataReader reader = myCommand.ExecuteReader();
            //myList = (List<string>)Session["listSession"]; 

            while (reader.Read())
            {
                String temp = reader[colume].ToString();
                myList.Add(temp);
                //strtemp = strtemp + "," + reader["SpeciesName"];
            }
            myConnection.Close();
            //Session["listSession"] = myList;  
            return myList;
        }
        */
       // public void insert(string table, string name)
       // {

       // }
       // public void insert(string table, string name, int one, int two, int id)
       // {

       // }
        /*
        public Int32 getData(string table,string con,string col, string conresult)
        {
            SetDB();
            myQuery = "SELECT * From " + table + " WHERE "+ con + " = '" + conresult + "'";
            myCommand = new OleDbCommand(myQuery, myConnection);
            OleDbDataReader reader3 = myCommand.ExecuteReader();
            string temper = null;
            while (reader3.Read())
            {
                temper = reader3[col].ToString();
            }
            int intvalue = Convert.ToInt32(temper);
            myConnection.Close();
            return intvalue;
        }
        */
        public Int32 getinfo5(string table, string colume, string namef, string namel, string no, string road, string city, string postcode)
        {
            //myConnection.Open();
            //getCon();
            //string strtemp = "";
            SetDB();
            myList = new List<String>();
            myQuery = "SELECT * From " + table + " WHERE NameFirst='" + namef + "' AND  NameLast='" + namel + "' AND NOHouse=" + no + " AND Roads='" + road + "' AND Citys='" + city + "' AND PostCodes='" + postcode + "'";
            myCommand = new OleDbCommand(myQuery, myConnection);
            OleDbDataReader reader = myCommand.ExecuteReader();
            Int32 temp = -1;
            while (reader.Read())
            {
                temp = Int32.Parse(reader[colume].ToString());
                //myList.Add(temp);
                //strtemp = strtemp + "," + reader["SpeciesName"];
            }
            myConnection.Close();
            //Session["listSession"] = myList;  
            return temp;
        }

        public void insert(string namef, string namel, string no, string road, string city, string postcode )
        {
            SetDB();
            myQuery = "INSERT INTO Orders (NameFirst, NameLast, NOHouse, Roads, Citys, PostCodes) VALUES ('" + namef + "' , '" + namel + "' , " + no + " , '" + road + "' , '" + city + "' , '" + postcode + "')";
            //myQuery = "INSERT INTO Order VALUES ('" + namef + "' , '" + namel + "' , '" + no + "' , '" + road + "' , '" + city + "' , '" + postcode + "')";
            myCommand = new OleDbCommand(myQuery, myConnection);
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }

        public void insert(int oID, int ItID)
        {
            SetDB();
            myQuery = "INSERT INTO OrderLine (Order_ID, Item_ID) VALUES ( " + oID + " , " + ItID + ")";
            myCommand = new OleDbCommand(myQuery, myConnection);
            myCommand.ExecuteNonQuery();
            myConnection.Close();
        }
        /*
        public void insert(string name, Double age, string gender, Double wieght, DateTime arival, string bills, string PicUrl,String Bid,String ParkId)
        {

            Int32 intBid = getData("Breed","BreedName","ID",Bid);
            Int32 intPid = getData("Park","ParkName","ParkID",ParkId);
            //OleDbParameter objectdate = new OleDbParameter("@objectdate", OleDbType.DBDate);
            //objectdate.Value = arival;
            SetDB();
            //myConnection.Open();
            myQuery = "INSERT INTO Pets(PetName, PetAge, PetGender, PetWeight, PetDate, PetVetBills, PetPic, BreedID, ParkID) VALUES( '" + name + "' , '" + age + "' , '" + gender + "' , '" + wieght + "' , '" + arival + "' , '" + bills + "' , '" + PicUrl + "' , '" + intBid + "' , '" + intPid + "')";
            myCommand = new OleDbCommand(myQuery, myConnection);
            myCommand.ExecuteNonQuery();

            myConnection.Close();
            
        }
        */
    }
}
