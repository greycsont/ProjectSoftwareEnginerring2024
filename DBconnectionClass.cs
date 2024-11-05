using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormApp
{
    internal class DBconnectionClass
    {
        private static DBconnectionClass _instance;

        private SqlConnection _connection;


        private DBconnectionClass()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ASD\DESKTOP\2024\MYWINDOWSFORMSAPP\DATABASE1.MDF;Integrated Security=True;";
            _connection = new SqlConnection(connectionString);
        }


        public static DBconnectionClass getInstanceOfDBconnections()
        {
            if (_instance == null)
            {
                _instance = new DBconnectionClass();
                return _instance;
            }
            return _instance;
        }


        public DataSet getDataset(string sqlQuery)
        {
            DataSet dataSet = new DataSet();

            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

            SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, _connection);
            adapter.Fill(dataSet);

            return dataSet;
        }
    }
}
