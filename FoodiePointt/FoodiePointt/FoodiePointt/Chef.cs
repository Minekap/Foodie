using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FoodiePointt
{
    public partial class Chef : Form
    {
        private string chefname;
        private int ChefId;
        public Chef(string username, int Id)
        {
            chefname = username;
            ChefId = Id;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Chef_Load(object sender, EventArgs e)
        {

  
            lbname.Text = chefname;
            dgvpendingorder.DataSource = chefclass.vieworder("Pending");
            cbid.Items.AddRange(chefclass.order("Pending"));

        }

        private void bnfinish_Click(object sender, EventArgs e)
        {
            pnfinished.Visible = true;
            pnfinished.BringToFront();
            cbselectid.Items.Clear();
            dgvfinal.DataSource = chefclass.vieworder("In Progress");
            cbselectid.Items.AddRange(chefclass.order("In Progress"));
        }

        private void bninventory_Click(object sender, EventArgs e)
        {
            pninventory.Visible = true;
            pninventory.BringToFront();
            dgvinventory.DataSource = Inventory.viewinventory();
        }

        private void bnaccepetorder_Click(object sender, EventArgs e)
        {
            pnaccept.Visible = true;
            pnaccept.BringToFront();
        }

        private void bnaccept_Click(object sender, EventArgs e)
        {
            int id;
            string result;
            if (!int.TryParse(cbid.Text, out id))
            {
                MessageBox.Show("Please choose Id properly");
                return;
            }

            if (cbid.SelectedItem != null)
            {
                id = Convert.ToInt32(cbid.SelectedItem.ToString());
            }

            chefclass objl = new chefclass(id);
            result = objl.acceptorder();
            MessageBox.Show(result);

            cbid.Items.Clear();
            cbid.Items.AddRange(chefclass.order("Pending"));
            dgvpendingorder.DataSource = chefclass.vieworder("Pending");
        }

        private void pnfinished_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bnfinal_Click(object sender, EventArgs e)
        {
            int id;
            string result;
            if (!int.TryParse(cbselectid.Text, out id))
            {
                MessageBox.Show("Please choose Id properly");
                return;
            }

            if (cbid.SelectedItem != null)
            {
                id = Convert.ToInt32(cbselectid.SelectedItem.ToString());
            }

            
            chefclass objl = new chefclass(id);
            result = objl.finalizeorder(ChefId);
            cbselectid.Items.Clear();
            dgvfinal.DataSource = chefclass.vieworder("In Progress");
            cbselectid.Items.AddRange(chefclass.order("In Progress"));
            MessageBox.Show(result);

        }

        private void bnprofile_Click(object sender, EventArgs e)
        {
            Editprofile objl = new Editprofile(ChefId,chefname);
            objl.ShowDialog();
        }

        private void bnenter_Click(object sender, EventArgs e)
        {
            string result;
            string inventoryname = tbname.Text;
            int quantity;
            if (cbcategory.SelectedItem == null)
            {
                MessageBox.Show("Please select a category.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string category = cbcategory.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(inventoryname) || string.IsNullOrWhiteSpace(tbquantity.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(tbquantity.Text, out quantity))
            {
                MessageBox.Show("Please enter a valid numeric quantity.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Inventory objl = new Inventory(inventoryname, quantity, category);
            result = objl.Addinventory();
            MessageBox.Show(result);
            dgvinventory.DataSource = Inventory.viewinventory();

        }

        private void bnupdate_Click(object sender, EventArgs e)
        {
            if (dgvinventory.SelectedRows.Count > 0)
            {
                int row = dgvinventory.SelectedRows[0].Index;

                
                if (dgvinventory.Rows[row].Cells["Ingredient_id"].Value == null ||
                    string.IsNullOrEmpty(dgvinventory.Rows[row].Cells["Ingredient_id"].Value.ToString()))
                {
                    MessageBox.Show("Selected row contains invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvinventory.Rows[row].Cells["Ingredient_id"].Value.ToString());

                string result;
                string inventoryname = tbname.Text;
                string category = "nothing here";
                int quantity;

                if (string.IsNullOrEmpty(inventoryname) || string.IsNullOrEmpty(tbquantity.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(tbquantity.Text, out quantity))
                {
                    MessageBox.Show("Please enter a valid value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Inventory objl = new Inventory(inventoryname, quantity, category);
                result = objl.updateinventory(id);
                MessageBox.Show(result);
                dgvinventory.DataSource = Inventory.viewinventory();
            }
            else
            {
                MessageBox.Show("Please select a row to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bndelete_Click(object sender, EventArgs e)
        {
            if (dgvinventory.SelectedRows.Count > 0)
            {
                string row_name = "Name";
                string value = dgvinventory.SelectedRows[0].Cells[row_name].Value.ToString();
                string table = "Inventory";

                Delete objl = new Delete(value, table, row_name);

                string result = objl.Delete_user();
                MessageBox.Show(result);
                dgvinventory.DataSource = Inventory.viewinventory();
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void bnsearch_Click(object sender, EventArgs e)
        {
            string search;
            if (string.IsNullOrEmpty(tbsearch.Text.ToString()))
            {
                MessageBox.Show("Please enter a value to search");
            }
            else
            {
                search = tbsearch.Text.ToString();
                dgvinventory.DataSource = Inventory.viewselected(search);
            }
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

        private void cbid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orderid;
            orderid = Convert.ToInt32(cbid.SelectedItem.ToString());
            chefclass objl = new chefclass(orderid);
            ArrayList items = objl.MenuName();
            lbOrder.Items.Clear();
            foreach (string i in  items)
            {
                lbOrder.Items.Add(i);
            }
        
        }
    }
}