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
        public AddressHabitability Habitallity { get; set; } = 0;
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
        public int NumMulberryTrees { get; set; } = 0;
        public int NumOldTrees { get; set; } = 0;
        public int NumCenturyOldTrees { get; set; } = 0;
        public string Note { get; set; }

        public string streetName;

        //Dictionaries
        public static Dictionary<AddressType, string> FieldName
        {
            get => new Dictionary<AddressType, string>
        {
            { AddressType.Permanent,"AddressId"},
            { AddressType.Current,"CurrentAddressId"}
        };}


        
        //Enums
        public enum AddressType { Permanent, Current };
        public enum AddressHabitability { Desolate, Inhabited, TemporaryInhabited, OutOfRegulation };



        
        //SELECT клауза
        string selectClause = @"SELECT DISTINCT Addresses.id, streetId, Addresses.number, squaring, habitability, numResBuildings,
                                numAgrBuildings, numCows, numSheep, numGoats, numHorses, numDonkeys, numFeathered, numPigs, numWalnutTrees, numMulberryTrees, numOldTrees, numCenturyOldTrees, Addresses.note, Streets.name";

        public override string ToString() => streetName + " " + Number.ToString();
       

        //Запълване на обекта с информация
        public void Fill(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            StreetId = reader.GetInt32(1);
            Number = reader.GetInt32(2);
            Squaring = reader.GetDouble(3);
            Habitallity = (AddressHabitability)reader.GetInt32(4);
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
            NumMulberryTrees = reader.GetInt32(15);
            NumOldTrees = reader.GetInt32(16);
            NumCenturyOldTrees = reader.GetInt32(17);
            Note = reader.GetString(18);
            streetName = reader.GetString(19);
        }

        //Заявки

        //INSERT
        public void Insert(ConnectionHelper connectionHelper)
        {
            long id;
            string query = @"INSERT INTO Addresses 
                            (streetId, number, squaring, habitability, numResBuildings, numAgrBuildings, numCows, numSheep, numGoats, numHorses, numDonkeys, numFeathered, numPigs, numWalnutTrees, numMulberryTrees, numOldTrees, numCenturyOldTrees, note  )
                            VALUES (@StrId, @num, @sq, @hab, @resB, @agrB, @cows, @sheep, @goats, @horses, @donkeys, @feathered, @pigs, @Walnut, @Mulberry, @Old, @Century, @note)";

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
            connectionHelper.sqlCommand.Parameters.AddWithValue("@Mulberry", NumMulberryTrees);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@Old", NumOldTrees);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@Century", NumCenturyOldTrees);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@note", Note);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlCommand.CommandText = "SELECT last_insert_rowid()";
            id = (long)connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();
         
            Id = (int)id;
        }

        //GET

        /// <summary>
        /// Всички адреси
        /// </summary>
        /// <param name="connectionHelper"></param>
        /// <returns></returns>
        public List<Address> Get(ConnectionHelper connectionHelper)
        {
            string query = @$"{selectClause} FROM Addresses, Streets 
                            WHERE Addresses.streetId = Streets.id 
                            ORDER BY  name, number";

            connectionHelper.NewConnection(query);

            return ExecuteGetQuery(connectionHelper);
        }

        /// <summary>
        /// Адреси по дадена улица
        /// </summary>
        /// <param name="connectionHelper"></param>
        /// <param name="street"></param>
        /// <returns></returns>
        public List<Address> Get(ConnectionHelper connectionHelper, Street street)
        {
            string query = $"{selectClause} FROM Addresses, Streets WHERE Addresses.streetId = Streets.id AND streetId = @strId ORDER BY number";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@strId", street.Id);
            
            return ExecuteGetQuery(connectionHelper);
        }

        /// <summary>
        /// Адреси по име/имена на обитател 
        /// </summary>
        /// <param name="connectionHelper"></param>
        /// <param name="option"></param>
        /// <param name="personFirstName"></param>
        /// <param name="personMiddleName"></param>
        /// <param name="personLastNameName"></param>
        /// <returns></returns>
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
                case 1: tables += " ,Guests"; whereClause += "Guests.addressId = Addresses.id AND " + MakeWhereElementsString("Guests"); break;
                case 2: tables += " ,Residents, Guests";
                    whereClause += "Residents.addressId = Addresses.id AND Guests.addressId = Addresses.id AND (("
                        + MakeWhereElementsString("Residents") + ") OR (" + MakeWhereElementsString("Guests") + "))"; break;
                default: tables += "";break;            
            }


            
            string query = $@"{selectClause} FROM {tables} WHERE {whereClause}";
            connectionHelper.sqlCommand.CommandText = query;
            return ExecuteGetQuery(connectionHelper);
            

        }

        /// <summary>
        /// Адреси стойността на чиито оказана колона има стоност по-голяма от 0
        /// </summary>
        /// <param name="connectionHelper"></param>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public List<Address> Get(ConnectionHelper connectionHelper, string columnName)
        {
            string query = $"{selectClause} FROM Addresses, Streets WHERE Streets.id = Addresses.streetId AND {columnName} > 0";

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

        /// <summary>
        /// Адрес с оказаното id
        /// </summary>
        /// <param name="connectionHelper"></param>
        /// <param name="id"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Адрес по оказана улица и номер
        /// </summary>
        /// <param name="connectionHelper"></param>
        /// <param name="streetId"></param>
        /// <param name="number"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Адреси с оказаната обитаемост
        /// </summary>
        /// <param name="connectionHelper"></param>
        /// <param name="addressHabitabillity"></param>
        /// <returns></returns>
        public List<Address> Get(ConnectionHelper connectionHelper, AddressHabitability addressHabitabillity)
        {
            string query = @$"{selectClause} FROM Addresses, Streets 
                            WHERE Streets.id = Addresses.streetId AND Addresses.habitability = @habitability";
            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@habitability", addressHabitabillity);
            return ExecuteGetQuery(connectionHelper);
        }
       
        /// <summary>
        /// Адреси с посочена карантина.
        /// </summary>
        /// <param name="connectionHelper"></param>
        /// <param name="animal"></param>
        /// <returns></returns>
        public List<Address> Get(ConnectionHelper connectionHelper, AnimalsQuarantine.AnimalEnum animal)
        {
            
            string query = @$"{selectClause} FROM Addresses, Streets, AnimalsQuarantines
                            WHERE Streets.id = Addresses.streetId AND AnimalsQuarantines.addressId = Addresses.id
                            AND AnimalsQuarantines.animal = @animal";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@animal", animal);
            return ExecuteGetQuery(connectionHelper);
        }

        public List<Address> GetAddressesWithQuarantines(ConnectionHelper connectionHelper)
        {

            string query = @$"{selectClause} FROM Addresses, Streets, Inhabitants, InhabitantsQuarantines
                            WHERE Streets.id = Addresses.streetId AND InhabitantsQuarantines.inhabitantId = Inhabitants.id
                            AND Inhabitants.addressId = Addresses.id";

            connectionHelper.NewConnection(query);
            return ExecuteGetQuery(connectionHelper);
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
            new Inhabitant().Delete(connectionHelper, this);
            
            foreach (Inhabitant resident in new Inhabitant().Get(connectionHelper, this, AddressType.Current))
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
                            SET streetId = @strId,      number = @num,                  squaring = @sq,
                                habitability = @hab,     numResBuildings = @numRes,     numAgrBuildings = @numAgr,
                                numCows = @numCows,     numSheep = @numSheep,           numGoats = @numGoats,
                                numHorses = @numHorses, numDonkeys = @numDonkeys,       numFeathered = @numFeathered,
                                numPigs = @numPigs,     numWalnutTrees = @numWalnut,    numMulberryTrees = @mulberry,
                                numOldTrees = @old,     numCenturyOldTrees = @century,  note = @note
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
            connectionHelper.sqlCommand.Parameters.AddWithValue("@mulberry", NumMulberryTrees);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@old", NumOldTrees);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@century", NumCenturyOldTrees);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@note", Note);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
}
