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
    public partial class frmAnalysis : Form
    {
        private int userID;
        public frmAnalysis(int userID_)
        {
            userID = userID_;
            InitializeComponent();
        }

        private void frmAnalysis_Load(object sender, EventArgs e)
        {
            loadChart();
        }

        private void loadChart()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT tblItems.price, tblItems.Description, tblServiceItem.quantity " +
                     "FROM(((tblItems INNER JOIN " +
                     "tblServiceItem ON tblItems.itemID = tblServiceItem.itemID) INNER JOIN " +
                     "tblRoomService ON tblServiceItem.serviceID = tblRoomService.serviceID) INNER JOIN " +
                     "tblCustomerInfo ON tblRoomService.customerID = tblCustomerInfo.customerID) " +
                     "WHERE(tblRoomService.customerID = " + userID + ")";
            dr = dbConnector.DoSQL(sqlStr);
            while (dr.Read())
            {
                this.crtAnalysis.Series["Food Ordered"].Points.AddXY(dr[1].ToString(), dr[2].ToString());

            }
            dbConnector.close();
            
        }
    }
}
