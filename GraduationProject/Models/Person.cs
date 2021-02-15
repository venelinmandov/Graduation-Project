using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GraduationProject.Models
{
    public class Person : Model<Person>
    {
        public int id { get; set; }
        public string firstname { get; set; }
        public string middlename { get; set; }
        public string lastname { get; set; }
        public string egn { get; set; }
        public int gender { get; set; }
        public int addressId { get; set; }
        public string relToOwner { get; set; }

        private static string fields = "firstname,middlename,lastname,egn,gender,addressId,relationToOwner";


        public virtual void Fill(SqlDataReader reader)
        {
            id = reader.GetInt32(0);
            firstname = reader.GetString(1);
            middlename = reader.GetString(2);
            lastname = reader.GetString(3);
            egn = reader.GetString(4);
            gender = reader.GetInt32(5);
            addressId = reader.GetInt32(6);
            relToOwner = reader.GetString(7);
        }

        public int Insert(ConnectionHelper connectionHelper)
        {
            int id;
            string query = @$"INSERT INTO GuestsInQuarantine ({fields}) output INSERTED.id
                            VALUES (@fName, @mName, @lName, @egn, @gender, @addrId,@rel)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@fname", firstname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@mName", middlename);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@lName", lastname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@egn", egn);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@gender", gender);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", addressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@rel", relToOwner);

            id = (int) connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();
            return id;
        }

        public List<Person> Get(ConnectionHelper connectionHelper, Address address = null)
        {
            List<Person> persons = new List<Person>();
            Person person;
            string whereClause = address != null ? " WHERE addressId = @addrId" : "";
            string query = @$"SELECT id,{fields} FROM GuestsInQuarantine " + whereClause;
            connectionHelper.NewConnection(query);
            if(address != null)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId",address.id);

            SqlDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                person = new Person();
                person.Fill(reader);
                persons.Add(person);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return persons;
        }

        public List<Person> Get(ConnectionHelper connectionHelper)
        {
            return Get(connectionHelper,null);
        }
    }
}
