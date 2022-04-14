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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
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


        private void btnLogin_Click(object sender, EventArgs e)
        {

            string plainText = txtPassword.Text;
            string hashedText = GetHashSHA256(plainText);
            txtPassword.Text = hashedText;


            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            int userID=0;
            string sqlStr;
            bool matchMade = false;
            dbConnector.Connect();
            sqlStr = "SELECT customerID, accessLevel, accountLogin, accountPassword " +
            "FROM tblCustomerInfo";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                
                //checks whether encrypted password matches password stored on the server
                if (dr[2].ToString() == txtLogin.Text && hashedText == dr[3].ToString())
                {
                    txtPassword.Clear();
                    matchMade = true;
                    userID = Convert.ToInt32(dr[0]);
                    break;
                }
            }

            
            //if login details are correct, new forms are open
            if (matchMade)
            {
                if (Convert.ToInt32(dr[1].ToString()) >= 5)
                {
                    frmAdminMain frmAdminMain = new frmAdminMain(userID);
                    frmAdminMain.Show();
                }
                else
                {
                    frmMain frm = new frmMain(userID);
                    frm.Show();
                }
            }
            else
            {
                txtPassword.Clear();
                MessageBox.Show("Incorrect Username or Password");
            }
            dbConnector.close();
        }

    }
}
