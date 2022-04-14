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
    public partial class frmRoomService : Form
    {
        private double totalCost = 0;
        private int userID, OriginalPrice = 0, highestID;
        

        public frmRoomService(int userID_)
        {
            userID = userID_;
            InitializeComponent();
        }

        class foodClass
        {
            public int ItemID { get; set; }
            public string FoodName { get; set; }
        }

        class paymentClass
        {
            public int paymentID { get; set; }
            public string PaymentName { get; set; }
        }

        class roomServiceClass
        {
            public int serviceTypeID { get; set; }
            public string RoomServiceDescription { get; set; }

        }
        private void frmRoomService_Load(object sender, EventArgs e)
        {
            populateComboBoxes();
            populateFoodComboBox();
        }

        private void populateFoodComboBox()
        {
            List<foodClass> foodAvailable = new List<foodClass>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT itemID, Description " +
                      "FROM tblItems";
            dr = dbConnector.DoSQL(sqlStr);
            dr.Read();
            while (dr.Read())
            {
                foodAvailable.Add(new foodClass { ItemID = Convert.ToInt32(dr[0]), FoodName = dr[1].ToString() });
            }
            cmbFoodAvailable.DisplayMember = "FoodName";
            cmbFoodAvailable.ValueMember = "ItemID";
            cmbFoodAvailable.DataSource = foodAvailable;
        }

        private void populateComboBoxes()
        {

            List<paymentClass> paymentMethod = new List<paymentClass>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT paymentID, paymentMethods " +
                    "FROM tblPaymentMethods";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                paymentMethod.Add(new paymentClass { paymentID = Convert.ToInt32(dr[0]), PaymentName = dr[1].ToString() });
            }
            cmbPayingMethod.DisplayMember = "PaymentName";
            cmbPayingMethod.ValueMember = "paymentID";
            cmbPayingMethod.DataSource = paymentMethod;
            //while (dr.Read())
            //{
            //paymentMethod.Add(new foodClass { itemID = Convert.ToInt32(dr[0]), paymentMethod = dr[5].ToString() });
            //}


            //cmbPayingMethod.DisplayMember = "paymentMethod";
            //cmbPayingMethod.ValueMember = "itemID";
            //cmbPayingMethod.DataSource = paymentMethod;

        }

        private void btnOrderStart_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "INSERT INTO tblRoomService " +
                     "(customerID, dateOfService, ServiceTypeID) " +
                     "VALUES( " + userID + ",'" + DateTime.Now.ToShortDateString() + "' , " + 5 + ")";


            if (!pnlFoodOrder.Visible == true)
            {
                dr = dbConnector.DoSQL(sqlStr);
                pnlFoodOrder.Visible = true;
            }
            else
            {
                MessageBox.Show("You have already started order");
            }
            dbConnector.close();
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void UpdateListView()
        {
            string foodToAdd = cmbFoodAvailable.Text, sqlStr;

            List<foodClass> foodPrices = new List<foodClass>();
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            dbConnector.Connect();
            sqlStr = "SELECT itemID, description, quantityAvailable, price " +
                     "FROM tblItems " +
                     "WHERE description = '" + foodToAdd + "'";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                //updates total cost
                UpdateTotalCost(Convert.ToInt32(dr[3].ToString()));
                if (AlreadyContainsItem(foodToAdd))
                {
                    for (int i = 0; i < lstOrder.Items.Count; i++)
                    {
                        if (lstOrder.Items[i].SubItems[1].Text == foodToAdd)
                        {
                            lstOrder.Items[i].SubItems[2].Text = (Convert.ToInt32(lstOrder.Items[i].SubItems[2].Text) + 1).ToString();
                            lstOrder.Items[i].SubItems[3].Text = (Convert.ToInt32(lstOrder.Items[i].SubItems[3].Text) + Convert.ToInt32(dr[3].ToString())).ToString();
                        }
                    } 
                }
                // as food is not on menu, adds it to menu
                else
                {
                    lstOrder.Items.Add(dr[0].ToString());
                    lstOrder.Items[lstOrder.Items.Count - 1].SubItems.Add(dr[1].ToString());
                    lstOrder.Items[lstOrder.Items.Count - 1].SubItems.Add("1");
                    lstOrder.Items[lstOrder.Items.Count - 1].SubItems.Add(dr[3].ToString());
                }

            }
            dbConnector.close();



        }

        private bool AlreadyContainsItem(string foodToAdd)
        {
            for (int i = 0; i < lstOrder.Items.Count; i++)
            {
                if (lstOrder.Items[i].SubItems[1].Text == foodToAdd)
                {
                    return true;
                }
            }
            return false;
        }

        private bool foodOnMenu(string foodToAdd)
        {
            bool foodOnMenu = false;
            for (int i = 0; i < lstOrder.Items.Count; i++)
            {
                if (lstOrder.Items[i].SubItems[1].Text == foodToAdd)
                {
                    foodOnMenu = true;
                    break;
                    //checks if food is available on the database

                    //food price is calculated
                } 
            }
            return foodOnMenu;
        }

        

        private void UpdateTotalCost(int price)
        {
            if (price == 0)
            {
                totalCost = 0;
            }
            else
            {
                totalCost += price;
            }
            lblTotalCost.Text = totalCost.ToString();
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure to cancel your order?",
            "Cancel order", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                highestID = findHighestID(highestID);

                clsDBConnector dbConnector = new clsDBConnector();
                string cmdStr;
                dbConnector.Connect();
                cmdStr = "DELETE FROM tblRoomService " +
                         "WHERE (serviceID = " + highestID + ")";
                dbConnector.DoDML(cmdStr);
                dbConnector.close();

                lstOrder.Items.Clear();
                pnlFoodOrder.Visible = false;
                totalCost = 0;
                lblTotalCost.Text = totalCost.ToString();
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            DialogResult confirmClear = MessageBox.Show("Are you sure to clear your order?",
            "Clear order", MessageBoxButtons.YesNo);
            if (confirmClear == DialogResult.Yes)
            {
                lstOrder.Items.Clear();
                //sets total cost to 0
                UpdateTotalCost(0);
            }
        }

        private void btnCompleteOrder_Click(object sender, EventArgs e)
        {
            if (lstOrder.Items.Count == 0)
            {
                MessageBox.Show("Your order can not be empty, please choose something");
            }
            else
            {
                highestID = findHighestID(highestID);

                clsDBConnector dbConnector = new clsDBConnector();
                OleDbDataReader dr;
                string sqlStr;
                dbConnector.Connect();
                for (int i = 0; i < lstOrder.Items.Count; i++)
                {
                    sqlStr = "INSERT INTO tblServiceItem" +
                    "(serviceID, itemID, quantity) " +
                    "VALUES(" + highestID + ", '" + lstOrder.Items[i].SubItems[0].Text + "', '" + lstOrder.Items[i].SubItems[2].Text + "') ";
                    dr = dbConnector.DoSQL(sqlStr);
                }
                dbConnector.close();

                pnlFoodOrder.Visible = false;
                MessageBox.Show("Your order is sent! updates will be available on the main form");
                lstOrder.Items.Clear();
                totalCost = 0;
            }
            

            // save a record in tblRoomService
            // findout the service id (the highest id)
            // loop though the listview and store the items in tblServiceItem 
        }

        private int findHighestID(int highestID)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = " SELECT MAX(serviceID) AS maxID FROM tblRoomService ";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                highestID = Convert.ToInt32(dr[0]);
            }
            dbConnector.close();
            return highestID;
        }

        
    }
}
