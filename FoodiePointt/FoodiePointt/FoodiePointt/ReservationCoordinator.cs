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
    public partial class ReservationCoordinator : Form
    {
        private string username;
        private int RCid;

        public string Username { get => username; set => username = value; }
        public int RCid1 { get => RCid; set => RCid = value; }

        public ReservationCoordinator(string name, int id)
        {
            username = name;
            RCid = id; 
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void bnreservation_Click(object sender, EventArgs e)
        {
            bool available = true;
            pnhall.Visible = true;
            pnhall.BringToFront();
            dgvrc.DataSource = Reservation.viewreservation();
            cbcustomerid.Items.Clear();
            cbcustomerid.Items.AddRange(Reservation.CustomerID());
            cbhall.Items.Clear();
            cbhall.Items.AddRange(Reservation.HallId(available));
            dgvrc.DataSource = Reservation.viewreservation();


        }

        private void bnfeedback_Click(object sender, EventArgs e)
        {
            pnrequest.Visible = true; 
            pnrequest.BringToFront();
            dgvrequest.DataSource = Request.request();
        }

        private void ReservationCoordinator_Load(object sender, EventArgs e)
        {
            lbname.Text = username;
        }

        private void cbhall_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(cbhall.SelectedItem.ToString(), out int selectedid))
            {
                lbhallname.Text = Reservation.hallname(selectedid);
               
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bnadd_Click(object sender, EventArgs e)
        {
            int customerid, hallid, partysize;
            DateTime reservationdate;
            string status = null;
            int id = RCid;
            string result;
            if (cbcustomerid.SelectedItem == null)
            {
                MessageBox.Show("Please select a customer ID.");
                return;
            }
            if (cbhall.SelectedItem == null)
            {
                MessageBox.Show("Please select a hall.");
                return;
            }
            if (string.IsNullOrWhiteSpace(tbsize.Text) || !int.TryParse(tbsize.Text, out partysize))
            {
                MessageBox.Show("Please enter a valid party size.");
                return;
            }
            if (partysize > 50)
            {
                MessageBox.Show("Party Size too big");
                return;
            }
            customerid = Convert.ToInt32(cbcustomerid.SelectedItem.ToString());
            hallid = Convert.ToInt32(cbhall.SelectedItem.ToString());
            reservationdate = dtpreservation.Value.Date;
            if (rdbusy.Checked)
            {
                status = "Busy";
            }
            else if (rdavailable.Checked)
            {
                status = "Available";
            }
            else
            {
                MessageBox.Show("Please select a status.");
                return;
            }
            Reservation objl = new Reservation(customerid, hallid, partysize, reservationdate, status, id);
            result = objl.createreservation();
            MessageBox.Show(result);

            dgvrc.DataSource = Reservation.viewreservation();
            


        }

        private void bnedit_Click(object sender, EventArgs e)
        {
            if (dgvrc.SelectedRows.Count > 0)
            {
                int reservationid = Convert.ToInt32(dgvrc.SelectedRows[0].Cells["Reservation_id"].Value);
                int customerid = Convert.ToInt32(cbcustomerid.SelectedItem.ToString());
                int hallid = Convert.ToInt32(cbhall.SelectedItem.ToString());
                int partysize = Convert.ToInt32(tbsize.Text);
                DateTime reservationdate = dtpreservation.Value.Date;
                string status = null;

                if (partysize > 50)
                {
                    MessageBox.Show("Party Size too big");
                    return;
                }

                if (rdbusy.Checked)
                {
                    status = "Busy";
                }
                else if (rdavailable.Checked)
                {
                    status = "Complete";
                }
                else
                {
                    MessageBox.Show("Please select a value");
                    return;
                }

                Reservation obj = new Reservation(customerid, hallid, partysize, reservationdate, status, RCid);
                string success = obj.updatereservation(reservationid);
                MessageBox.Show(success);
                dgvrc.DataSource = Reservation.viewreservation();
            }
            else
            {
                MessageBox.Show("Please select a reservation to update.");
            }

        }

        private void bndelete_Click(object sender, EventArgs e)
        {
            if (dgvrc.SelectedRows.Count > 0)
            {
                int reservationid = Convert.ToInt32(dgvrc.SelectedRows[0].Cells["Reservation_id"].Value);
                string result = Reservation.deletereservation(reservationid);
                MessageBox.Show(result);
                dgvrc.DataSource = Reservation.viewreservation();
            }
            else
            {
                MessageBox.Show("Please select a row");
            }
        }

        private void bnfinalize_Click(object sender, EventArgs e)
        {
            if (dgvrc.SelectedRows.Count > 0)
            {
                int row = dgvrc.SelectedRows[0].Index;
                int reservationid = int.Parse(dgvrc.Rows[row].Cells["Reservation_id"].Value.ToString());
                int customer_id = int.Parse(dgvrc.Rows[row].Cells["Customer_id"].Value.ToString());
                int hallid = int.Parse(dgvrc.Rows[row].Cells["Hall_id"].Value.ToString());
                int partysize = int.Parse(dgvrc.Rows[row].Cells["PartySize"].Value.ToString());
                DateTime eventDate = Convert.ToDateTime(dgvrc.Rows[row].Cells["EventDate"].Value).Date;
                string status = dgvrc.Rows[row].Cells["Status"].Value.ToString();
                int rcid = int.Parse(dgvrc.Rows[row].Cells["By"].Value.ToString());
                if (status != "Complete")
                {
                    MessageBox.Show("Only finalize after the reservation finished");
                    return;
                }
                else
                {
                    Reservation objl = new Reservation(customer_id, hallid, partysize, eventDate, status, rcid);
                    string result = objl.finalize();
                    MessageBox.Show(result);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to update.");
            }
        }

        private void bnenter_Click(object sender, EventArgs e)
        {
            if(dgvrequest.SelectedRows.Count > 0)
            {
                int row = dgvrequest.SelectedRows[0].Index;
                int requestid = int.Parse(dgvrequest.Rows[row].Cells["Request_id"].Value.ToString());
                string message = dgvrequest.Rows[row].Cells["Message"].Value.ToString();
                int customerid = int.Parse(dgvrequest.Rows[row].Cells["Customer_id"].Value.ToString());
                string response = tbresponse.Text;
                if (response == null)
                {
                    MessageBox.Show("Please enter all value");
                }
                else
                {
                    Request objl = new Request(customerid, message, response);
                    string result = objl.reply(requestid);
                    MessageBox.Show(result);
                    dgvrequest.DataSource = Request.request();

                }
                
                
            }
            else
            {
                MessageBox.Show("Plese select a row to reply");
            }
        }

        private void bnprofile_Click(object sender, EventArgs e)
        {
            Editprofile objl = new Editprofile(RCid,username);
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
