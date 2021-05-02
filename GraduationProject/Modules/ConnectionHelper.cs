using System;
using System.Configuration;
using System.Windows.Forms;
using System.Data.SQLite;


namespace GraduationProject
{
    public class ConnectionHelper
    {
        string connStr;
        public SQLiteConnection sqlConnection;
        public SQLiteCommand sqlCommand;
        public ConnectionHelper()
        {
            connStr = "Data Source=" + Environment.CurrentDirectory + "\\database.db; Version=3;";
            sqlConnection = new SQLiteConnection(connStr);
            sqlConnection.Close();
        }

        public void NewConnection(string query = null)
        {
            try
            {
                if(sqlConnection.State == System.Data.ConnectionState.Closed)
                    sqlConnection.Open();
                if (query == null)
                    sqlCommand = new SQLiteCommand(sqlConnection);
                else
                    sqlCommand = new SQLiteCommand(query, sqlConnection);
            }
            catch (SQLiteException)
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
