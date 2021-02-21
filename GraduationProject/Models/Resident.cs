using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace GraduationProject.Models
{
    public class Resident:Person, Model<Resident>
    {
        //Полета
        public int addressReg { get; set; }
        public int covid19 { get; set; }

        private string fields = "firstname, middlename, lastname, egn, gender, addressId, relationToOwner, addressReg, covid19";

        //Запълане на обекта с информация
        public override void Fill(SqlDataReader reader)
        {
            base.Fill(reader);
            addressReg = reader.GetInt32(8);
            covid19 = reader.GetInt32(9);
            
        }

        //Заявки

        //INSERT
        public new int Insert(ConnectionHelper connectionHelper)
        {
            int id;
            string query = @$"INSERT INTO Residents ({fields}) output INSERTED.id
                            VALUES (@fName, @mName, @lName, @egn, @gender, @addrId, @rel, @addrReg, @covid)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@fname", firstname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@mName", middlename);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@lName", lastname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@egn", egn);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@gender", gender);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", addressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@rel", relToOwner);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrReg", addressReg);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@covid", covid19);

            id = (int) connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();
            return id;
        }

        //GET
        new public List<Resident> Get(ConnectionHelper connectionHelper, Address address)
        {
            List<Resident> residents = new List<Resident>();
            Resident resident;
            string whereClause = address != null ? "WHERE addressId = @addrId": "";
            string query = @$"SELECT id,{fields} FROM Residents " + whereClause;

            connectionHelper.NewConnection(query);
            if(address != null)
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


        List<Resident> Model<Resident>.Get(ConnectionHelper connectionHelper)
        {
            return Get(connectionHelper,null);
        }

        //DELETE
        public new void Delete(ConnectionHelper connectionHelper)
        {
            string query = "DELETE FROM Residents WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        //UPDATE
        public new void Update(ConnectionHelper connectionHelper)
        {
            string query = @"UPDATE Residents
                             SET firstname = @fname, middlename = @mName,
                                lastname = @lName, egn = @egn,
                                gender = @gender, addressId = @addrId,
                                relationToOwner = @rel, addressReg = @addrReg,
                                covid19 = @covid
                             WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", id);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@fname", firstname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@mName", middlename);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@lName", lastname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@egn", egn);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@gender", gender);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", addressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@rel", relToOwner);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrReg", addressReg);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@covid", covid19);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
   
}
