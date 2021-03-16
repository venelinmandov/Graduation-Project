using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GraduationProject.Models
{
    public class Dog: Model<Dog>
    {
        public int Id { get; set; }
        public string SealNumber { get; set; }
        public int AddressId { get; set; }

        public override string ToString()
        {
            return SealNumber != null ? SealNumber : "няма";
        }

        //Запълване на обекта с информация
        public void Fill(SqlDataReader reader)
        {
            Id = reader.GetInt32(0);
            if (reader.IsDBNull(1))
                SealNumber = null;
            else
                SealNumber = reader.GetString(1);
            AddressId = reader.GetInt32(2);
        }


        //Заявки

        //INSERT
        public int Insert(ConnectionHelper connectionHelper)
        {
            int id;
            string query = "INSERT INTO Dogs (sealNumber, addressId) output INSERTED.id VALUES (@sealNum, @addrId)";
            connectionHelper.NewConnection(query);
            if(SealNumber != null)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@sealNum", SealNumber);
            else
                connectionHelper.sqlCommand.Parameters.AddWithValue("@sealNum", DBNull.Value);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", AddressId);
            id = (int) connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();
            return id;
        }


        //GET
        public List<Dog> Get(ConnectionHelper connectionHelper, Address address)
        {
            List<Dog> dogs = new List<Dog>();
            Dog dog;
            string query = @"SELECT id, sealNumber, addressId FROM Dogs
                           WHERE addressId = @addrId";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.Id);
            SqlDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
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
            string query = "UPDATE Dogs SET sealNumber = @sealNum WHERE id = @id";

            connectionHelper.NewConnection(query);
            if(SealNumber != null)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@sealNum",SealNumber);
            else
                connectionHelper.sqlCommand.Parameters.AddWithValue("@sealNum", DBNull.Value);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
}
