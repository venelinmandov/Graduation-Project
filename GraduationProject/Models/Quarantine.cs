using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace GraduationProject.Models
{
    public class Quarantine : Model<Quarantine>
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public QuarantineType Type { get; set; }


        public enum QuarantineType { Inhabitants, Cows, Sheep, Goats, Horses, Donkeys, Feathered, Pigs, Dogs };

        public void Fill(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            AddressId = reader.GetInt32(1);
            Type = (QuarantineType)reader.GetInt32(2);
        }

        //INSERT
        public int Insert(ConnectionHelper connectionHelper)
        {
            long id;
            string query = "INSERT INTO Quarantines (addressId, type) VALUES (@addrId, @type)";
            connectionHelper.NewConnection(query);

            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", AddressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@type", Type);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlCommand.CommandText = "SELECT last_insert_rowid()";
            id = (long)connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();


            return (int)id;
        }

        //GET
        public List<Quarantine> Get(ConnectionHelper connectionHelper, Address address)
        {

            List<Quarantine> quarantines = new List<Quarantine>();
            Quarantine quarantine;
            string query = @"SELECT id, addressId, type FROM Quarantines
                            WHERE addressId = @addrId";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.Id);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                quarantine = new Quarantine();
                quarantine.Fill(reader);
                quarantines.Add(quarantine);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return quarantines;
        }

        public List<Quarantine> Get(ConnectionHelper connectionHelper)
        {

            List<Quarantine> quarantines = new List<Quarantine>();
            Quarantine quarantine;
            string query = @"SELECT id, addressId, type FROM Quarantines";

            connectionHelper.NewConnection(query);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                quarantine = new Quarantine();
                quarantine.Fill(reader);
                quarantines.Add(quarantine);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return quarantines;
        }

        //DELETE
        public void Delete(ConnectionHelper connectionHelper)
        {
            string query = "DELETE FROM Quarantines WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        //UPDATE
        public void Update(ConnectionHelper connectionHelper)
        {
            string query = "UPDATE Quarantines SET, type = @type WHERE id = @id";

            connectionHelper.NewConnection(query);   
            connectionHelper.sqlCommand.Parameters.AddWithValue("@type", Type);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }        
    }
}
