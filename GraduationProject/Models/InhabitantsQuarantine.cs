using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace GraduationProject.Models
{
    public class InhabitantsQuarantine : Model<InhabitantsQuarantine>
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public int DiseaseId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }


        public void Fill(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            AddressId = reader.GetInt32(1);
            DiseaseId = reader.GetInt32(2);
            StartDate = reader.GetString(3);
            EndDate = reader.GetString(4);
        }

        //INSERT
        public int Insert(ConnectionHelper connectionHelper)
        {
            long id;
            string query = @"INSERT INTO InhabitantsQuarantines (addressId, disease, startDate, endDate) 
                            VALUES (@addrId, @animal, @disease, @startDate, @endDate )";
            connectionHelper.NewConnection(query);

            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", AddressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@disease", DiseaseId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@startDate", StartDate);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@endDate", EndDate);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlCommand.CommandText = "SELECT last_insert_rowid()";
            id = (long)connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();


            return (int)id;
        }

        //GET
        public List<InhabitantsQuarantine> Get(ConnectionHelper connectionHelper, Address address)
        {

            List<InhabitantsQuarantine> quarantines = new List<InhabitantsQuarantine>();
            InhabitantsQuarantine quarantine;
            string query = @"SELECT id, addressId, disease, startDate, endDate FROM InhabitantsQuarantines
                            WHERE addressId = @addrId";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.Id);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                quarantine = new InhabitantsQuarantine();
                quarantine.Fill(reader);
                quarantines.Add(quarantine);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return quarantines;
        }

        public List<InhabitantsQuarantine> Get(ConnectionHelper connectionHelper)
        {

            List<InhabitantsQuarantine> quarantines = new List<InhabitantsQuarantine>();
            InhabitantsQuarantine quarantine;
            string query = @"SELECT id, addressId, disease, startDate, endDate FROM InhabitantsQuarantines";

            connectionHelper.NewConnection(query);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                quarantine = new InhabitantsQuarantine();
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
            string query = "DELETE FROM InhabitantsQuarantines WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        //UPDATE
        public void Update(ConnectionHelper connectionHelper)
        {
            string query = @"UPDATE InhabitantsQuarantines SET, 
                           disease = @disease, startDate = @startDate,
                            endDate = @endDate
                            WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@disease", DiseaseId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@startDate", StartDate);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@endDate", EndDate);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
}
