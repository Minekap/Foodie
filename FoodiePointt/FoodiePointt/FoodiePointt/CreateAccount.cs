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
    internal class CreateAccount
    {
        private string name;
        private string email;
        private string password;
        private string role;
        private DateTime create_at;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public DateTime Create_at { get => create_at; set => create_at = value; }
        public static SqlConnection Con { get => con; set => con = value; }

        public CreateAccount(string n, string e, string p, string r)
        {
            name = n;
            email = e;
            password = p;
            role = r;
            create_at = DateTime.Now;
        }

        public string Addaccount()
        {
            if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password) ||
            string.IsNullOrWhiteSpace(role))
            {
                return "All fields are required.";
            }

            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @name  Or Email = @email", con);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                status = "This account has been chosen";
            }
            else
            {
                SqlCommand cmd1 = new SqlCommand("INSERT INTO Users(Username,Email,Password,Role,Date) VALUES (@username,@email,@password,@role,@created_at)", con);
                cmd1.Parameters.AddWithValue("@username", name);
                cmd1.Parameters.AddWithValue("@email", email);
                cmd1.Parameters.AddWithValue("@password", password);
                cmd1.Parameters.AddWithValue("@role", role);
                cmd1.Parameters.AddWithValue("@created_at", create_at);

                int result = cmd1.ExecuteNonQuery();

                if (result > 0)
                {
                    status = "Registration Successful.";
                }
                else
                {
                    status = "Unable to register.";
                }
            }

            con.Close();
            return status;
        }

        public string update(int id)
        {
            if (string.IsNullOrWhiteSpace(name) ||
            string.IsNullOrWhiteSpace(email) ||
            string.IsNullOrWhiteSpace(password) ||
            string.IsNullOrWhiteSpace(role))
            {
                return "All fields are required.";
            }
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @email AND Id != @id", con);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@id", id);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count >0)
            {
                status = "This account existed";
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("update Users set Username = @name, Email = @email,Password = @password, Role = @role where Id =@id", con);
                cmd2.Parameters.AddWithValue("@name", name);
                cmd2.Parameters.AddWithValue("@email", email);
                cmd2.Parameters.AddWithValue("@password", password);
                cmd2.Parameters.AddWithValue("@role", role);
                cmd2.Parameters.AddWithValue("@id",id);
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

        public static DataTable userlist()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT Id,Username, Email,Password,Role,Date FROM Users", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();
            return dt;
        }

        public static DataTable viewfeedbackadmin()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Feedback ", con);
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            dt.Load(rd);
            con.Close();

            return dt;
        }
        public string editprofile(int id)
        {
            string status;
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Count(*) From Users WHERE Email =@email And Id != @id",con);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@id", id);
            int count = Convert.ToInt32(cmd.ExecuteScalar());

            if (count > 0)
            {
                status = "This email is alrrady use by other people.";
            }
            else
            {
                SqlCommand cmd2 = new SqlCommand("UPDATE Users SET Username = @name, Email = @email, Password = @password WHERE Id = @id", con);
                cmd2.Parameters.AddWithValue("@name", name);
                cmd2.Parameters.AddWithValue("@email", email);
                cmd2.Parameters.AddWithValue("@password", password);
                cmd2.Parameters.AddWithValue("@id", id);

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
