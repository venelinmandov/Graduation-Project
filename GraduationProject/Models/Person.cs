using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GraduationProject.Models
{
    public class Person : Model
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string egn { get; set; }
        public int gender { get; set; }
        public int addressId { get; set; }
        public string relToOwner { get; set; }


        public virtual void Fill(SqlDataReader reader)
        {
            id = reader.GetInt32(0);
            firstname = reader.GetString(1);
            middlename = reader.GetString(2);
            lastname = reader.GetString(3);
            egn = reader.GetString(4);
            gender = reader.GetInt32(5);
            addressId = reader.GetInt32(6);
            relToOwner = reader.GetString(7);
        }

        public void InsertPerson(ConnectionHelper connectionHelper)
        {
            string query = @"INSERT INTO GuestsInQuarantine (firstname,middlename,lastname,egn,gender,addressId,relationToOwner)
                            VALUES (@fName, @mName, @lName, @egn, @gender, @addrId,@rel)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@fname", firstname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@mName", middlename);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@lName", lastname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@egn", egn);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@gender", gender);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", addressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@rel", relToOwner);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
}
