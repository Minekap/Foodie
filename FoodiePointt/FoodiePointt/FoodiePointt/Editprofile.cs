using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodiePointt
{
    public partial class Editprofile : Form
    {
        private int editid;
        private string username;    
        public int Editid { get => editid; set => editid = value; }
        public string Name1 { get => username; set => username = value; }

        public Editprofile(int id,string name)
        {
            editid = id;
            username = name;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            tbusername.Text = username;
        }

        private void bnupdate_Click(object sender, EventArgs e)
        {
            string name = tbusername.Text;
            string password = tbpassword.Text;
            string email = tbemail.Text;
            string role = "Template";
            CreateAccount objl = new CreateAccount(name, email, password,role);
            string result = objl.editprofile(editid);
            MessageBox.Show(result);
        }

        private void Editprofile_Load(object sender, EventArgs e)
        {

        }
    }
}
