using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace FoodiePointt
{
    internal class Order
    {
        private int customer_id;
        private DateTime orderdate;

        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

       public static SqlConnection Con { get => con; set => con = value; }
        public DateTime Orderdate { get => orderdate; set => orderdate = value; }
        public int Customer_id { get => customer_id; set => customer_id = value; }

        public Order( int i)
        {
            customer_id = i;
            orderdate = DateTime.Now;
        }

        public static DataTable GetAllHalls()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT Hall_id, Hall_name, Capacity, PartyType, Availability FROM Hall", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }

        public static string[] ProductID(string category, bool availability)
        {

            List<string> menulist = new List<string>();
            SqlCommand cmd = new SqlCommand("Select Item_id From MenuItems WHERE Category =@category AND Availability = @status", con);
            cmd.Parameters.AddWithValue("@category", category);
            cmd.Parameters.AddWithValue("@status",availability);
            con.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                menulist.Add(sqlDataReader["Item_id"].ToString());
            }

            con.Close();
            return menulist.ToArray();

        }
        public static DataTable MenuItem(string category)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT Item_id,Category,Name,Description,Price,Availability from MenuItems WHERE Category = @category", con);
            cmd.Parameters.AddWithValue("@category", category);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }


        public static string MenuName(int Menuid, string datatype)
        {
            string result;
            SqlCommand cmd = new SqlCommand("SELECT " + datatype + " FROM MenuItems WHERE Item_id = @menuid", con);
            cmd.Parameters.AddWithValue("@menuid",Menuid);
            con.Open();
            var value = cmd.ExecuteScalar();
            if (value != null )
            {
                result = value.ToString();
                
            }
            else
            {
                result = "Error";
            }
            con.Close() ;
            return result;


        }


        public int createorderid(decimal a)
        {
            int orderid = 0;
            string status = "Pending";
            decimal amount = a;
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Orders (Customer_id, TotalAmount, Status, OrderDate) VALUES (@customer_id, @subtotal, @status, @orderdate); SELECT SCOPE_IDENTITY();", con);
            cmd.Parameters.AddWithValue("@customer_id", customer_id);
            cmd.Parameters.AddWithValue("@subtotal", amount);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@orderdate", orderdate);
            object result = cmd.ExecuteScalar();
            if (result != null)
            {
                orderid = Convert.ToInt32(result);
            }
            con.Close();
            return orderid;

        }
        public bool CreateOrder(int order_id,int MenuId, int quantity, decimal subtotal)
        {
            bool message = false;
            int orderid = order_id;

            con.Open();
            SqlCommand cmd = new SqlCommand(
            "INSERT INTO OrderDetail (Order_id, Item_id, Quantity, Subtotals) VALUES (@order_id, @menu_id, @quantity, @subtotal)", con);
            cmd.Parameters.AddWithValue("@order_id", orderid);
            cmd.Parameters.AddWithValue("@menu_id", MenuId);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@subtotal", subtotal);
            int  rows = cmd.ExecuteNonQuery();
            if (rows > 0)
            {
                message = true;
            }
            con.Close();
            return message;




        }

        public DataTable View()
            {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT Orders.Order_id,MenuItems.Name, OrderDetail.Quantity, OrderDetail.Subtotals, Orders.Status FROM OrderDetail INNER JOIN MenuItems ON OrderDetail.Item_id = MenuItems.Item_id INNER JOIN Orders ON OrderDetail.Order_id = Orders.Order_id WHERE Orders.Customer_id = @customer_id;", con);
            cmd.Parameters.AddWithValue("@customer_id",customer_id);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
            }
        public static string Remove(int id)
        {
            string status;
            string order_status;
            int orderid;
            orderid = id;

            order_status = "Completed";
            con.Open();

            string query1 = "DELETE FROM OrderDetail WHERE Order_id = @id";
            SqlCommand cmd1 = new SqlCommand(query1, con);
            cmd1.Parameters.AddWithValue("@id", orderid);
            cmd1.ExecuteNonQuery();

            string query2 = "DELETE FROM Orders WHERE Status = @orderstatus AND Order_id = @id";
            SqlCommand cmd2 = new SqlCommand(query2, con);
            cmd2.Parameters.AddWithValue("@orderstatus", order_status);
            cmd2.Parameters.AddWithValue("@id", orderid);
            int result = cmd2.ExecuteNonQuery();

            con.Close();

            if (result > 0)
            {
                status = "Delete Successful.";
            }
            else
            {
                status = "Unable to Delete.";
            }

            return status;
        }
        public DataTable reservationlist()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT Reservation.Reservation_id, Hall.Hall_name, Reservation.EventDate, Reservation.Status FROM Reservation  INNER JOIN Hall ON Reservation.Hall_id = Hall.Hall_id Where Reservation.Customer_id =@customerid", con);
            cmd.Parameters.AddWithValue("@customerid",customer_id);

            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            return dt;
        }
        public DataTable viewfeedback()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM ReservationRequest Where Customer_id =@id", con);
            cmd.Parameters.AddWithValue("@id", customer_id);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            return dt;
        }
        public string addfeedback(string feeback)
        {
            string status;
            string message = feeback;
            SqlCommand cmd = new SqlCommand("INSERT INTO Feedback (Customer_id, Message, Date) VALUES (@id, @message, @date)", con);
            cmd.Parameters.AddWithValue("@id", customer_id);
            cmd.Parameters.AddWithValue("@message", message);
            cmd.Parameters.AddWithValue("@date", orderdate);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                status = "Submit successfully";
            }
            else
            {
                status = "Error ";
            }
            con.Close();
            return status;
        }

       




    }
}
