using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;


namespace GraduationProject
{
    public class ConnectionHelper
    {
        string connStr;
        public SqlConnection sqlConnection;
        public SqlCommand sqlCommand;
        public ConnectionHelper()
        {
            connStr = ConfigurationManager.ConnectionStrings["VillageDB"].ConnectionString;
            sqlConnection = new SqlConnection(connStr);
            sqlConnection.Close();
        }

        public void NewConnection(string query)
        {
            sqlConnection.Open();
            sqlCommand = new SqlCommand(query, sqlConnection);
        }

       

    }
}
