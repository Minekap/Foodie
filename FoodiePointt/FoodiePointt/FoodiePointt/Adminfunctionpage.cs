using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FoodiePointt
{
    public partial class Adminfunctionpage : Form
    {
        private string adminname;
        private int adminid;

        public int Adminid { get => adminid; set => adminid = value; }

        public Adminfunctionpage(string a, int id)
        {
            adminname = a;
            adminid = id;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void bnenter_Click(object sender, EventArgs e)
        {
            string stat;

            CreateAccount objl = new CreateAccount(tbname.Text, tbmail.Text, tbpass.Text, cbroles.Text);
            stat = objl.Addaccount();
            MessageBox.Show(stat);
            dgvuser.DataSource = CreateAccount.userlist();
        }

        private void bnupdate_Click_1(object sender, EventArgs e)
        {
            if (dgvuser.SelectedRows.Count > 0)
            {
                var textinfo = CultureInfo.CurrentCulture.TextInfo;
                int row = dgvuser.SelectedRows[0].Index;
                int id = Convert.ToInt32(dgvuser.Rows[row].Cells["Id"].Value.ToString());  
                string Username = dgvuser.Rows[row].Cells["Username"].Value.ToString();
                string Email = dgvuser.Rows[row].Cells["Email"].Value.ToString();
                string Password = dgvuser.Rows[row].Cells["Password"].Value.ToString();
                string Role = dgvuser.Rows[row].Cells["Role"].Value.ToString();

                Role = textinfo.ToTitleCase(Role);
                if (Role == "Admin" || Role == "Manager" || Role == "Chef" || Role == "Reservation Coordinator" || Role == "Customer")
                {
                    CreateAccount objl = new CreateAccount(Username,Email,Password,Role);
                    string result = objl.update(id);
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Please enter correct role");
                }



            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }

        }
        private void Adminfunctionpage_Load(object sender, EventArgs e)
        {
            label4.Text = adminname;
            dgvuser.DataSource = CreateAccount.userlist();
            dgvfeedback.DataSource = CreateAccount.viewfeedbackadmin();
        }

        private void bndelete_Click_1(object sender, EventArgs e)
        {
            if (dgvuser.SelectedRows.Count > 0)
            {
                string row_name = "Username";
                string value = dgvuser.SelectedRows[0].Cells[row_name].Value.ToString();
                string table = "Users";       
                
                Delete objl = new Delete(value,table,row_name);

                string result = objl.Delete_user(); 
                dgvuser.DataSource = CreateAccount.userlist(); 
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void gbacc_Enter(object sender, EventArgs e)
        {

        }

     

        private void bnadd_Click(object sender, EventArgs e)
        {
            pnaccount.Visible = true;
            pnaccount.BringToFront();
        }

        private void bnfeedback_Click(object sender, EventArgs e)
        {
            pnfeedback.Visible = true;
            pnfeedback.BringToFront();
            dgvfeedback.DataSource = CreateAccount.viewfeedbackadmin();
        }

        private void bnsale_Click(object sender, EventArgs e)
        {
            pnsale.Visible = true;
            pnsale.BringToFront();
            dgvsale.DataSource = Sale.viewsale();
            cbchefid.Items.Clear();
            cbchefid.Items.AddRange(Sale.ChefID());

        }

        private void bnsearch_Click(object sender, EventArgs e)
        {
            if (dgvfeedback.SelectedRows.Count > 0)
            {
                int row = dgvfeedback.SelectedRows[0].Index;
                string Message = dgvfeedback.Rows[row].Cells["Message"].Value.ToString();
                lbfeedback.Text = Message;
                
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void pnfeedback_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnsale_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month;
            month = cbmonth.SelectedItem.ToString();
            dgvsale.DataSource = Sale.ViewSalesByMonth(month);
            lbsale.Text = Sale.SaleMonth(month);
        }

      

        private void bnenter1_Click(object sender, EventArgs e)
        {
            int chefid;
            string category;
            string month;
            if (cbmonth.SelectedItem == null || cbmenutype.SelectedItem == null || cbchefid.SelectedItem == null)
            {
                MessageBox.Show("Please select values for all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            month = cbmonth.SelectedItem.ToString();
            category = cbmenutype.SelectedItem.ToString();
            chefid = Convert.ToInt32(cbchefid.SelectedItem.ToString());

            Sale objl = new Sale(chefid);
            dgvsale.DataSource = objl.ViewSales(category, month);
            lbsale.Text = objl.SaleBasedOnEverything(category, month);
        }

        private void cbchefid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int chefid;
            chefid = Convert.ToInt32(cbchefid.SelectedItem.ToString());
            Sale objl = new Sale(chefid);
            lbchefname.Text = objl.chefname();
            dgvsale.DataSource = objl.viewchefsale();
            lbsale.Text = objl.SaleChef();


        }

        private void cbmenutype_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category;
            category = cbmenutype.SelectedItem.ToString();
            dgvsale.DataSource = Sale.ViewSalesByCategory(category);
            lbsale.Text = Sale.SaleCategory(category);
        }

   

        private void bnprofile_Click(object sender, EventArgs e)
        {
            Editprofile objl = new Editprofile(adminid,adminname);
            objl.ShowDialog();
            
        }

        private void bnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnlogout_Click(object sender, EventArgs e)
        {
            LoginPage objl = new LoginPage();
            this.Hide();
            objl.ShowDialog();
        }

        private void pnselectfunction_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
