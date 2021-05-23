using System.Collections.Generic;
using System.Data.SQLite;

namespace GraduationProject.Models
{
    public class Address: Model<Address>
    {
        public int Id { get; set; }
        public int StreetId { get; set; }
        public int Number { get; set; }
        public double Squaring { get; set; } = 0;
        public AddressHabitabillity Habitallity { get; set; } = 0;
        public int NumResBuildings { get; set; } = 0;
        public int NumAgrBuildings { get; set; } = 0;
        public int NumCows { get; set; } = 0;
        public int NumSheep { get; set; } = 0;
        public int NumGoats { get; set; } = 0;
        public int NumHorses { get; set; } = 0;
        public int NumDonkeys { get; set; } = 0;
        public int NumFeathered { get; set; } = 0;
        public int NumPigs { get; set; } = 0;
        public int NumWalnutTrees { get; set; } = 0;

        public static Dictionary<AddressType, string> FieldName
        {
            get => new Dictionary<AddressType, string>
        {
            { AddressType.Permanent,"AddressId"},
            { AddressType.Current,"CurrentAddressId"}
        };}


        public string streetName;

        public enum AddressType { Permanent, Current };
        public enum AddressHabitabillity { Desolate, Inhabited, TemporaryInhabited };

        
        //SELECT клауза
        string selectClause = @"SELECT DISTINCT Addresses.id, streetId, number, squaring, habitallity, numResBuildings,
                                numAgrBuildings, numCows, numSheep, numGoats, numHorses, numDonkeys, numFeathered, numPigs, numWalnutTrees, Streets.name";

        public override string ToString() => streetName + " " + Number.ToString();
       

        //Запълване на обекта с информация
        public void Fill(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            StreetId = reader.GetInt32(1);
            Number = reader.GetInt32(2);
            Squaring = reader.GetDouble(3);
            Habitallity = (AddressHabitabillity)reader.GetInt32(4);
            NumResBuildings = reader.GetInt32(5);
            NumAgrBuildings = reader.GetInt32(6);
            NumCows = reader.GetInt32(7);
            NumSheep = reader.GetInt32(8);
            NumGoats = reader.GetInt32(9);
            NumHorses = reader.GetInt32(10);
            NumDonkeys = reader.GetInt32(11);
            NumFeathered = reader.GetInt32(12);
            NumPigs = reader.GetInt32(13);
            NumWalnutTrees = reader.GetInt32(14);
            streetName = reader.GetString(15);
        }

        //Заявки

