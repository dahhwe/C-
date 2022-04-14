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
    public partial class frmCustomersPersonalInformation : Form
    {
        private int userID;
        public frmCustomersPersonalInformation(int userID_)
        {
            userID = userID_;
            InitializeComponent();
        }

        private void customersPersonalInformation_Load(object sender, EventArgs e)
        {
            populateWithExistingInformation();

        }

        private void populateWithExistingInformation()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT forename, surname, age, customerExtraInformation " +
            "FROM tblCustomerInfo " +
            "WHERE (customerID = " + userID + ")";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                txtForename.Text = dr[0].ToString();
                txtSurname.Text = dr[1].ToString();
                txtAge.Text = dr[2].ToString();
                txtExtra.Text = dr[3].ToString();
            }
            dbConnector.DoDML(sqlStr);
            dbConnector.close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string sqlStr = "UPDATE tblCustomerInfo " +
            "SET forename = '" + txtForename.Text + "' , " +
            "surname = '" + txtSurname.Text + "' , " +
            "age = '" + txtAge.Text + "' , " +
            "customerExtraInformation = '" + txtExtra.Text + "' " +  
            "WHERE (customerID = " + userID + ")";
            dbConnector.Connect();
            dbConnector.DoDML(sqlStr);
            dbConnector.close();
            MessageBox.Show("Details updated successfully");
            this.Close();




        }
    }
}
