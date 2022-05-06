using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Webpage
{
    public partial class Product_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             Response.Write("<center><h1>Read data from a database</h1></center><hr/>");
             Response.Write("<br/>");

             // step 1 Read connection string
             string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

             // step 2 - create a SQLConnection
             SqlConnection con = new SqlConnection(s);

             // setup query string
             string sqlString = "select distinct ProductName from products";

             // setup sql command object
             SqlCommand cmd = new SqlCommand(sqlString, con);

             // open the connection
             con.Open();

             //execute the command
             //use cmd.ExecuteReader() for SELECT statement.
             //use cmd.ExecuteScalar for return of count or single numbers.
             SqlDataReader dr = cmd.ExecuteReader();

             //use cmd.ExecuteNonQuery() for INSERT, UPDATE, DELETE.

             // Setup datasource for Gridview
             GridView1.DataSource = dr;

             // bind datasource to Gridview
             GridView1.DataBind();

             // cloes datareader
             dr.Close();

             // close connection
             con.Close();


        }

        protected void Button1_Click(object sender, EventArgs e)
            {
                Response.Write("<center><h1>Read data from a database </ h1 ></ center >< hr /> ");
                Response.Write("<br/>");
                String txtValue = TextBox1.Text;
                string s = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
                SqlConnection con = new SqlConnection(s);
                string sqlString = "select * from products where ProductName=@ProductName";
                SqlCommand cmd = new SqlCommand(sqlString, con);
                //to prevent sql injection
                cmd.Parameters.AddWithValue("@ProductName", txtValue);
           
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                
                GridView1.DataSource = dr;
                GridView1.DataBind();
                dr.Close();
                con.Close();

               
        }
    }
}