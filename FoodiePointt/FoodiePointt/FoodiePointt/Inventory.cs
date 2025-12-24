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

namespace FoodiePointt
{
    internal class Inventory
    {
        private string name;
        private int quantity;
        private string category;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string Category { get => category; set => category = value; }
        public static SqlConnection Con { get => con; set => con = value; }

        public Inventory(string n,int q,string c)
        {
            name = n;
            quantity = q;
            category = c;
        }
        public string Addinventory()
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM inventory WHERE Name = @name", con);
            cmd.Parameters.AddWithValue("@name",name);
            
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                status = "Ingredient Existed";
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("Insert Into inventory (Name, QuantityAvailable, Category) Values (@name, @quantity, @category)", con);
                cmd2.Parameters.AddWithValue("@name",name);
                cmd2.Parameters.AddWithValue("@quantity",quantity);
                cmd2.Parameters.AddWithValue("@category",category);
                int rowsAffected = cmd2.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    status = "Enter Successfully";

                }
                else
                {
                    status = "Fail";
                }


            }
            con.Close();
            return status;
        }
        public string updateinventory(int id)
        {
            string status;

            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM inventory WHERE Name = @name", con);
            cmd.Parameters.AddWithValue("@name", name);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                status = "Ingredient Name Exists";
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE inventory SET Name = @name, QuantityAvailable = @quantity WHERE Ingredient_id = @id", con);
                cmd2.Parameters.AddWithValue("@name", name);
                cmd2.Parameters.AddWithValue("@quantity", quantity);
                cmd2.Parameters.AddWithValue("@id", id);

                int rowsAffected = cmd2.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    status = "Update successfully";
                }
                else
                {
                    status = "Error";
                }
            }

            con.Close();
            return status;
        }

        public static DataTable viewinventory()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }

        public static DataTable viewselected(string name)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory WHERE Name = @name", con);
            cmd.Parameters.AddWithValue("@name",name);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }

    }

}
