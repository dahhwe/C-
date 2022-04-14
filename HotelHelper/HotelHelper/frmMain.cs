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
    public partial class frmMain : Form
    {
        private int userID;
        public frmMain(int userID_)
        {
            userID = userID_;
            InitializeComponent();
        }

        class ActivityClass
        {
            public int activityID { get; set; }
            public string activity { get; set; }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            populateComboBoxes();
            populateCustomerName();
            populateListView();
            
        }

        private void populateListView()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            int FoodTimesQuantityPrice;
            string sqlStr;
            dbConnector.Connect();
            // populates list View with food ordered specificly by a customer which is selected in the combo box
            sqlStr = "SELECT tblItems.price, tblItems.Description, tblServiceItem.quantity " +
                     "FROM(((tblItems INNER JOIN " +
                     "tblServiceItem ON tblItems.itemID = tblServiceItem.itemID) INNER JOIN " +
                     "tblRoomService ON tblServiceItem.serviceID = tblRoomService.serviceID) INNER JOIN " +
                     "tblCustomerInfo ON tblRoomService.customerID = tblCustomerInfo.customerID) " +
                     "WHERE(tblRoomService.customerID = " +userID + ")";
            dr = dbConnector.DoSQL(sqlStr);
            //lstFoodOrdered.Items.Clear();
            while (dr.Read())
            {
                FoodTimesQuantityPrice = Convert.ToInt32(dr[0]) * Convert.ToInt32(dr[2]);
                lstFoodOrdered.Items.Add(dr[1].ToString());
                lstFoodOrdered.Items[lstFoodOrdered.Items.Count - 1].SubItems.Add(dr[2].ToString());
            }
            dbConnector.close();
            if (lstFoodOrdered.Items.Count == 0)
            {
                lblFoodDeliveryStatus.Text = "Your order is empty";
            }
            
        }

    private void populateCustomerName()
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
                lblCustomerFullName.Text = "Welcome back " + dr[1].ToString() + " " + dr[2].ToString();
            }
            dbConnector.close();
        }

        private void setCurrentTime()
        {
            lblCurrentTIme.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = "Today is: " + DateTime.Now.ToLongDateString();
            
        }

        private void populateComboBoxes()
        {
            List<ActivityClass> activityMorning = new List<ActivityClass>();
            List<ActivityClass> activityLunch = new List<ActivityClass>();
            List<ActivityClass> activityNoon = new List<ActivityClass>();
            List<ActivityClass> activityEvening = new List<ActivityClass>();
            List<ActivityClass> activityLateEvening = new List<ActivityClass>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT activityID, activity " +
                " FROM tblActivities";
            //sqlStr = "SELECT activityID, activity, [Time]" +
            //         " FROM Activities " +
            //         "WHERE([Time] = #11/22/2019 09:00:00 AM#)";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                activityMorning.Add(new ActivityClass { activityID = Convert.ToInt32(dr[0]), activity = dr[1].ToString() });
                activityLunch.Add(new ActivityClass { activityID = Convert.ToInt32(dr[0]), activity = dr[1].ToString() });
                activityNoon.Add(new ActivityClass { activityID = Convert.ToInt32(dr[0]), activity = dr[1].ToString() });
                activityEvening.Add(new ActivityClass { activityID = Convert.ToInt32(dr[0]), activity = dr[1].ToString() });
                activityLateEvening.Add(new ActivityClass { activityID = Convert.ToInt32(dr[0]), activity = dr[1].ToString() });
            }
            // must be repeated, otherwise combo boxes become grouped
            if (DateTime.Now.Hour <= 9) //&& DateTime.Now.Minute <= 45)
            {
                cmbActivityMorning.DisplayMember = "activity";
                cmbActivityMorning.ValueMember = "activityID";
                cmbActivityMorning.DataSource = activityMorning;
            }
            else
            {
                cmbActivityMorning.ForeColor = Color.Red;
                cmbActivityMorning.Text = "UNAVAILABLE";
            }

            if (DateTime.Now.Hour < 13) // && DateTime.Now.Minute <= 15)
            {
                cmbActivityLunch.DisplayMember = "activity";
                cmbActivityLunch.ValueMember = "activityID";
                cmbActivityLunch.DataSource = activityLunch;
            }
            else
            {
                cmbActivityLunch.ForeColor = Color.Red;
                cmbActivityLunch.Text = "UNAVAILABLE";
            }

            if (DateTime.Now.Hour < 18) // && DateTime.Now.Minute <= 15)
            {
                cmbActivityNoon.DisplayMember = "activity";
                cmbActivityNoon.ValueMember = "activityID";
                cmbActivityNoon.DataSource = activityNoon;
            }
            else
            {
                cmbActivityNoon.ForeColor = Color.Red;
                cmbActivityNoon.Text = "UNAVAILABLE";
            }

            if (DateTime.Now.Hour < 20) //&& DateTime.Now.Minute <= 45)
            {
                cmbActivityEvening.DisplayMember = "activity";
                cmbActivityEvening.ValueMember = "activityID";
                cmbActivityEvening.DataSource = activityEvening;
            }
            else
            {
                cmbActivityEvening.ForeColor = Color.Red;
                cmbActivityEvening.Text = "UNAVAILABLE";
            }

            if (DateTime.Now.Hour < 21) // && DateTime.Now.Minute <= 45)
            {
                cmbActivityLateEvening.DisplayMember = "activity";
                cmbActivityLateEvening.ValueMember = "activityID";
                cmbActivityLateEvening.DataSource = activityLateEvening;
            }
            else
            {
                cmbActivityLateEvening.ForeColor = Color.Red;
                cmbActivityLateEvening.Text = "UNAVAILABLE";
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            frmSettings frmSettings = new frmSettings(userID);
            frmSettings.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            setCurrentTime();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool changeOccured = false;
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            //string sqlStr = "UPDATE tblActivities SET ";
            string sqlStr = "";
            
            if (cmbActivityMorning.Text != "UNAVAILABLE")
            {
                changeOccured = true;
                dbConnector.Connect();
                sqlStr = "UPDATE tblActivities SET customersChoice ='" + cmbActivityMorning.Text + "' " +
                "WHERE (activityID = 1) ";
                dr = dbConnector.DoSQL(sqlStr);
                dbConnector.DoDML(sqlStr);
                dbConnector.close();
            }
            if (cmbActivityLunch.Text != "UNAVAILABLE")
            {
                changeOccured = true;
                dbConnector.Connect();
                sqlStr = "UPDATE tblActivities SET customersChoice ='" + cmbActivityLunch.Text + "' " +
                "WHERE (activityID = 2) ";
                dr = dbConnector.DoSQL(sqlStr);
                dbConnector.DoDML(sqlStr);
                dbConnector.close();
            }
            if (cmbActivityNoon.Text != "UNAVAILABLE")
            {
                changeOccured = true;
                dbConnector.Connect();
                sqlStr = "UPDATE tblActivities SET customersChoice ='" + cmbActivityNoon.Text + "' " +
                "WHERE (activityID = 3) ";
                dr = dbConnector.DoSQL(sqlStr);
                dbConnector.DoDML(sqlStr);
                dbConnector.close();
            }
            if (cmbActivityEvening.Text != "UNAVAILABLE")
            {
                changeOccured = true;
                dbConnector.Connect();
                sqlStr = "UPDATE tblActivities SET customersChoice ='" + cmbActivityEvening.Text + "' " +
                "WHERE (activityID = 4) "; //+ " , ";
                dr = dbConnector.DoSQL(sqlStr);
                dbConnector.DoDML(sqlStr);
                dbConnector.close();
            }
            if (cmbActivityLateEvening.Text != "UNAVAILABLE")
            {
                changeOccured = true;
                dbConnector.Connect();
                sqlStr = "UPDATE tblActivities SET customersChoice ='" + cmbActivityLateEvening.Text + "' " +
                "WHERE (activityID = 5) ";
                dr = dbConnector.DoSQL(sqlStr);
                dbConnector.DoDML(sqlStr);
                dbConnector.close();
            }
            //"WHERE (customerID = " + userID + ") ";
            if (changeOccured == false)
            {
                MessageBox.Show("You haven't chosen any activity");
            }
            else
            {
                MessageBox.Show("Details changed successfully");
            }
            
        }

        private void btnRoomService_Click(object sender, EventArgs e)
        {
            frmRoomService frmRoomService = new frmRoomService(userID);
            frmRoomService.Show();
            //this.Close();
        }

        private void btnRestaurantBooking_Click(object sender, EventArgs e)
        {
            frmRestaurantBooking frmRestaurantBooking = new frmRestaurantBooking();
            frmRestaurantBooking.Show();
        }

        private void btnAnalysis_Click(object sender, EventArgs e)
        {
            frmAnalysis frmAnalysis = new frmAnalysis(userID);
            frmAnalysis.Show();
        }
    }
}
