using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FoodiePointt
{
    internal class MenuFood
    {
        private string menu;
        private string description;
        private decimal price;
        private string category;
        private bool available;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public MenuFood(string m, string d, decimal p, string c, bool a)
        {
            menu = m;
            description = d;
            price = p;
            category = c;
            available = a;
        }

        public string CreateMenu()
        {
            if (string.IsNullOrWhiteSpace(menu) ||
                string.IsNullOrWhiteSpace(description) ||
                string.IsNullOrWhiteSpace(category) ||
                price <= 0)
            {
                return "All fields are required.";
            }

            con.Open();
            string status;

            SqlCommand cmd1 = new SqlCommand("SELECT COUNT(*) FROM MenuItems WHERE Name = @name", con);
            cmd1.Parameters.AddWithValue("@name", menu);
            int count = Convert.ToInt32(cmd1.ExecuteScalar());

            if (count > 0)
            {
                status = "This menu item already exists.";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO MenuItems (Category, Name, Description, Price, Availability) VALUES (@category, @name, @description, @price, @availability)", con);
                cmd.Parameters.AddWithValue("@name", menu);
                cmd.Parameters.AddWithValue("@category", category);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.Parameters.AddWithValue("@price", price);
                cmd.Parameters.AddWithValue("@availability", available);

                int result = cmd.ExecuteNonQuery();
                status = result > 0 ? "Menu registration successful." : "Unable to register menu.";
            }

            con.Close();
            return status;
        }




        public string UpdateMenu(int menuid)
        {
            if (string.IsNullOrWhiteSpace(menu) ||
               string.IsNullOrWhiteSpace(description) ||
               string.IsNullOrWhiteSpace(category) ||
               price <= 0)
            {
                return "All fields are required.";
            }
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM MenuItems WHERE Item_id = @id", con);

            cmd.Parameters.AddWithValue("@id", menuid);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count < 0)
            {
                status = "This menu is not existed";
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE MenuItems SET Category = @category, Name = @menu, Description = @description, Price = @price, Availability = @available WHERE Item_id = @id", con);
                cmd2.Parameters.AddWithValue("@category", category);
                cmd2.Parameters.AddWithValue("@menu", menu);
                cmd2.Parameters.AddWithValue("@description", description);
                cmd2.Parameters.AddWithValue("@price", price);
                cmd2.Parameters.AddWithValue("@available", available);
                cmd2.Parameters.AddWithValue("@name", menu);
                cmd2.Parameters.AddWithValue("@id", menuid);

                int result = cmd2.ExecuteNonQuery();

                if (result > 0)
                {
                    status = "Update Successful.";
                }
                else
                {
                    status = "Unable to update.";
                }
            }

            con.Close();
            return status;
        }
        public static DataTable Menulist()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT Item_id,Category,Name,Description,Price,Availability from MenuItems", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }
        
    }
}