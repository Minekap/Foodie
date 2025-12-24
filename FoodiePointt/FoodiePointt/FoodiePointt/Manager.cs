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
    public partial class Manager : Form
    {
        private string managername;
        private int managerid;

        public string Managername { get => managername; set => managername = value; }
        public int Managerid { get => managerid; set => managerid = value; }

        public Manager(string name,int id)
        {
            managername = name;
            managerid = id;

            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void Manager_Load(object sender, EventArgs e)
        {
            dgvmenu.DataSource = MenuFood.Menulist();
            lbmanagername.Text = Managername;  
        }

        private void bnmenu_Click(object sender, EventArgs e)
        {
            pnmenu.Visible = true;
            pnmenu.BringToFront();
            dgvmenu.DataSource = MenuFood.Menulist();
        }

        private void bnhall_Click(object sender, EventArgs e)
        {
            pnhall.Visible = true;
            pnhall.BringToFront();
            dgvhall.DataSource = Hall.halllist();
        }

        private void bnreport_Click(object sender, EventArgs e)
        {
            pnreport.Visible = true;
            pnreport.BringToFront();
            dgvreservation.DataSource = Reservation.viewreport();
        }

        private void bnenter_Click(object sender, EventArgs e)
        {
            bool available = false;
            decimal price;
            if (!decimal.TryParse(tbprice.Text, out price))
            {
                MessageBox.Show("Invalid price. Please enter a valid number.");
                return;
            }

            if (rbyes.Checked)
            {
                available = true;
            }
            else if (rbno.Checked)
            {
                available = false;
            }
            MenuFood objl = new MenuFood(tbfood.Text, tbdescription.Text, price, cbcategory.Text, available);
            string result = objl.CreateMenu();
            MessageBox.Show(result);
            dgvmenu.DataSource = MenuFood.Menulist();
        }

        private void bnupdate_Click(object sender, EventArgs e)
        {
            if (dgvmenu.SelectedRows.Count > 0)
            {
                int row = dgvmenu.SelectedRows[0].Index;
                int menuid = Convert.ToInt32(dgvmenu.Rows[row].Cells["Item_id"].Value.ToString());
                string Category = dgvmenu.Rows[row].Cells["Category"].Value.ToString();
                string Name = dgvmenu.Rows[row].Cells["Name"].Value.ToString();
                string Description = dgvmenu.Rows[row].Cells["Description"].Value.ToString();
                decimal price = decimal.Parse(dgvmenu.Rows[row].Cells["Price"].Value.ToString());
                bool available = Convert.ToBoolean(dgvmenu.Rows[row].Cells["Availability"].Value);
                if (price <= 0)
                {
                    MessageBox.Show("Please enter correct price");
                }
                else
                {
                    MenuFood objl = new MenuFood(Name, Description, price, Category, available);
                    string result = objl.UpdateMenu(menuid);
                    MessageBox.Show(result);

                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void bndelete_Click(object sender, EventArgs e)
        {
            if (dgvmenu.SelectedRows.Count > 0)
            {
                string row_name = "Name";
                string value = dgvmenu.SelectedRows[0].Cells[row_name].Value.ToString();
                string table = "MenuItems";

                Delete objl = new Delete(value, table, row_name);

                string result = objl.Delete_user();
                MessageBox.Show(result);
                dgvmenu.DataSource = MenuFood.Menulist();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void gbacc_Enter(object sender, EventArgs e)
        {

        }

       

        private void bnedit_Click_1(object sender, EventArgs e)
        {
            if (dgvhall.SelectedRows.Count > 0)
            {
                int row = dgvhall.SelectedRows[0].Index;
                int hallid = int.Parse(dgvhall.Rows[row].Cells["Hall_id"].Value.ToString());
                string Hall_name = dgvhall.Rows[row].Cells["Hall_name"].Value.ToString();
                int Capacity = int.Parse(dgvhall.Rows[row].Cells["Capacity"].Value.ToString());
                string PartyType = dgvhall.Rows[row].Cells["PartyType"].Value.ToString();
                bool available = Convert.ToBoolean(dgvhall.Rows[row].Cells["Availability"].Value);


                if (Capacity <= 0)
                {
                    MessageBox.Show("Please enter correct capacity");
                }
                else
                {
                    Hall objl = new Hall(Hall_name, Capacity, PartyType, available);
                    string result = objl.UpdateHall(hallid);
                    MessageBox.Show(result);

                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void bnadd_Click_1(object sender, EventArgs e)
        {
            int capacity;
            bool available = false;
            if (!int.TryParse(tbcapacity.Text, out capacity))
            {
                MessageBox.Show("Invalid value. Please enter a valid number.");
                return;
            }
            if (rbcheck.Checked)
            {
                available = true;
            }
            else if (rbcheck2.Checked)
            {
                available = false;
            }
            Hall objl = new Hall(tbhallname.Text, capacity, cbtype.Text,available);
            string result = objl.createhall();
            MessageBox.Show(result);
            dgvhall.DataSource = Hall.halllist();
        }

        private void bnremove_Click_1(object sender, EventArgs e)
        {
            if (dgvhall.SelectedRows.Count > 0)
            {
                string row_name = "Hall_name";
                string value = dgvhall.SelectedRows[0].Cells[row_name].Value.ToString();
                string table = "Hall";

                Delete objl = new Delete(value, table, row_name);

                string result = objl.Delete_user();
                MessageBox.Show(result);
                dgvhall.DataSource = Hall.halllist();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void cbmonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            string month;
            month = cbmonth.SelectedItem.ToString();
            dgvreservation.DataSource = Reservation.ViewRecordByMonth(month);
            lbrecord.Text = Reservation.ReservationMonth(month);
        }

        private void cbhallcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category;
            category = cbhallcategory.SelectedItem.ToString();
            dgvreservation.DataSource = Reservation.ViewRecordByCategory(category);
            lbrecord.Text = Reservation.SumReservationCategory(category);
        }

        private void bnenter1_Click(object sender, EventArgs e)
        {
            string category;
            string month;
            category = cbhallcategory.SelectedItem.ToString();
            month = cbmonth.SelectedItem.ToString();
            dgvreservation.DataSource = Reservation.ViewRecordByMonthAndType(month,category);
            lbrecord.Text = Reservation.SumReservationsByMonthAndType(month,category);
        }

        private void bnprofile_Click(object sender, EventArgs e)
        {
            Editprofile objl = new Editprofile(managerid,managername);
            objl.ShowDialog();
        }

        private void bnlogout_Click(object sender, EventArgs e)
        {
            LoginPage objl = new LoginPage();
            this.Hide();
            objl.ShowDialog();
        }

        private void bnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
