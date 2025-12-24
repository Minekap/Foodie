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
   
    internal class Request
    {
        private int customer_id;
        private string Message;
        private string response;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public int Customer_id { get => customer_id; set => customer_id = value; }

        public string Response { get => response; set => response = value; }
        public string Message1 { get => Message; set => Message = value; }

        public Request(int c, string m, string r)
        {
            customer_id = c;
            Message = m;
            response = r;
        }
        public string Submitrequest()
        {
            string status;
            SqlCommand cmd = new SqlCommand("INSERT INTO ReservationRequest (Customer_id, Message, Response) VALUES (@id, @message, @response)", con);
            cmd.Parameters.AddWithValue("@id",customer_id);
            cmd.Parameters.AddWithValue("@message", Message);
            cmd.Parameters.AddWithValue("@response", response);
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
        public static DataTable request()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("Select Request_id, Customer_id, Message,Response From ReservationRequest ",con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }
        public string  reply(int requestid)
        {
            string status;
            SqlCommand cmd = new SqlCommand("UPDATE ReservationRequest SET Response = @response WHERE Request_id = @requestid", con);
            cmd.Parameters.AddWithValue("@requestid", requestid);
            cmd.Parameters.AddWithValue("@response", response);
            con.Open();
            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                status = "Update Successful.";
            }
            else
            {
                status = "Unable to update.";
            }
            con.Close ();
            return status;

        }
    }
    
}
