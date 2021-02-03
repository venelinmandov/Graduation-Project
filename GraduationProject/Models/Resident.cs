using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace GraduationProject.Models
{
    public class Resident:Person
    {
        public int addressReg { get; set; }
        public int covid19 { get; set; }
        public override void Fill(SqlDataReader reader)
        {
            base.Fill(reader);
            addressReg = reader.GetInt32(8);
            covid19 = reader.GetInt32(9);
            
        }

        public  void Insert(ConnectionHelper connectionHelper)
        {
            string query = @"INSERT INTO Residents (firstname,middlename,lastname,egn,gender,addressId,owner,addressReg,covid19)
                            VALUES (@fName, @mName, @lName, @egn, @gender, @addrId, @owner, @addrReg, @covid)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@fname", firstname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@mName", middlename);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@lName", lastname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@egn", egn);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@gender", gender);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", addressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@owner", relToOwner);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrReg", addressReg);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@covid", covid19);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
   
}
