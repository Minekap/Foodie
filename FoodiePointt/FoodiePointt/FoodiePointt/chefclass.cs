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
    internal class chefclass
    {
        private int orderid;
        private DateTime date;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        public static SqlConnection Con { get => con; set => con = value; }
        public int Orderid { get => orderid; set => orderid = value; }
        public DateTime Date { get => date; set => date = value; }

        public chefclass(int id)
        {
            date = DateTime.Now;
            orderid = id;
        }
        public static DataTable vieworder(string row)
        {
            string orderstatus = row;
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders WHERE Status = @status", con);
            cmd.Parameters.AddWithValue("@status", orderstatus);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }
        public static string[] order(string orderstatus)
        {
            List<string> orderlist = new List<string>();
            string status = orderstatus;
            SqlCommand cmd = new SqlCommand("Select Order_id From Orders Where Status =@status ", con);
            cmd.Parameters.AddWithValue("@status", status);
            con.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                orderlist.Add(sqlDataReader["Order_id"].ToString());
            }

            con.Close();
            return orderlist.ToArray();
        }
        public string acceptorder()
        {
            string status;
            string orderstatus = "In Progress";
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) FROM Orders where Order_id = @id", con);
            cmd.Parameters.AddWithValue("@id", orderid);
            cmd.ExecuteNonQuery();
            int count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                SqlCommand cmd2 = new SqlCommand("Update Orders set Status = @orderstatus WHERE Order_id = @id", con);
                cmd2.Parameters.AddWithValue("@id", orderid);
                cmd2.Parameters.AddWithValue("@orderstatus", orderstatus);
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
            else
            {
                status = " Order is not existed.";
            }
            con.Close();
            return status;
        }

        public string finalizeorder(int chefid)
        {
            string status = "";
            string orderstatus = "Completed";
            string monthName = DateTime.Now.ToString("MMMM");
            DateTime date = DateTime.Now;

            con.Open();

         
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Orders WHERE Order_id = @id", con);
            cmd.Parameters.AddWithValue("@id", orderid);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                
                SqlCommand cmd2 = new SqlCommand("UPDATE Orders SET Status = @orderstatus WHERE Order_id = @id", con);
                cmd2.Parameters.AddWithValue("@id", orderid);
                cmd2.Parameters.AddWithValue("@orderstatus", orderstatus);
                int result = cmd2.ExecuteNonQuery();

                if (result > 0)
                {
                   
                    SqlCommand checkChef = new SqlCommand("SELECT Id FROM Users WHERE Id = @chefid", con);
                    checkChef.Parameters.AddWithValue("@chefid", chefid);
                    object chefExists = checkChef.ExecuteScalar();

                    if (chefExists != null && chefExists != DBNull.Value)
                    {
                        SqlCommand cmd3 = new SqlCommand("SELECT OrderDetail.Subtotals, MenuItems.Category FROM OrderDetail JOIN MenuItems ON OrderDetail.Item_id = MenuItems.Item_id WHERE OrderDetail.Order_id = @id", con);
                        cmd3.Parameters.AddWithValue("@id", orderid);

                        using (SqlDataReader reader = cmd3.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                decimal subtotal = Convert.ToDecimal(reader["Subtotals"]);
                                string category = reader["Category"].ToString();

                               
                                using (SqlConnection tempCon = new SqlConnection(con.ConnectionString))
                                {
                                    tempCon.Open();
                                    SqlCommand cmd6 = new SqlCommand("INSERT INTO SalesReport (Month, Category, Chef_id, total_sales, date) VALUES (@month, @category, @chefid, @subtotal, @date)", tempCon);
                                    cmd6.Parameters.AddWithValue("@month", monthName);
                                    cmd6.Parameters.AddWithValue("@category", category);
                                    cmd6.Parameters.AddWithValue("@chefid", chefid);
                                    cmd6.Parameters.AddWithValue("@subtotal", subtotal);
                                    cmd6.Parameters.AddWithValue("@date", date);
                                    cmd6.ExecuteNonQuery();
                                }
                            }
                        }

                        status = "Successful.";
                    }
                    else
                    {
                        status = "Chef does not exist.";
                    }
                }
                else
                {
                    status = "Unable to update order.";
                }
            }
            else
            {
                status = "Order does not exist.";
            }

            con.Close();
            return status;
        }

        public ArrayList MenuName()
        {
            ArrayList array = new ArrayList();
            SqlCommand cmd = new SqlCommand("SELECT MenuItems.Name, OrderDetail.Quantity FROM OrderDetail JOIN MenuItems ON OrderDetail.Item_id = MenuItems.Item_id WHERE OrderDetail.Order_id = @orderid", con);
            cmd.Parameters.AddWithValue("@orderid", orderid);  
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();

            while (rd.Read())
            {
                string foodName = rd["Name"].ToString();  
                int quantity = Convert.ToInt32(rd["Quantity"]);
                string displayvalue = $"{foodName},{quantity}";
                array.Add(displayvalue);
            }

            con.Close();
            return array;
        }



    }
}
