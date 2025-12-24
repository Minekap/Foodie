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


    internal class Reservation
    {

        private int customerid;
        private int hallid;
        private int partysize;
        private DateTime time;
        private string availability;
        private int rcid;


        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public int Customerid { get => customerid; set => customerid = value; }
        public int Hallid { get => hallid; set => hallid = value; }
        public int Partysize { get => partysize; set => partysize = value; }
        public DateTime Time { get => time; set => time = value; }

        public int Rcid { get => rcid; set => rcid = value; }
        public string Availability { get => availability; set => availability = value; }

        public Reservation(int c, int h, int p, DateTime t, string s, int rc)
        {
            customerid = c;
            hallid = h;
            partysize = p;
            time = t;
            availability = s;
            rcid = rc;
        }

        public static DataTable viewreservation()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Reservation", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }
        public static string[] CustomerID()
        {

            List<string> customerlist = new List<string>();
            string role = "Customer";

            SqlCommand cmd = new SqlCommand("Select Id From Users WHERE Role =@role", con);
            cmd.Parameters.AddWithValue("@role", role);
            con.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                customerlist.Add(sqlDataReader["Id"].ToString());
            }

            con.Close();
            return customerlist.ToArray();

        }

        public static string[] HallId(bool a)
        {
            bool available = a;
            List<string> halllist = new List<string>();
            SqlCommand cmd = new SqlCommand("Select Hall_id From Hall WHERE Availability =@status", con);
            cmd.Parameters.AddWithValue("@status", available);
            con.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                halllist.Add(sqlDataReader["Hall_id"].ToString());
            }

            con.Close();
            return halllist.ToArray();

        }

        public static string hallname(int hallid)
        {
            string result;
            SqlCommand cmd = new SqlCommand("Select Hall_name From Hall Where Hall_id = @hallid", con);
            cmd.Parameters.AddWithValue("@hallid", hallid);
            con.Open();
            var value = cmd.ExecuteScalar();
            if (value != null)
            {
                result = value.ToString();

            }
            else
            {
                result = "Error";
            }
            con.Close();
            return result;
        }

        public string createreservation()
        {
            string status;
            con.Open();

            
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Reservation WHERE Hall_id = @hallid AND EventDate = @date AND Status = @status", con);
            cmd.Parameters.AddWithValue("@hallid", hallid);
            cmd.Parameters.AddWithValue("@date", time);
            cmd.Parameters.AddWithValue("@status", "Busy");

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                status = "This hall is already booked on the selected date. Please choose another date.";
            }
            else
            {
                // Insert new reservation
                SqlCommand cmd2 = new SqlCommand("INSERT INTO Reservation (Customer_id, Hall_id, PartySize, EventDate, Status, [By]) " +
                                                 "VALUES (@customerid, @hallid, @partysize, @eventdate, @available, @by)", con);
                cmd2.Parameters.AddWithValue("@customerid", customerid);
                cmd2.Parameters.AddWithValue("@hallid", hallid);
                cmd2.Parameters.AddWithValue("@partysize", partysize);
                cmd2.Parameters.AddWithValue("@eventdate", time);
                cmd2.Parameters.AddWithValue("@by", rcid);
                cmd2.Parameters.AddWithValue("@available", availability);

                int result = cmd2.ExecuteNonQuery();
                if (result > 0)
                {
                    status = "Reservation successfully created!";
                }
                else
                {
                    status = "Error creating reservation.";
                }
            }

            con.Close();
            return status;
        }

        public string updatereservation(int id)
        {
            string status;
            SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Reservation WHERE Hall_id = @hallid AND EventDate = @eventdate AND Reservation_id != @reservationid", con);
            checkCmd.Parameters.AddWithValue("@hallid", hallid);
            checkCmd.Parameters.AddWithValue("@eventdate", time);
            checkCmd.Parameters.AddWithValue("@reservationid", id);
            con.Open();
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
            {
                status = "This hall is already booked on the selected date. Please choose another date.";
            }
            else
            {
                SqlCommand cmd = new SqlCommand("UPDATE Reservation SET Hall_id = @hallid, PartySize = @partysize, EventDate = @eventdate, Status = @status WHERE Reservation_id = @reservationid", con);
                cmd.Parameters.AddWithValue("@hallid", hallid);
                cmd.Parameters.AddWithValue("@partysize", partysize);
                cmd.Parameters.AddWithValue("@eventdate", time);
                cmd.Parameters.AddWithValue("@status", availability);
                cmd.Parameters.AddWithValue("@reservationid", id);

                int result = cmd.ExecuteNonQuery();

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

        public static string deletereservation(int id)
        {
            string status;

            con.Open();
            string query = "DELETE FROM Reservation WHERE Reservation_id = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", id);

            int result = cmd.ExecuteNonQuery();

            if (result > 0)
            {
                status = "Delete Successful.";
            }
            else
            {
                status = "Unable to Delete.";
            }

            con.Close();
            return status;
        }
        public string finalize()
        {
            string status;
            con.Open();

           
            SqlCommand cmd1 = new SqlCommand("SELECT PartyType FROM Hall WHERE Hall_id = @hallid", con);
            cmd1.Parameters.AddWithValue("@hallid", hallid);
            object partytypeobj = cmd1.ExecuteScalar();

            if (partytypeobj == null)
            {
                status = "Invalid Hall ID: No PartyType found.";
            }
            else
            {
                string partyType = partytypeobj.ToString();

               
                SqlCommand cmd3 = new SqlCommand("INSERT INTO HallReservationReport (Month, ReservationType, TotalReservation) " +
                                                 "VALUES (@month, @partytype, 1)", con);
                cmd3.Parameters.AddWithValue("@month", time.ToString("MMMM"));
                cmd3.Parameters.AddWithValue("@partytype", partyType);

                int result = cmd3.ExecuteNonQuery();
                if (result > 0)
                {
                    status = "Reservation finalized and recorded in the report!";
                }
                else
                {
                    status = "Error finalizing reservation.";
                }
            }

            con.Close();
            return status;
        }
        public static DataTable viewreport()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HallReservationReport", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }

        public static DataTable ViewRecordByMonth(string month)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HallReservationReport Where Month = @month", con);
            cmd.Parameters.AddWithValue("@month", month);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }
        public static DataTable ViewRecordByCategory(string category)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HallReservationReport Where ReservationType = @category", con);
            cmd.Parameters.AddWithValue("@category", category);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }
        public static DataTable ViewRecordByMonthAndType(string month, string type)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM HallReservationReport WHERE Month = @month AND ReservationType = @type", con);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@type", type);

            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            return dt;
        }
        public static string SumReservationCategory(string reservationType)
        {
            SqlCommand cmd = new SqlCommand("SELECT SUM(TotalReservation) FROM HallReservationReport WHERE ReservationType = @reservationType", con);
            cmd.Parameters.AddWithValue("@reservationType", reservationType);

            con.Open();
            object result = cmd.ExecuteScalar();
            con.Close();

            if (result == DBNull.Value || result == null)
            {
                return "Don't have data based on this reservation type";
            }

            int total = Convert.ToInt32(result);
            return total.ToString("0");
        }
        public static string ReservationMonth(string month)
        {
            SqlCommand cmd = new SqlCommand("SELECT SUM(TotalReservation) FROM HallReservationReport WHERE Month = @month", con);
            cmd.Parameters.AddWithValue("@month", month);

            con.Open();
            object result = cmd.ExecuteScalar();
            con.Close();

            if (result == DBNull.Value || result == null)
            {
                return "Don't have data based on this month";
            }

            int total = Convert.ToInt32(result);
            return total.ToString("0");
        }
        public static string SumReservationsByMonthAndType(string month, string category)
        {
            SqlCommand cmd = new SqlCommand("SELECT SUM(TotalReservation) FROM HallReservationReport WHERE Month = @month AND ReservationType = @category", con);
            cmd.Parameters.AddWithValue("@month", month);
            cmd.Parameters.AddWithValue("@category", category);

            con.Open();
            object result = cmd.ExecuteScalar();
            con.Close();

            if (result == DBNull.Value || result == null)
            {
                return "No data found";
            }

            int total = Convert.ToInt32(result);
            return total.ToString();
        }





    }
}