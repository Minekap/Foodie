using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Data;
using System.Diagnostics.Eventing.Reader;


namespace FoodiePointt
{
    internal class Hall
    {
        private string hall_name;
        private int capacity;
        private string party_type;
        private bool available;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Hall_name { get => hall_name; set => hall_name = value; }
        public int Capacity { get => capacity; set => capacity = value; }
        public string Party_type { get => party_type; set => party_type = value; }
        public static SqlConnection Con { get => con; set => con = value; }
        public bool Available { get => available; set => available = value; }

        public Hall(string h, int c, string t,bool a)
        {
            hall_name = h;
            capacity = c;
            party_type = t;
            available = a;
        }
        public string createhall()
        {
            if (string.IsNullOrWhiteSpace(hall_name) ||
               string.IsNullOrWhiteSpace(party_type) ||
               capacity <= 0)
            {
                return "All fields are required.";
            }
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert into Hall (Hall_name,Capacity,PartyType,Available) Values(@hall_name,@capacity,@partytype,@available)", con);
            cmd.Parameters.AddWithValue("@hall_name", hall_name);
            cmd.Parameters.AddWithValue("@capacity", capacity);
            cmd.Parameters.AddWithValue("@partytype", party_type);
            cmd.Parameters.AddWithValue("@available", available);
            

            int result = cmd.ExecuteNonQuery();


            if (result > 0)
            {
                status = "Registration Reservation Successful.";
            }
            else
            {
                status = "Unable to register menu.";
            }
            con.Close();
            return status;
        }
        public static DataTable halllist()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT Hall_id,Hall_name,Capacity,PartyType,Availability FROM Hall", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }

        public string UpdateHall(int hallid)
        {
            string OldHallName = hall_name;
            if (string.IsNullOrWhiteSpace(hall_name) ||
               string.IsNullOrWhiteSpace(party_type) ||
               capacity <= 2)
            {
                return "All fields are required.";
            }
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Hall WHERE Hall_id = @hallid", con);

            cmd.Parameters.AddWithValue("@hallid", hallid);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count < 0)
            {
                status = "This hall is not existed";
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE Hall SET Hall_name = @hallName, Capacity = @capacity, PartyType = @partyType, Available = @status WHERE Hall_id = @id", con);
                cmd2.Parameters.AddWithValue("@hallName", hall_name);
                cmd2.Parameters.AddWithValue("@capacity", capacity);
                cmd2.Parameters.AddWithValue("@partyType", party_type);
                cmd2.Parameters.AddWithValue("@status", available);
                cmd2.Parameters.AddWithValue("@oldHallName", OldHallName);
                cmd2.Parameters.AddWithValue("@id",hallid);
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


    }
}
