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

        private static string fields = "firstname,middlename,lastname,egn,gender,addressId,relationToOwner,addressReg,covid19";

        public override void Fill(SqlDataReader reader)
        {
            base.Fill(reader);
            addressReg = reader.GetInt32(8);
            covid19 = reader.GetInt32(9);
            
        }


        public void InsertResident(ConnectionHelper connectionHelper)
        {
            
            string query = @$"INSERT INTO Residents ({fields})
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

        public static List<Resident> GetResidents(ConnectionHelper connectionHelper, Address address)
        {
            List<Resident> residents = new List<Resident>();
            Resident resident;
            string query = @$"SELECT id,{fields} FROM Residents
                            WHERE addressId = @addrId";
            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.id);
            SqlDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                resident = new Resident();
                resident.Fill(reader);
                residents.Add(resident);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return residents;
        }
    }
   
}
