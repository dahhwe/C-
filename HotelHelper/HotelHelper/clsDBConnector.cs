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
    class clsDBConnector
    {
        OleDbConnection conn = new OleDbConnection();
        string dbProvider;
        string dbSource;

        public void Connect()
        {
            dbProvider = "Provider=Microsoft.ACE.OLEDB.12.0;";
            dbSource = @"Data Source = Z:\DSHYNKARENKO\Visual Studio 2017\Projects\HotelHelper\HotelDatabase.accdb";
            conn.ConnectionString = dbProvider + dbSource;
           // conn.ConnectionString =  Properties.Settings.Default.HotelDatabase;
           conn.Open();
        }

        public void close()
        {
            conn.Close();
        }

        public void DoDML(string dmlString)
        {
            OleDbCommand cmd;
            cmd = new OleDbCommand(dmlString, conn);
            cmd.ExecuteNonQuery();
        }

        public OleDbDataReader DoSQL(string sqlString)
        {
            OleDbCommand cmd;
            cmd = new OleDbCommand(sqlString, conn);
            return cmd.ExecuteReader();
        }  
    }
}
