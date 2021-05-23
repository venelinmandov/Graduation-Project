using System;
using System.Collections.Generic;
using System.Data.SQLite;
namespace GraduationProject.Models
{
    public class Dog: Model<Dog>
    {
        public int Id { get; set; }
        public string SealNumber { get; set; }
        public int AddressId { get; set; }

        public DogType Type { get; set; }

        public override string ToString()
        {
            return SealNumber != null ? SealNumber : "няма";
        }

        public enum DogType { GuardDog, HuntingDog, DomesticDog, All };

        //Запълване на обекта с информация
        public void Fill(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            
            if (reader.IsDBNull(1))
                SealNumber = null;
            else
                SealNumber = reader.GetString(1);
            AddressId = reader.GetInt32(2);
            Type = (DogType)reader.GetInt32(3);
        }


        //Заявки

        //INSERT
        public int Insert(ConnectionHelper connectionHelper)
        {
            long id;
            string query = "INSERT INTO Dogs (sealNumber, addressId, type)VALUES (@sealNum, @addrId, @type)";
            connectionHelper.NewConnection(query);
            if(SealNumber != null)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@sealNum", SealNumber);
            else
                connectionHelper.sqlCommand.Parameters.AddWithValue("@sealNum", DBNull.Value);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", AddressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@type", Type);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlCommand.CommandText = "SELECT last_insert_rowid()";
            id = (long)connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();


            return (int)id;
        }


        //GET
        public List<Dog> Get(ConnectionHelper connectionHelper, Address address)
        {
            List<Dog> dogs = new List<Dog>();
            Dog dog;
            string query = @"SELECT id, sealNumber, addressId, type FROM Dogs
                           WHERE addressId = @addrId";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.Id);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                dog = new Dog();
                dog.Fill(reader);
                dogs.Add(dog);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return dogs;
        }

        public List<Dog> Get(ConnectionHelper connectionHelper)
        {
            return Get(connectionHelper,null);
        }

        //DELETE
        public void Delete(ConnectionHelper connectionHelper)
        {
            string query = "DELETE FROM Dogs WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        public void Delete(ConnectionHelper connectionHelper,Address address)
        {
            string query = "DELETE FROM Dogs WHERE addressId = @addrId";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        //UPDATE
        public void Update(ConnectionHelper connectionHelper)
        {
            string query = "UPDATE Dogs SET sealNumber = @sealNum, type = @type WHERE id = @id";

            connectionHelper.NewConnection(query);
            if(SealNumber != null)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@sealNum",SealNumber);
            else
                connectionHelper.sqlCommand.Parameters.AddWithValue("@sealNum", DBNull.Value);
                connectionHelper.sqlCommand.Parameters.AddWithValue("@type", Type);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
}
