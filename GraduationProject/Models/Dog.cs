using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GraduationProject.Models
{
    public class Dog: Model
    {
        public int sealNumber { get; set; }
        public int addressId { get; set; }

        public override string ToString()
        {
            return sealNumber.ToString();
        }
        public void Fill(SqlDataReader reader)
        {
            sealNumber = reader.GetInt32(0);
            addressId = reader.GetInt32(1);
        }

        public void InsertDog(ConnectionHelper connectionHelper)
        {
            string query = "INSERT INTO Dogs (sealNumber, addressId) VALUES (@sealNum, @addrId)";
            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@sealNum", sealNumber);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", addressId);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();

        }
    }
}
