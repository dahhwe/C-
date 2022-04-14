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
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;


namespace HotelHelper
{
    public partial class frmSettings : Form
    {
        private int userID;
        public frmSettings(int userID_)
        {
            userID = userID_;
            InitializeComponent();
        }


        private string GetHashSHA256(string plainText)
        {
            string hashText = "";
            Encoding enc = Encoding.UTF8;
            SHA256Managed hash = new SHA256Managed();
            byte[] result = hash.ComputeHash(enc.GetBytes(plainText));
            foreach (Byte item in result)
            {
                hashText = hashText + item.ToString("X");
            }
            return hashText;
        }


        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            string plainText = txtOldPassword.Text;
            string hashedText = GetHashSHA256(plainText);
            txtOldPassword.Text = hashedText;

            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT accountPassword, accountLogin " +
            "FROM tblCustomerInfo " +
            "WHERE (customerID = " + userID + ")";
            dr = dbConnector.DoSQL(sqlStr);
            bool PasswordChangeAllowed = false;

            //Checks whether "Old Password" user typed in matches existing password
            while (dr.Read())
            {
                if (txtOldPassword.Text.Length == 0 || txtNewPassword.Text.Length == 0 || txtRepeatNewPassword.Text.Length == 0)
                {
                    clearTextBoxes();
                    MessageBox.Show("please fill in all the fields");
                    break;
                }
                else if (hashedText != dr[0].ToString())
                {
                    clearTextBoxes();
                    MessageBox.Show("Password entered doesn't match a previous one");
                    break;
                }
                else if (txtNewPassword.Text != txtRepeatNewPassword.Text)
                {
                    clearTextBoxes();
                    MessageBox.Show("New Passwords don't match");
                    break;
                }
                else
                {
                    //clearTextBoxes();
                    PasswordChangeAllowed = true;
                }

            }
            dbConnector.close();
            if (PasswordChangeAllowed)
            {
                //txtNewPassword.Text = hashedText;
                string hashedPassword = GetHashSHA256(txtNewPassword.Text);
                sqlStr = "UPDATE tblCustomerInfo " +
                "SET accountPassword ='" + hashedPassword + "' " +
                "WHERE (customerID = " + userID + ")";
                dbConnector.Connect();
                dbConnector.DoDML(sqlStr);
                dbConnector.close();
                MessageBox.Show("Password changed successfully");
                this.Close();
            }
        }

        private void clearTextBoxes()
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtRepeatNewPassword.Clear();
        }

        private void btnCustomerInfo_Click(object sender, EventArgs e)
        {
            frmCustomersPersonalInformation frm = new frmCustomersPersonalInformation(userID);
            frm.Show();
        }

        private void lblReenterNewPassword_Click(object sender, EventArgs e)
        {

        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }
    }
}
