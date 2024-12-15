using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MyWindowsFormApp
{
    internal class DBconnectionClass
    {
        private static DBconnectionClass _instance;

        private SqlConnection _connection;


        private DBconnectionClass()
        {
            string connectionString = GetConnectionString();
            _connection = new SqlConnection(connectionString);
        }

        private string GetConnectionString()
        {
            // baseDirectory = project\bin\Debug\net8.0-windows
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

            // calculate project's file path
            string projectRoot = Path.GetFullPath(Path.Combine(baseDirectory, @"..\..\..\"));

            // combine database's file path
            string databaseFilePath = Path.Combine(projectRoot, "DATABASE.mdf");

            // check if database exist
            if (!File.Exists(databaseFilePath))
            {
                throw new FileNotFoundException($"database not found in '{databaseFilePath}' 。");
            }


            string connectionString = $@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename={databaseFilePath};Integrated Security=True;";
            return connectionString;
        }
        public static DBconnectionClass getInstanceOfDBconnections()
        {
            if (_instance == null)
            {
                Console.WriteLine("creates new database's instance");
                _instance = new DBconnectionClass();
                return _instance;
            }
            Console.WriteLine("already have the database's instance");
            return _instance;
        }


        public DataSet getDataset(string sqlQuery, Dictionary<string, object> parameters = null)
        {
            DataSet dataSet = new DataSet();

            try
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    Console.WriteLine("Sql connection open");
                    _connection.Open();
                }

                using (SqlCommand command = new SqlCommand(sqlQuery, _connection))
                {

                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataSet);  // Fill dataset using sqlDataAdapter
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                // close database connection
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();        
                }
            }
            return dataSet;
        }

        public int executeNonQuery(string sqlQuery, Dictionary<string, object> parameters)
        {
            try
            {
                // Check if the connection is closed and open it if necessary
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }

                using (SqlCommand command = new SqlCommand(sqlQuery, _connection))
                {
                    // Add parameters to the command if they exist
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }
                    }

                    // Execute the SQL command and return the number of affected rows
                    return command.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                // Handle SQL-specific exceptions
                MessageBox.Show("SQL Error: " + sqlEx.Message);
                return -1;
            }

            finally
            {
                // Ensure the connection is closed after the operation
                _connection.Close();

            }
        }
    }
}
