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
    public partial class frmAdminMain : Form
    {
        private int userID;
        private int customerID;

        public frmAdminMain(int userID_)
        {
            userID = userID_;
            InitializeComponent();
        }

        class customersOrderedClass
        {
            public int customerID { get; set; }
            public string fullName { get; set; }
        }

        private void frmAdminMain_Load(object sender, EventArgs e)
        {
            populateAdminName();
            populateComboBox();
            //populateCustomersOrder(customerID);
        }

        private void populateOrders()
        {
            throw new NotImplementedException();
        }

        private void populateComboBox()
        {
            List<customersOrderedClass> customersOrdered = new List<customersOrderedClass>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT tblCustomerInfo.customerID, tblCustomerInfo.forename, tblCustomerInfo.surname " +
                     "FROM(tblCustomerInfo INNER JOIN " +
                     "tblRoomService ON tblCustomerInfo.customerID = tblRoomService.customerID) " +
                     "GROUP BY tblCustomerInfo.customerID, tblCustomerInfo.forename, tblCustomerInfo.surname ";

            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                customersOrdered.Add(new customersOrderedClass { customerID = Convert.ToInt32(dr[0].ToString()), fullName = (dr[1].ToString() + " " + dr[2].ToString()) });
                customerID = Convert.ToInt32(dr[0].ToString());
            }
            cmbCustomersOrdered.DisplayMember = "fullName";
            cmbCustomersOrdered.ValueMember = "customerID";
            cmbCustomersOrdered.DataSource = customersOrdered;
        }

        private void populateCustomersOrder(int cmbCustomerID)
        {

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            int FoodTimesQuantityPrice;
            int totalCost = 0;
            string sqlStr;
            dbConnector.Connect();
            // populates list View with food ordered specificly by a customer which is selected in the combo box
            sqlStr = "SELECT tblItems.price, tblItems.Description, tblServiceItem.quantity " +
                     "FROM(((tblItems INNER JOIN " +
                     "tblServiceItem ON tblItems.itemID = tblServiceItem.itemID) INNER JOIN " +
                     "tblRoomService ON tblServiceItem.serviceID = tblRoomService.serviceID) INNER JOIN " +
                     "tblCustomerInfo ON tblRoomService.customerID = tblCustomerInfo.customerID) " +
                     "WHERE(tblRoomService.customerID = " + cmbCustomerID + ")";
            dr = dbConnector.DoSQL(sqlStr);
            lstCustomersOrder.Items.Clear();
            while (dr.Read())
            {
                lstCustomersOrder.Items.Add(dr[1].ToString());
                lstCustomersOrder.Items[lstCustomersOrder.Items.Count - 1].SubItems.Add(dr[2].ToString());
                //remove repeated foor from the listView and increase the quantity
                for (int i = 0; i < lstCustomersOrder.Items.Count; i++)
                {
                    if (lstCustomersOrder.Items[i].Text == dr[1].ToString())
                    {
                        lstCustomersOrder.Items[i].SubItems[1].Text = (Convert.ToInt32(lstCustomersOrder.Items[i].SubItems[1].Text) + Convert.ToInt32(dr[2])).ToString();
                    }
                    else
                    {

                    }
                }

                //    //lstOrder.Items[i].SubItems[2].Text = (Convert.ToInt32(lstOrder.Items[i].SubItems[2].Text) + 1).ToString();
                //    //lstOrder.Items[i].SubItems[3].Text = (Convert.ToInt32(lstOrder.Items[i].SubItems[3].Text) + Convert.ToInt32(dr[3].ToString())).ToString();

                //serviceID = Convert.ToInt32(dr[1]);
                FoodTimesQuantityPrice = Convert.ToInt32(dr[0]) * Convert.ToInt32(dr[2]);
                totalCost += FoodTimesQuantityPrice;

            }
            lblTotalPrice.Text = totalCost.ToString();
            //lblTotalCost += totalCost.ToString();
            dbConnector.close();
        }

        private void populateAdminName()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT customerID, forename, surname " +
                "FROM tblCustomerInfo " +
                "WHERE (customerID = " + userID + ")";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                lblAdminsFullName.Text = "Welcome back: " + dr[1].ToString() + " " + dr[2].ToString();
            }
            dbConnector.close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings(userID);
            frmSettings.Show();
        }

        private void cmbCustomersOrdered_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCustomersOrder.Items.Clear();
            populateCustomersOrder(Convert.ToInt32(cmbCustomersOrdered.SelectedValue));
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain(userID);
            frm.Show();
        }
    }
}
