using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;


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
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
            }
            catch (SqlException exception)
            {
                DialogResult result = MessageBox.Show("Не може да се осъществи връзка с базата данни", "Грешка", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if (result == DialogResult.Retry)
                {
                    NewConnection(query);
                }
                else if (result == DialogResult.Cancel)
                {
                    Environment.Exit(0);
                }
            }

        }



    }
}
