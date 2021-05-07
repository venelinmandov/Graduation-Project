using System.Collections.Generic;
using System.Data.SQLite;

namespace GraduationProject.Models
{
    public class Resident:Person, Model<Resident>
    {
        public int AddressReg { get; set; } //0 - няма, 1 - има, 2 - временна
        public int Covid19 { get; set; }

        private new string fields = Person.fields + ", addressReg, covid19";

        //Запълане на обекта с информация
        public override void Fill(SQLiteDataReader reader)
        {
            base.Fill(reader);
            AddressReg = reader.GetInt32(9);
            Covid19 = reader.GetInt32(10); //0 - няма, 1 - има, 2 - контактен  
            
        }

        //Заявки

        //INSERT
        public new int Insert(ConnectionHelper connectionHelper)
        {
            long id;
            string query = @$"INSERT INTO Residents ({fields})
                            VALUES (@fName, @mName, @lName, @gender, @addrId, @currAddrId, @rel, @note, @addrReg, @covid)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@fname", Firstname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@mName", Middlename);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@lName", Lastname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@gender", Gender);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", AddressId);

            if (CurrentAddressId == -1)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@currAddrId", System.DBNull.Value);
            else
                connectionHelper.sqlCommand.Parameters.AddWithValue("@currAddrId", CurrentAddressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@rel", RelToOwner);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@note", Note);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrReg", AddressReg);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@covid", Covid19);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlCommand.CommandText = "SELECT last_insert_rowid()";
            id = (long)connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();
            return (int)id;
        }

        //GET
        new public List<Resident> Get(ConnectionHelper connectionHelper, Address address, Address.AddressType addressType = Address.AddressType.Permanent)
        {
            List<Resident> residents = new List<Resident>();
            Resident resident;
            string addressField = Address.FieldName[addressType];
            string whereClause = address != null ? $"WHERE {addressField} = @addrId": "";
            string query = @$"SELECT id,{fields} FROM Residents " + whereClause;

            connectionHelper.NewConnection(query);
            if(address != null)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.Id);

            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                resident = new Resident();
                resident.Fill(reader);
                residents.Add(resident);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return residents;
        }
        new public List<Resident> Get(ConnectionHelper connectionHelper, string personFirstName, string personMiddleName, string personLastNameName)
        {
            string whereClause;
            List<Resident> residents = new List<Resident>();
            Resident resident;
            List<string> elements = new List<string>();

            connectionHelper.NewConnection();
            if (personFirstName != "")
            {
                connectionHelper.sqlCommand.Parameters.AddWithValue("@firstname", personFirstName);
                elements.Add("Residents.firstname = @firstname");
            }
            if (personMiddleName != "")
            {
                connectionHelper.sqlCommand.Parameters.AddWithValue("@middleName", personMiddleName);
                elements.Add("Residents.middlename = @middleName");
            }
            if (personLastNameName != "")
            {
                connectionHelper.sqlCommand.Parameters.AddWithValue("@lastName", personLastNameName);
                elements.Add("Residents.lastname = @lastName");
            }

            whereClause = string.Join(" AND ", elements);

            string query = $@"SELECT id,{fields} FROM Residents WHERE {whereClause}";
            connectionHelper.sqlCommand.CommandText = query;

            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                resident = new Resident();
                resident.Fill(reader);
                residents.Add(resident);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();

            return residents;


        }


        List<Resident> Model<Resident>.Get(ConnectionHelper connectionHelper)
        {
            return Get(connectionHelper,null);
        }

        //DELETE
        public new void Delete(ConnectionHelper connectionHelper)
        {
            string query = "DELETE FROM Residents WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        public new void Delete(ConnectionHelper connectionHelper,Address address, Address.AddressType addressType = Address.AddressType.Permanent)
        {
            string addressField = Address.FieldName[addressType];
            string query = $"DELETE FROM Residents WHERE {addressField} = @addrId";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        

        //UPDATE
        public new void Update(ConnectionHelper connectionHelper)
        {
            string query = @"UPDATE Residents
                             SET firstname = @fname, middlename = @mName,
                                lastname = @lName, note = @note,
                                gender = @gender, addressId = @addrId,
                                relationToOwner = @rel, addressReg = @addrReg,
                                currentAddressId = @currAddrId, covid19 = @covid
                             WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@fname", Firstname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@mName", Middlename);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@lName", Lastname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@gender", Gender);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", AddressId);
            if (CurrentAddressId == -1)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@currAddrId", System.DBNull.Value);
            else
                connectionHelper.sqlCommand.Parameters.AddWithValue("@currAddrId", CurrentAddressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@rel", RelToOwner);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@rel", RelToOwner);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@note", Note);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrReg", AddressReg);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@covid", Covid19);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
   
}
