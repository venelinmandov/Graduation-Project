using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GraduationProject.Models
{
    public class Dog: Model<Dog>
    {
        public int sealNumber { get; set; }
        public int addressId { get; set; }

        public override string ToString()
        {
            return sealNumber.ToString();
        }
        public void Fill(SqlDataReader reader)
        {
            sealNumber = reader.GetInt32(0);
            addressId = reader.GetInt32(1);
        }

        public int Insert(ConnectionHelper connectionHelper)
        {
            int id;
            string query = "INSERT INTO Dogs (sealNumber, addressId) output INSERTED.sealNumber VALUES (@sealNum, @addrId)";
            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@sealNum", sealNumber);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", addressId);
            id = (int) connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();
            return id;
        }

        public List<Dog> Get(ConnectionHelper connectionHelper, Address address)
        {
            List<Dog> dogs = new List<Dog>();
            Dog dog;
            string query = @"SELECT sealNumber, addressId FROM Dogs
                           WHERE addressId = @addrId";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.id);
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
    }
}
