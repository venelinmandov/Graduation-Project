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

        public static void InsertResident(Resident resident, ConnectionHelper connectionHelper)
        {
            string query = @"INSERT INTO Residents (firstname,middlename,lastname,egn,gender,addressId,owner,addressReg,covid19)
                            VALUES (@fName, @mName, @lName, @egn, @gender, @addrId, @owner, @addrReg, @covid)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@fname", resident.firstname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@mName", resident.middlename);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@lName", resident.lastname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@egn", resident.egn);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@gender", resident.gender);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", resident.addressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@owner", resident.relToOwner);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrReg", resident.addressReg);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@covid", resident.covid19);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
   
}
