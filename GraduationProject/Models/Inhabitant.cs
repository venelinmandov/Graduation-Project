using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace GraduationProject.Models
{
    public class Inhabitant
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public GenderEnum Gender { get; set; }
        public int AddressId { get; set; }
        public int CurrentAddressId { get; set; }
        public int PermanentAddressId { get; set; }
        public string RelToOwner { get; set; }
        public AddressRegistrationEnum AddressReg { get; set; }
        public string Note { get; set; } = "";
        public string PhoneNumber { get; set; }
        public ResidenceStateEnum ResidenceState { get; set; }
        public OwnershipStateEnum OwnershipState { get; set; }

        protected static string fields = "firstname, middlename, lastname, gender, addressId, currentAddressId, permanentAddressId, relationToOwner, addressReg, note, phoneNumber, residenceState, ownershipState";

        public enum AddressRegistrationEnum { No, Permanent, Current };
        public enum ResidenceStateEnum { Permanent, Temporary };
        public enum OwnershipStateEnum { Guest, Resident, Owner };
        public enum GenderEnum { Male, Female };

        public override string ToString()
        {
            return $"{Firstname} {Middlename} {Lastname}";
        }


        //Запълване на обекта с информация
        public virtual void Fill(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            Firstname = reader.GetString(1);
            Middlename = reader.GetString(2);
            Lastname = reader.GetString(3);
            Gender = (GenderEnum)reader.GetInt32(4);
            AddressId = reader.GetInt32(5);
            CurrentAddressId = reader.IsDBNull(6) ? -1 : reader.GetInt32(6);
            PermanentAddressId = reader.IsDBNull(7) ? -1 : reader.GetInt32(7);
            RelToOwner = reader.GetString(8);
            AddressReg = (AddressRegistrationEnum)reader.GetInt32(9);
            Note = reader.GetString(10);
            PhoneNumber = reader.IsDBNull(11) ? "Няма" : reader.GetString(11);
            ResidenceState = (ResidenceStateEnum)reader.GetInt32(12);
            OwnershipState = (OwnershipStateEnum)reader.GetInt32(13);


        }

        //Събития
        public event EventHandler InhabitantSaved;
        public event EventHandler InhabitantUpdated;

        //Заявки

        //INSERT
        public void Insert(ConnectionHelper connectionHelper)
        {
            long id;
            string query = @$"INSERT INTO Inhabitants ({fields})
                            VALUES (@fName, @mName, @lName, @gender, @addrId, @currAddrId, @permAddrId, @rel, @addrReg, @note, @phone, @residence, @ownership)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@fname", Firstname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@mName", Middlename);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@lName", Lastname);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@gender", Gender);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", AddressId);

            if (CurrentAddressId == -1)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@currAddrId", DBNull.Value);
            else
                connectionHelper.sqlCommand.Parameters.AddWithValue("@currAddrId", CurrentAddressId);
            if (PermanentAddressId == -1)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@permAddrId", DBNull.Value);
            else
                connectionHelper.sqlCommand.Parameters.AddWithValue("@permAddrId", PermanentAddressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@rel", RelToOwner);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrReg", AddressReg);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@note", Note);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@phone", PhoneNumber);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@residence", ResidenceState);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@ownership", OwnershipState);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlCommand.CommandText = "SELECT last_insert_rowid()";
            id = (long)connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();
            Id = (int)id;

            if (InhabitantSaved != null)
            {
                InhabitantSaved(new object(), new EventArgs());
            }
        }

        //GET
        public List<Inhabitant> Get(ConnectionHelper connectionHelper, Address address, Address.AddressType addressType = Address.AddressType.Permanent)
        {
            List<Inhabitant> inhabitants = new List<Inhabitant>();
            Inhabitant inhabitant;
            string addressField = Address.FieldName[addressType];
            string whereClause = address != null ? $"WHERE {addressField} = @addrId" : "";
            string query = @$"SELECT id,{fields} FROM Inhabitants " + whereClause;

            connectionHelper.NewConnection(query);
            if (address != null)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.Id);

            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                inhabitant = new Inhabitant();
                inhabitant.Fill(reader);
                inhabitants.Add(inhabitant);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return inhabitants;
        }
        public List<Inhabitant> Get(ConnectionHelper connectionHelper, string personFirstName, string personMiddleName, string personLastNameName)
        {
            string whereClause;
            List<Inhabitant> inhabitants = new List<Inhabitant>();
            Inhabitant inhabitant;
            List<string> elements = new List<string>();

            connectionHelper.NewConnection();
            if (personFirstName != "")
            {
                connectionHelper.sqlCommand.Parameters.AddWithValue("@firstname", personFirstName);
                elements.Add("Inhabitants.firstname = @firstname");
            }
            if (personMiddleName != "")
            {
                connectionHelper.sqlCommand.Parameters.AddWithValue("@middleName", personMiddleName);
                elements.Add("Inhabitants.middlename = @middleName");
            }
            if (personLastNameName != "")
            {
                connectionHelper.sqlCommand.Parameters.AddWithValue("@lastName", personLastNameName);
                elements.Add("Inhabitants.lastname = @lastName");
            }

            whereClause = string.Join(" AND ", elements);

            string query = $@"SELECT id,{fields} FROM Inhabitants WHERE {whereClause}";
            connectionHelper.sqlCommand.CommandText = query;

            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                inhabitant = new Inhabitant();
                inhabitant.Fill(reader);
                inhabitants.Add(inhabitant);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();

            return inhabitants;

        }

        public List<Inhabitant> Get(ConnectionHelper connectionHelper, AddressRegistrationEnum addressRegistration)
        {
            List<Inhabitant> inhabitants = new List<Inhabitant>();
            Inhabitant inhabitant;
            string query = $"SELECT id, {fields} FROM Inhabitants WHERE AddressReg = @reg";
            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@reg", addressRegistration);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                inhabitant = new Inhabitant();
                inhabitant.Fill(reader);
                inhabitants.Add(inhabitant);
            };
            reader.Close();
            connectionHelper.sqlConnection.Close();

            return inhabitants;


        }

        public List<Inhabitant> Get(ConnectionHelper connectionHelper, OwnershipStateEnum ownershipState)
        {
            List<Inhabitant> inhabitants = new List<Inhabitant>();
            Inhabitant inhabitant;
            string query = $"SELECT id, {fields} FROM Inhabitants WHERE ownershipState = @ownership";
            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@ownership", ownershipState);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                inhabitant = new Inhabitant();
                inhabitant.Fill(reader);
                inhabitants.Add(inhabitant);
            };
            reader.Close();
            connectionHelper.sqlConnection.Close();

            return inhabitants;

        }

        public List<Inhabitant> Get(ConnectionHelper connectionHelper, ResidenceStateEnum residence)
        {
            List<Inhabitant> inhabitants = new List<Inhabitant>();
            Inhabitant inhabitant;
            string query = $"SELECT id, {fields} FROM Inhabitants WHERE residenceState = @residence";
            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@residence", residence);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                inhabitant = new Inhabitant();
                inhabitant.Fill(reader);
                inhabitants.Add(inhabitant);
            };
            reader.Close();
            connectionHelper.sqlConnection.Close();

            return inhabitants;

        }

        public Inhabitant Get(ConnectionHelper connectionHelper, int id)
        {
            Inhabitant inhabitant;
            string query = $"SELECT id, {fields} FROM Inhabitants WHERE id = @id";
            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", id);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            reader.Read();
            inhabitant = new Inhabitant();
            inhabitant.Fill(reader);
            reader.Close();
            connectionHelper.sqlConnection.Close();

            return inhabitant;

        }


        public List<Inhabitant> Get(ConnectionHelper connectionHelper)
        {
            return Get(connectionHelper, null);
        }

        //DELETE
        public void Delete(ConnectionHelper connectionHelper)
        {
            string query = "DELETE FROM inhabitants WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        public void Delete(ConnectionHelper connectionHelper, Address address, Address.AddressType addressType = Address.AddressType.Permanent)
        {
            string addressField = Address.FieldName[addressType];
            string query = $"DELETE FROM inhabitants WHERE {addressField} = @addrId";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrId", address.Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }



        //UPDATE
        public void Update(ConnectionHelper connectionHelper)
        {
            string query = @"UPDATE inhabitants
                             SET firstname = @fname, middlename = @mName,
                                lastname = @lName, gender = @gender,
                                addressId = @addrId, currentAddressId = @currAddrId, permanentAddressId = @permAddrId,
                                relationToOwner = @rel, addressReg = @addrReg, note = @note,
                                phoneNumber = @phone, residenceState = @resState, ownershipState = @ownership
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
            if (PermanentAddressId == -1)
                connectionHelper.sqlCommand.Parameters.AddWithValue("@permAddrId", System.DBNull.Value);
            else
                connectionHelper.sqlCommand.Parameters.AddWithValue("@permAddrId", PermanentAddressId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@rel", RelToOwner);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@addrReg", AddressReg);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@note", Note);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@phone", PhoneNumber);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@resState", ResidenceState);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@ownership", OwnershipState);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();

            if (InhabitantUpdated != null)
            {
                InhabitantUpdated(new object(), new EventArgs());
            }
        }
    }

}
