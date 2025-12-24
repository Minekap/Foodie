using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace FoodiePointt
{
    internal class Login
    {
        private string email;
        private string password;

        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }

        public Login(string e, string p)
        {
            email = e;
            password = p;
        }

        public string verify()
        {
            string status = null;

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Email = @a AND Password = @b", con);
                cmd.Parameters.AddWithValue("@a", email);
                cmd.Parameters.AddWithValue("@b", password);

                int count = Convert.ToInt32(cmd.ExecuteScalar());

                if (count > 0)
                {
                    SqlCommand cmd2 = new SqlCommand("SELECT Role  FROM Users WHERE Email = @a AND Password = @b", con);
                    cmd2.Parameters.AddWithValue("@a", email);
                    cmd2.Parameters.AddWithValue("@b", password);

                    SqlCommand cmd3 = new SqlCommand("SELECT Username From Users WHERE Email = @a AND Password = @b", con);
                    cmd3.Parameters.AddWithValue("@a", email);
                    cmd3.Parameters.AddWithValue("@b", password);

                    SqlCommand cmd4 = new SqlCommand("SELECT Id From Users WHERE Email = @a AND Password = @b", con);
                    cmd4.Parameters.AddWithValue("@a", email);
                    cmd4.Parameters.AddWithValue("@b", password);

                    int customer_id = Convert.ToInt32(cmd4.ExecuteScalar());
                    string username = cmd3.ExecuteScalar().ToString();
                    string userrole = cmd2.ExecuteScalar().ToString();
                    if (userrole == "Admin")
                    {
                        Adminfunctionpage a = new Adminfunctionpage(username,customer_id);
                       
                        a.ShowDialog();
                        
                       
                    }
                    else if (userrole =="Manager")
                    {
                        Manager m = new Manager(username,customer_id);
                        m.ShowDialog();
                    }
                    else if (userrole =="Chef")
                    {
                        Chef c = new Chef(username,customer_id);
                        c.ShowDialog();
                    }
                    else if (userrole =="Reservation Coordinator")
                    {
                        ReservationCoordinator rc = new ReservationCoordinator(username,customer_id);
                        rc.ShowDialog();
                    }
                    else if (userrole == "Customer")
                    {
                        CustomerPage cc = new CustomerPage(username,customer_id);
                        cc.ShowDialog();
                    }

                }
                else
                    status = "Invalid password/username";
                con.Close();
                
                return status;
            }

            
        }
    }
}
