using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace FoodiePointt
{
    internal class Sale
    {
        private int chefid;
        
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public static SqlConnection Con { get => con; set => con = value; }
        public int Chefid { get => chefid; set => chefid = value; }

        public Sale(int c)
        {
            chefid = c;
        }

        public static DataTable viewsale()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SalesReport", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }
        public static string[] ChefID()
        {

            List<string> cheflist = new List<string>();
            string role = "Chef";

            SqlCommand cmd = new SqlCommand("Select Id From Users WHERE Role =@role", con);
            cmd.Parameters.AddWithValue("@role", role);
            con.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                cheflist.Add(sqlDataReader["Id"].ToString());
            }

            con.Close();
            return cheflist.ToArray();

        }

        public string chefname()
        {
            string status;
            SqlCommand cmd = new SqlCommand("Select Username FROM Users WHERE Id = @chefid", con);
            cmd.Parameters.AddWithValue("@chefid",chefid);
            con.Open();
            var value = cmd.ExecuteScalar();
            if (value != null)
            {
                status = value.ToString();

            }
            else
            {
                status = "Error";
            }
            con.Close();
            return status;
        }
        public static DataTable ViewSalesByCategory(string category)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SalesReport WHERE Category = @category", con);
            cmd.Parameters.AddWithValue("@category", category);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }

        public static DataTable ViewSalesByMonth(string month)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SalesReport WHERE Month = @month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }
        public DataTable viewchefsale()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SalesReport WHERE Chef_id = @chefid", con);
            cmd.Parameters.AddWithValue("@chefid", chefid);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }
        public  DataTable ViewSales( string category, string month)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SalesReport WHERE Chef_id = @chefid AND Category = @category AND Month = @month", con);
            cmd.Parameters.AddWithValue("@chefid", chefid);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@month", month);

            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            return dt;
        }
        public static string SaleCategory(string category)
        {
            SqlCommand cmd = new SqlCommand("SELECT SUM(total_sales) FROM SalesReport WHERE Category = @category", con);
            cmd.Parameters.AddWithValue("@category", category);

            con.Open();
            object result = cmd.ExecuteScalar();
            con.Close();

            if (result == DBNull.Value || result == null)
            {
                return "Don't have data based on this category";
            }

            decimal total = Convert.ToDecimal(result);
            return total.ToString("0.00"); 
        }

        public static string SaleMonth(string month)
        {
            
            
            SqlCommand cmd = new SqlCommand("SELECT SUM(total_sales) FROM SalesReport WHERE Month = @month", con);
            cmd.Parameters.AddWithValue("@month", month);

            con.Open();
            object result = cmd.ExecuteScalar();
            con.Close();

            if (result == DBNull.Value || result == null)
            {
                return "Don't have data based on this month";
            }

            decimal total = Convert.ToDecimal(result);
            return total.ToString("0.00");
        }

        public string SaleChef()
        {
            SqlCommand cmd = new SqlCommand("SELECT SUM(total_sales) FROM SalesReport WHERE Chef_id = @chefid", con);
            cmd.Parameters.AddWithValue("@chefid", chefid);

            con.Open();
            decimal total = Convert.ToDecimal(cmd.ExecuteScalar());
            con.Close();

            return total.ToString("0.00");
        }

        public string SaleBasedOnEverything(string category, string month)
        {
            SqlCommand cmd = new SqlCommand("SELECT SUM(total_sales) FROM SalesReport WHERE Category = @category AND Month = @month AND Chef_id = @chefid", con);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@chefid", chefid);   

            con.Open();
            object result = cmd.ExecuteScalar();
            con.Close();

            if (result == DBNull.Value || result == null)
            {
                return "Don't have this data"; 
            }

            decimal total = Convert.ToDecimal(result);
            return total.ToString("0.00"); 
        }


    }
    
}
