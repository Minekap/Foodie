using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Drawing;

namespace FoodiePointt
{
    internal class Delete
    {
        private string name;
        private string tablename;
        private string row_name;
        static SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());

        public string Name { get => name; set => name = value; }
        public static SqlConnection Con { get => con; set => con = value; }
        public string Tablename { get => tablename; set => tablename = value; }
        public string Row_name { get => row_name; set => row_name = value; }

        public Delete(string n,string t,string r)
        {
            name = n; 
            tablename = t;
            row_name = r;
        }

        public  string Delete_user()
        {
            string status;
            con.Open();
            string query = "DELETE FROM " + tablename + " WHERE " + row_name + " = @name";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", name);
            int result = cmd.ExecuteNonQuery();
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
    }


}
