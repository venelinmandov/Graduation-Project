using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GraduationProject.Models
{
    public class Dog: Model<Dog>
    {
        public string SealNumber { get; set; }
        public int AddressId { get; set; }

        public override string ToString()
        {
            return SealNumber != null ? SealNumber : "няма";
        }

        //Запълване на обекта с информация
        public void Fill(SqlDataReader reader)
        {
            if (reader.IsDBNull(0))
                SealNumber = null;
            else
                SealNumber = reader.GetString(0);
            AddressId = reader.GetInt32(1);
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
            string query = @"SELECT sealNumber, addressId FROM Dogs
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
            string query = "DELETE FROM Dogs WHERE sealNumber = @sealNum";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@sealNum", SealNumber);
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
            throw new NotImplementedException();
        }
    }
}
