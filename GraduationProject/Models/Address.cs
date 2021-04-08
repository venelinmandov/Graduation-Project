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
        public int Habitallity { get; set; } = 0;
        public int NumResBuildings { get; set; } = 0;
        public int NumAgrBuildings { get; set; } = 0;
        public int NumCows { get; set; } = 0;
        public int NumSheep { get; set; } = 0;
        public int NumGoats { get; set; } = 0;
        public int NumHorses { get; set; } = 0;
        public int NumDonkeys { get; set; } = 0;
        public int NumFeathered { get; set; } = 0;
        public int NumWalnutTrees { get; set; } = 0;

        private string streetName;

        //SELECT клауза
        string selectClause = @"SELECT DISTINCT Addresses.id, streetId, number, squaring, habitallity, numResBuildings,
                                numAgrBuildings, numCows, numSheep, numGoats, numHorses, numDonkeys, numFeathered, numWalnutTrees, Streets.name";

        public override string ToString() => streetName + " " + Number.ToString();
       

        //Запълване на обекта с информация
        public void Fill(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            StreetId = reader.GetInt32(1);
            Number = reader.GetInt32(2);
            Squaring = reader.GetDouble(3);
            Habitallity = reader.GetInt32(4);
            NumResBuildings = reader.GetInt32(5);
            NumAgrBuildings = reader.GetInt32(6);
            NumCows = reader.GetInt32(7);
            NumSheep = reader.GetInt32(8);
            NumGoats = reader.GetInt32(9);
            NumHorses = reader.GetInt32(10);
            NumDonkeys = reader.GetInt32(11);
            NumFeathered = reader.GetInt32(12);
            NumWalnutTrees = reader.GetInt32(13);
            streetName = reader.GetString(14);
        }

        //Заявки

        //INSERT
        public int Insert(ConnectionHelper connectionHelper)
        {
            long id;
            string query = @"INSERT INTO Addresses 
                            (streetId, number, squaring, habitallity, numResBuildings, numAgrBuildings, numCows, numSheep, numGoats, numHorses, numDonkeys, numFeathered, numWalnutTrees )
                            VALUES (@StrId, @num, @sq, @hab, @resB, @agrB, @cows, @sheep, @goats, @horses, @donkeys, @feathered, @Walnut); ";

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

        public List<Address> Get(ConnectionHelper connectionHelper,string personName)
        {
            string query = @$"({selectClause} FROM Addresses, GuestsInQuarantine, Streets
                WHERE Addresses.streetId = Streets.id AND Addresses.id = GuestsInQuarantine.addressId AND
                (GuestsInQuarantine.firstname LIKE @persName + '%' OR GuestsInQuarantine.middlename LIKE @persName + '%' OR GuestsInQuarantine.lastname LIKE @persName + '%' )
                UNION
               {selectClause} FROM Addresses, Residents, Streets
                WHERE Addresses.streetId = Streets.id AND Addresses.id = Residents.addressId AND
                (Residents.firstname LIKE @persName + '%' OR Residents.middlename LIKE @persName + '%' OR Residents.lastname LIKE @persName + '%' )) ORDER BY streetId, number";

            connectionHelper.NewConnection(query);
                connectionHelper.sqlCommand.Parameters.AddWithValue("@persName", personName);
            
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
                                numHorses = @numHorses, numDonkeys = @numDonkeys,  numFeathered = @numFeathered,
                                numWalnutTrees = @numWalnut
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
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numWalnut", NumWalnutTrees);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
}
