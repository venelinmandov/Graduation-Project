using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace GraduationProject.Models
{
    public class AnimalsQuarantine : Model<AnimalsQuarantine>
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public AnimalEnum Animal { get; set; }
        public int Number { get; set; }
        public int DiseaseId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }



        public enum AnimalEnum { Cows, Sheep, Goats, Horses, Donkeys, Feathered, Pigs, Dogs };

        public void Fill(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            AddressId = reader.GetInt32(1);
            Animal = (AnimalEnum)reader.GetInt32(2);
            Number = reader.GetInt32(3);
            DiseaseId = reader.GetInt32(4);
            StartDate = reader.GetString(5);
            EndDate = reader.GetString(6);
        }

        //INSERT
        public void Insert(ConnectionHelper connectionHelper)
        {
            long id;
            string query = @"INSERT INTO AnimalsQuarantines (addressId, animal, number, disease, startDate, endDate) 
                            VALUES (@addrId, @animal, @disease, @startDate, @endDate )";
            connectionHelper.NewConnection(query);

            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", AddressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@animal", Animal);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@number", Number);
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
        public List<AnimalsQuarantine> Get(ConnectionHelper connectionHelper, Address address, AnimalEnum animal)
        {

            List<AnimalsQuarantine> quarantines = new List<AnimalsQuarantine>();
            AnimalsQuarantine quarantine;
            string query = @"SELECT id, addressId, animal, number, disease, startDate, endDate FROM AnimalsQuarantines
                            WHERE addressId = @addrId AND animal = @animal ORDER BY date(startDate) DESC";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.Id);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@animal", animal);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                quarantine = new AnimalsQuarantine();
                quarantine.Fill(reader);
                quarantines.Add(quarantine);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return quarantines;
        }

        public List<AnimalsQuarantine> Get(ConnectionHelper connectionHelper)
        {

            List<AnimalsQuarantine> quarantines = new List<AnimalsQuarantine>();
            AnimalsQuarantine quarantine;
            string query = @"SELECT id, addressId, animal, number, disease, startDate, endDate FROM AnimalsQuarantines";

            connectionHelper.NewConnection(query);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                quarantine = new AnimalsQuarantine();
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
            string query = "DELETE FROM AnimalsQuarantines WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        //UPDATE
        public void Update(ConnectionHelper connectionHelper)
        {
            string query = @"UPDATE AnimalsQuarantines SET, 
                            animal = @animal, number = @number, disease = @disease,
                            startDate = @startDate, endDate = @endDate
                            WHERE id = @id";

            connectionHelper.NewConnection(query);   
            connectionHelper.sqlCommand.Parameters.AddWithValue("@animal", Animal);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@number", Number);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@disease", DiseaseId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@startDate", StartDate);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@endDate", EndDate);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }        
    }
}
