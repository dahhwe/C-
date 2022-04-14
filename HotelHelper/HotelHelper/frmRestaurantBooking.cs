using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HotelHelper
{
    public partial class frmRestaurantBooking : Form
    {
        public frmRestaurantBooking()
        {
            InitializeComponent();
        }
        class RestaurantBookingClass
        {
            public int bookingID { get; set; }
            public string restaurantAvailable { get; set; }
        }

        private void frmRestaurantBooking_Load(object sender, EventArgs e)
        {
            populateComboBoxes();
        }

        private void populateComboBoxes()
        {
            
            List<RestaurantBookingClass> restaurantAvailable = new List<RestaurantBookingClass>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT bookingID, restaurantAvailable " +
            "FROM tblRestaurantBooking";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                if (dr[1].ToString() != "")
                {
                    restaurantAvailable.Add(new RestaurantBookingClass { bookingID = Convert.ToInt32(dr[0].ToString()), restaurantAvailable = dr[1].ToString()});
                }
                
            }
            cmbRestaurantName.DisplayMember = "restaurantAvailable";
            cmbRestaurantName.ValueMember = "bookingID";
            cmbRestaurantName.DataSource = restaurantAvailable;
        }

        private void cmbNumberOfGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateTablesAvailable();
        }

        private void updateTablesAvailable()
        {
            resetallButtons();
            if (Convert.ToInt32(cmbNumberOfGuests.Text) <= 2)
            {
                //btnTable1.BackColor = Color.Aqua;
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        if (c.Size == new Size(93, 89))
                        {
                            c.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
            else if (Convert.ToInt32(cmbNumberOfGuests.Text) >= 2 && Convert.ToInt32(cmbNumberOfGuests.Text) <= 6)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        if (c.Size == new Size(176, 89))
                        {
                            c.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
            else
            {
                foreach (Control c in this.Controls)
                {
                    if (c is Button)
                    {
                        if (c.Size == new Size(308, 89) || c.Size == new Size(93, 251))
                        {
                            c.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
            
        }

        private void resetallButtons()
        {
            foreach(Control c in this.Controls)
            {
                if (c is Button)
                {
                    if (c.Name.StartsWith("btnTable"))
                    {
                        c.BackColor = Color.Tan;
                    }
                }
            }
        }

        private void btnTable1_Click(object sender, EventArgs e)
        {
            if (!(btnTable1.BackColor == Color.LightGreen))
            {
                MessageBox.Show("This table is not available for you, please choose from green tables: ");
            }
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {

        }

        private void btnTable3_Click(object sender, EventArgs e)
        {

        }

        private void btnTable4_Click(object sender, EventArgs e)
        {

        }

        private void btnTable5_Click(object sender, EventArgs e)
        {

        }

        private void btnTable6_Click(object sender, EventArgs e)
        {

        }

        private void btnTable7_Click(object sender, EventArgs e)
        {

        }

        private void btnTable8_Click(object sender, EventArgs e)
        {

        }

        private void btnTable9_Click(object sender, EventArgs e)
        {

        }

        private void btnTable10_Click(object sender, EventArgs e)
        {

        }

        private void btnTable11_Click(object sender, EventArgs e)
        {

        }
    }
}