        //INSERT
        public int Insert(ConnectionHelper connectionHelper)
        {
            long id;
            string query = @"INSERT INTO Addresses 
                            (streetId, number, squaring, habitallity, numResBuildings, numAgrBuildings, numCows, numSheep, numGoats, numHorses, numDonkeys, numFeathered, numPigs, numWalnutTrees )
                            VALUES (@StrId, @num, @sq, @hab, @resB, @agrB, @cows, @sheep, @goats, @horses, @donkeys, @feathered, @pigs, @Walnut); ";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@StrId", StreetId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@num", Number);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@sq", Squaring);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@hab", Habitallity);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@resB", NumResBuildings);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@agrB", NumAgrBuildings);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@cows", NumCows);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@sheep", NumSheep);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@goats", NumGoats);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@horses", NumHorses);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@donkeys", NumDonkeys);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@feathered", NumFeathered);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@pigs", NumPigs);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@Walnut", NumWalnutTrees);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlCommand.CommandText = "SELECT last_insert_rowid()";
            id = (long)connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();

         
            return (int)id;
        }

        //GET
        public List<Address> Get(ConnectionHelper connectionHelper, Street street)
        {
            string query = $"{selectClause} FROM Addresses, Streets WHERE Addresses.streetId = Streets.id AND streetId = @strId ORDER BY number";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@strId", street.Id);
            
            return ExecuteGetQuery(connectionHelper);
        }

        public List<Address> Get(ConnectionHelper connectionHelper, int option, string personFirstName, string personMiddleName, string personLastNameName)
        {
           

            string whereClause = "Addresses.streetId = Streets.id AND ";
            string tables = "Addresses, Streets";

            string MakeWhereElementsString(string tableName)
            {
                List<string> elements = new List<string>();
                string whereClause;
                connectionHelper.NewConnection();
                if (personFirstName != "")
                {
                    elements.Add($"{tableName}.firstname = @firstname");
                    connectionHelper.sqlCommand.Parameters.AddWithValue("@firstname", personFirstName);
                }

                if (personMiddleName != "")
                {
                    elements.Add($"{tableName}.middlename = @middleName");
                    connectionHelper.sqlCommand.Parameters.AddWithValue("@middleName", personMiddleName);

                }

                if (personLastNameName != "")
                {
                    elements.Add($"{tableName}.lastname = @lastName");
                    connectionHelper.sqlCommand.Parameters.AddWithValue("@lastName", personLastNameName);

                }

                whereClause = string.Join(" AND " , elements);
                return whereClause;
            }

           
            
            /*
           Option: 
              0 - Жител
              1 - Гост
              2 - Всички
           */
            switch (option)
            {
                case 0: tables += " ,Residents"; whereClause += "Residents.addressId = Addresses.id AND " + MakeWhereElementsString("Residents"); break;
                case 1: tables += " ,GuestsInQuarantine"; whereClause += "GuestsInQuarantine.addressId = Addresses.id AND " + MakeWhereElementsString("GuestsInQuarantine"); break;
                case 2: tables += " ,Residents, GuestsInQuarantine";
                    whereClause += "Residents.addressId = Addresses.id AND GuestsInQuarantine.addressId = Addresses.id AND (("
                        + MakeWhereElementsString("Residents") + ") OR (" + MakeWhereElementsString("GuestsInQuarantine") + "))"; break;
                default: tables += "";break;            
            }


            
            string query = $@"{selectClause} FROM {tables} WHERE {whereClause}";
            connectionHelper.sqlCommand.CommandText = query;
            return ExecuteGetQuery(connectionHelper);
            

        }

        public List<Address> Get(ConnectionHelper connectionHelper, string animal)
        {
            string query = $"{selectClause} FROM Addresses, Streets WHERE Streets.id = Addresses.streetId AND {animal} > 0";

            connectionHelper.NewConnection(query);
            return ExecuteGetQuery(connectionHelper);
        }

        public List<Address> Get(ConnectionHelper connectionHelper, Dog.DogType dogType = Dog.DogType.All)
        {
            string dogTypeCondition = dogType == Dog.DogType.All ? "" : " AND Dogs.type = @type";
            string query = $@"{selectClause} FROM Addresses, Dogs, Streets
                            WHERE Addresses.streetId = Streets.id AND Dogs.addressId = Addresses.id{dogTypeCondition} ORDER BY  name, number";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@type",dogType);

            return ExecuteGetQuery(connectionHelper);
        }


        public List<Address> Get(ConnectionHelper connectionHelper)
        {
            string query = @$"{selectClause} FROM Addresses, Streets 
                            WHERE Addresses.streetId = Streets.id 
                            ORDER BY  name, number";
               
            connectionHelper.NewConnection(query);

            return ExecuteGetQuery(connectionHelper);
        }

        
       
        public Address Get(ConnectionHelper connectionHelper, int id)
        {
            Address address = new Address();
            string query = @$"{selectClause} FROM Addresses, Streets 
                            WHERE Streets.id = Addresses.streetId AND Addresses.id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", id);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            reader.Read();
            if (!reader.HasRows)
            {
                reader.Close();
                connectionHelper.sqlConnection.Close();
                return null;
            } 
            address.Fill(reader);
            reader.Close();
            connectionHelper.sqlConnection.Close();

            return address;
        }

        public Address Get(ConnectionHelper connectionHelper, int streetId, int number)
        {

            string query = @$"{selectClause} FROM Addresses, Streets 
                            WHERE Streets.id = Addresses.streetId AND StreetId = @strId AND Addresses.number = @num";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@strId", streetId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@num", number);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            reader.Read();
            if (!reader.HasRows)
            {
                reader.Close();
                connectionHelper.sqlConnection.Close();
                return null;
            }
            Address address = new Address();
            address.Fill(reader);
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return address;
        }
        private List<Address> ExecuteGetQuery(ConnectionHelper connectionHelper)
        {
            List<Address> addresses = new List<Address>();
            Address address;
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                address = new Address();
                address.Fill(reader);
                addresses.Add(address);

            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return addresses;

        }

        //DELETE
        public void Delete(ConnectionHelper connectionHelper)
        {
            new Dog().Delete(connectionHelper, this);
            new Person().Delete(connectionHelper, this);
            new Resident().Delete(connectionHelper, this);

            foreach (Person person in new Person().Get(connectionHelper, this, AddressType.Current))
            {
                person.CurrentAddressId = -1;
                person.Update(connectionHelper);
            }
            foreach (Resident resident in new Resident().Get(connectionHelper, this, AddressType.Current))
            {
                resident.CurrentAddressId = -1;
                resident.Update(connectionHelper);
            }



            string query = "DELETE FROM Addresses WHERE id = @id";
            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        //UPDATE
        public void Update(ConnectionHelper connectionHelper)
        {
            string query = @"UPDATE Addresses
                            SET streetId = @strId,      number = @num,              squaring = @sq,
                                habitallity = @hab,     numResBuildings = @numRes,  numAgrBuildings = @numAgr,
                                numCows = @numCows,     numSheep = @numSheep,       numGoats = @numGoats,
                                numHorses = @numHorses, numDonkeys = @numDonkeys,   numFeathered = @numFeathered,
                                numPigs = @numPigs,     numWalnutTrees = @numWalnut
                             WHERE id = @id";

            connectionHelper.NewConnection(query);

            connectionHelper.sqlCommand.Parameters.AddWithValue("@id",Id);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@strId", StreetId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@num", Number);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@sq", Squaring);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@hab", Habitallity);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numRes", NumResBuildings);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numAgr", NumAgrBuildings);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numCows", NumCows);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numSheep", NumSheep);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numGoats", NumGoats);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numHorses", NumHorses);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numDonkeys", NumDonkeys);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numFeathered", NumFeathered);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numPigs", NumPigs);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numWalnut", NumWalnutTrees);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
}
