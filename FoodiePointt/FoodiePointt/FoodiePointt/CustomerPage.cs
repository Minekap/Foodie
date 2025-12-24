using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FoodiePointt
{
    public partial class CustomerPage : Form
    {
        private string username;
        private int customer_id;


        public string Username { get => username; set => username = value; }

        private decimal originalPrice = 0;
        public CustomerPage(string user, int id)
        {
            username = user;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dupquantity.SelectedIndex = 9;
            customer_id = id;
        }

        private void bncustomer_Click(object sender, EventArgs e)
        {
            pnmenu.Visible = true;
            pnmenu.BringToFront();
        }

        private void bnreservation_Click(object sender, EventArgs e)
        {
            pnrequest.Visible = true;
            pnrequest.BringToFront();
            dgvreservation.DataSource= Order.GetAllHalls();
            Order objl = new Order(customer_id);
            dgvreservationlist.DataSource= objl.reservationlist();
        }

        private void CustomerPage_Load(object sender, EventArgs e)
        {
            lbname.Text = username;
            dgvmenu.DataSource = MenuFood.Menulist();
            Order objl = new Order(customer_id);
            dgvvieworder.DataSource =objl.View();
        }

       
        private void bnstatus_Click_1(object sender, EventArgs e)
        {
            pnstatus.Visible = true;
            pnstatus.BringToFront();
            Order objls = new Order(customer_id);
            dgvvieworder.DataSource = objls.View();
            dgvviewfeedback.DataSource = objls.viewfeedback();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedCategory;
            bool available;
            cbmenu.Items.Clear();
            available = true;
            SelectedCategory = cbcategory.SelectedItem.ToString();
            cbmenu.Items.AddRange(Order.ProductID(SelectedCategory,available));

            dgvmenu.DataSource = Order.MenuItem(SelectedCategory);

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cbmenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbmenu.SelectedItem.ToString(), out int selectedmenu))
            {
                lbmenu.Text = Order.MenuName(selectedmenu, "Name");
                originalPrice = decimal.Parse(Order.MenuName(selectedmenu, "Price")); 
                lbprice.Text = originalPrice.ToString();
                UpdateTotalPrice();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void dupquantity_SelectedItemChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
        private void UpdateTotalPrice()
        {
            int quantity = int.Parse(dupquantity.Text);
            lbprice.Text = (originalPrice * quantity).ToString(); 
        }

        private void bnadd_Click(object sender, EventArgs e)
        {
            int id;
            string name;
            int quantity;
            decimal price;
            decimal finalprice;
            decimal totalsum = 0;
             

          
            if (cbcategory.SelectedItem != null &&
                cbmenu.SelectedItem != null &&
                !string.IsNullOrWhiteSpace(dupquantity.Text) &&
                !string.IsNullOrWhiteSpace(lbprice.Text))
            {
                id = int.Parse(cbmenu.SelectedItem.ToString());
                name = lbmenu.Text; 
                quantity = int.Parse(dupquantity.Text); 
                finalprice = decimal.Parse(lbprice.Text); 
                price = finalprice/quantity;

                
                dgvtotal.Rows.Add(id, name, price, quantity, finalprice);
                bnpay.Visible = true;
                foreach (DataGridViewRow amount in dgvtotal.Rows)
                {
                    if (amount.Cells["subtotal"].Value != null)
                    {
                        totalsum += Convert.ToDecimal(amount.Cells["subtotal"].Value);
                    }
                }
                lbfinalprice.Text = totalsum.ToString();

            }
            else
            {
                MessageBox.Show("All fields must be filled!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            




        }

        private void bnremove_Click(object sender, EventArgs e)
        {
            if (dgvtotal.Rows.Count > 0)
            {
                if (dgvtotal.SelectedRows.Count > 0)
                {
                    int rowIndex = dgvtotal.SelectedRows[0].Index;
                    dgvtotal.Rows.RemoveAt(rowIndex);
                }
                else
                {
                    MessageBox.Show("Please select a row to delete.");
                }
            }
            else
            {
                MessageBox.Show("You did not select order.");
            }
        }

        private void bnclear_Click(object sender, EventArgs e)
        {
            dgvtotal.Rows.Clear();

        }

        private void tbpayamount_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnpay_Click(object sender, EventArgs e)
        {
            decimal amount;
            decimal payamount;
            decimal charge;
            int MenuId;
            decimal finalprice;
            int quantity;
            bool result;
            bool orderresult = true;
            int order_id = 0;
            if (!decimal.TryParse(tbpayamount.Text, out payamount))
            {
                MessageBox.Show("Please enter a valid payment amount.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            payamount = Convert.ToDecimal(tbpayamount.Text.ToString());
            
            amount = Convert.ToDecimal(lbfinalprice.Text.ToString());
           

            charge = payamount - amount;
            if (payamount < amount)
            {
                MessageBox.Show("PLEASE PAY FULLY ", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Order objl1 = new Order(customer_id);
                order_id = objl1.createorderid(amount);
                if (order_id > 0)
                {
                    foreach (DataGridViewRow row in dgvtotal.Rows)
                    {
                        if (row.Cells["Category"].Value != null && row.Cells["Quantity"].Value != null
                            && row.Cells["Price"].Value != null)
                        {
                            quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            finalprice = Convert.ToDecimal(row.Cells["Subtotal"].Value);
                            MenuId = Convert.ToInt32(row.Cells["Id"].Value);

                            Order objl = new Order(customer_id);
                            result = objl.CreateOrder(order_id, MenuId, quantity, finalprice);

                            if (!result)
                            {
                                orderresult = false;
                            }



                        }
                    }
                }
                else
                {
                    return;
                }
                if (orderresult)
                {
                    MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    bnpay.Visible = false;
                    dgvtotal.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Some orders failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

             lbcharge.Text = charge.ToString();
              
             
            }
        }

        private void pnmenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void bndelete_Click(object sender, EventArgs e)
        {
            if (dgvvieworder.SelectedRows.Count > 0)
            {
                string row_name = "Order_id";
                int value = Convert.ToInt32(dgvvieworder.SelectedRows[0].Cells[row_name].Value);
                string status = dgvvieworder.SelectedRows[0].Cells["Status"].Value.ToString();
                if (status != "Completed")
                {
                    MessageBox.Show("You can only delete completed orders.", "Deletion Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string result = Order.Remove(value);
                    MessageBox.Show(result);
                    Order objls = new Order(customer_id);
                    dgvvieworder.DataSource = objls.View();
                }
      ;
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void bnenter_Click(object sender, EventArgs e)
        {
            int customerid = customer_id;
            string Request = tbrequest.Text;
            string Response = "Pending";

            if (string.IsNullOrEmpty(Request))
            {
                MessageBox.Show("Please enter feedback.");
                return;
            }

            Request objl = new Request(customerid, Request, Response);
            string result = objl.Submitrequest();
            MessageBox.Show(result);



        }

        private void bnsubmit_Click(object sender, EventArgs e)
        {
            int customerid = customer_id;
            if (string.IsNullOrWhiteSpace(tbfeedback.Text))
            {
                MessageBox.Show("Please enter feedback before submitting.");
                return;
            }

            string feedback = tbfeedback.Text;
            
            Order objl = new Order(customerid);
            string result = objl.addfeedback(feedback);
            MessageBox.Show(result);


        }

        private void bnprofile_Click(object sender, EventArgs e)
        {
            Editprofile objl = new Editprofile(customer_id,username);
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

    
    }
}
