using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace GraduationProject.Models
{
    public class Person : Model<Person>
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public int Gender { get; set; }
        public int AddressId { get; set; }
        public int CurrentAddressId { get; set; }
        public string RelToOwner { get; set; }
        public string Note { get; set; }

        protected static string fields = "firstname, middlename, lastname, gender, addressId, currentAddressId, relationToOwner, note";

        //Запълване на обекта с информация
        public virtual void Fill(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            Firstname = reader.GetString(1);
            Middlename = reader.GetString(2);
            Lastname = reader.GetString(3);
            Gender = reader.GetInt32(4);
            AddressId = reader.GetInt32(5);
            CurrentAddressId = reader.IsDBNull(6)? -1 : reader.GetInt32(6);
            RelToOwner = reader.GetString(7);
            Note = reader.GetString(8);
        }

        //Заявки

        //INSERT
        public int Insert(ConnectionHelper connectionHelper)
        {
            long id;
            string query = @$"INSERT INTO GuestsInQuarantine ({fields})
                            VALUES (@fName, @mName, @lName, @gender, @addrId, @rel, @note)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@fname", Firstname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@mName", Middlename);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@lName", Lastname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@gender", Gender);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", AddressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@rel", RelToOwner);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@note", Note);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlCommand.CommandText = "SELECT last_insert_rowid()";
            id = (long)connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();


            return (int)id;
        }

        //GET
        public List<Person> Get(ConnectionHelper connectionHelper, Address address = null)
        {
            List<Person> persons = new List<Person>();
            Person person;
            string whereClause = address != null ? " WHERE addressId = @addrId" : "";
            string query = @$"SELECT id,{fields} FROM GuestsInQuarantine " + whereClause;
            connectionHelper.NewConnection(query);
            if(address != null)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId",address.Id);

            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
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

        virtual public List<Person> Get(ConnectionHelper connectionHelper,string personFirstName, string personMiddleName, string personLastNameName)
        {
            string whereClause;
            List<Person> persons = new List<Person>();
            Person person;
            List<string> elements = new List<string>();

            connectionHelper.NewConnection();
            if (personFirstName != "")
            {
                connectionHelper.sqlCommand.Parameters.AddWithValue("@firstname", personFirstName);
                elements.Add("GuestsInQuarantine.firstname = @firstname");
            }
            if (personMiddleName != "")
            {
                connectionHelper.sqlCommand.Parameters.AddWithValue("@middleName", personMiddleName);
                elements.Add("GuestsInQuarantine.middlename = @middleName");
            }
            if (personLastNameName != "")
            {
                connectionHelper.sqlCommand.Parameters.AddWithValue("@lastName", personLastNameName);
                elements.Add("GuestsInQuarantine.lastname = @lastName");
            }
                
            whereClause = string.Join(" AND ", elements);

            string query = $@"SELECT id,{fields} FROM GuestsInQuarantine WHERE {whereClause}";
            connectionHelper.sqlCommand.CommandText = query;

            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
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

        //DELETE
        public void Delete(ConnectionHelper connectionHelper,Address address)
        {
            string query = "DELETE FROM GuestsInQuarantine WHERE addressId = @addrId";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        public void Delete(ConnectionHelper connectionHelper)
        {
            string query = "DELETE FROM GuestsInQuarantine WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        //UPDATE
        public void Update(ConnectionHelper connectionHelper)
        {
            string query = @"UPDATE GuestsInQuarantine
                             SET firstname = @fname, middlename = @mName,
                                lastname = @lName, note = @note,
                                gender = @gender, addressId = @addrId,
                                relationToOwner = @rel
                             WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@fname", Firstname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@mName", Middlename);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@lName", Lastname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@gender", Gender);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", AddressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@rel", RelToOwner);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@note", Note);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
}
