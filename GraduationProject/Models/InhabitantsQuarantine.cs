using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace GraduationProject.Models
{
    public class InhabitantsQuarantine : Model<InhabitantsQuarantine>
    {
        public int Id { get; set; }
        public int InhabitantId { get; set; }
        public QuarantineEnum QuarantineType { get; set; }
        public int DiseaseId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public enum QuarantineEnum {Ill, Contact };

        public void Fill(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            InhabitantId = reader.GetInt32(1);
            QuarantineType = (QuarantineEnum)reader.GetInt32(2);
            DiseaseId = reader.GetInt32(3);
            StartDate = reader.GetString(4);
            EndDate = reader.GetString(5);
        }

        //INSERT
        public void Insert(ConnectionHelper connectionHelper)
        {
            long id;
            string query = @"INSERT INTO InhabitantsQuarantines (inhabitantId, quarantineType, disease, startDate, endDate) 
                            VALUES (@inhabitantId, @quar, @disease, @startDate, @endDate )";
            connectionHelper.NewConnection(query);

            connectionHelper.sqlCommand.Parameters.AddWithValue("@inhabitantId", InhabitantId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@quar", QuarantineType);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@disease", DiseaseId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@startDate", StartDate);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@endDate", EndDate);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlCommand.CommandText = "SELECT last_insert_rowid()";
            id = (long)connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();


            Id = (int)id;
        }

        //GET
        public List<InhabitantsQuarantine> Get(ConnectionHelper connectionHelper, Address address)
        {

            List<InhabitantsQuarantine> quarantines = new List<InhabitantsQuarantine>();
            InhabitantsQuarantine quarantine;
            string query = @"SELECT InhabitantsQuarantines.id, inhabitantId, quarantineType, disease, startDate, endDate 
                            FROM InhabitantsQuarantines, Inhabitants
                            WHERE inhabitantId = Inhabitants.id AND Inhabitants.addressId = @addrId
                            ORDER BY date(startDate) DESC";

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
            string query = @"SELECT id, inhabitantId, quarantineType, disease, startDate, endDate FROM InhabitantsQuarantines";

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
            string query = @"UPDATE InhabitantsQuarantines SET 
                            inhabitantId = @inhabId, quarantineType = @quar, 
                            disease = @disease, startDate = @startDate,
                            endDate = @endDate
                            WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@inhabId", InhabitantId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@quar", QuarantineType);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@disease", DiseaseId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@startDate", StartDate);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@endDate", EndDate);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
}
