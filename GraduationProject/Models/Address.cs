using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GraduationProject.Models
{
    public class Address: Model<Address>
    {
        //Полета
        public int id { get; set; }
        public int streetId { get; set; }
        public int number { get; set; }
        public double squaring { get; set; } = 0;
        public int habitallity { get; set; } = 0;
        public int numResBuildings { get; set; } = 0;
        public int numAgrBuildings { get; set; } = 0;
        public int numCows { get; set; } = 0;
        public int numSheep { get; set; } = 0;
        public int numGoats { get; set; } = 0;
        public int numHorses { get; set; } = 0;
        public int numDonkeys { get; set; } = 0;
        public int numFeathered { get; set; } = 0;
        public int numWalnutTrees { get; set; } = 0;

        //SELECT клауза
        string selectClause = @"SELECT DISTINCT Addresses.id, streetId, number, squaring, habitallity, numResBuildings,
                                numAgrBuildings, numCows, numSheep, numGoats, numHorses, numDonkeys, numFeathered, numWalnutTrees ";

        public override string ToString()
        {
            ConnectionHelper connectionHelper = new ConnectionHelper();
            string query = "SELECT name FROM Streets WHERE id = @id";
            string strName;
            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", streetId);
            SqlDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            reader.Read();
            strName = reader.GetString(0);
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return strName + " " + number.ToString();
        }

        //Запълване на обекта с информация
        public void Fill(SqlDataReader reader)
        {
            id = reader.GetInt32(0);
            streetId = reader.GetInt32(1);
            number = reader.GetInt32(2);
            squaring = reader.GetDouble(3);
            habitallity = reader.GetInt32(4);
            numResBuildings = reader.GetInt32(5);
            numAgrBuildings = reader.GetInt32(6);
            numCows = reader.GetInt32(7);
            numSheep = reader.GetInt32(8);
            numGoats = reader.GetInt32(9);
            numHorses = reader.GetInt32(10);
            numDonkeys = reader.GetInt32(11);
            numFeathered = reader.GetInt32(12);
            numWalnutTrees = reader.GetInt32(13);
        }

        //Заявки

        //INSERT
        public int Insert(ConnectionHelper connectionHelper)
        {
            int id;
            string query = @"INSERT INTO Addresses 
                            (streetId, number, squaring, habitallity, numResBuildings, numAgrBuildings, numCows, numSheep, numGoats, numHorses, numDonkeys, numFeathered, numWalnutTrees )
                            output INSERTED.id
                            VALUES (@StrId, @num, @sq, @hab, @resB, @agrB, @cows, @sheep, @goats, @horses, @donkeys, @feathered, @Walnut); ";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@StrId", streetId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@num", number);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@sq", squaring);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@hab", habitallity);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@resB", numResBuildings);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@agrB", numAgrBuildings);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@cows", numCows);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@sheep", numSheep);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@goats", numGoats);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@horses", numHorses);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@donkeys", numDonkeys);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@feathered", numFeathered);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@Walnut", numWalnutTrees);

            id = (int) connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();

         
            return id;
        }

        //GET
        public List<Address> Get(ConnectionHelper connectionHelper, Street street)
        {
            string query = $"{selectClause} FROM Addresses WHERE streetId = @strId";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@strId", street.id);
            
            return executeGetQuery(connectionHelper);
        }

        public List<Address> Get(ConnectionHelper connectionHelper,string personName)
        {
            string query = @$"{selectClause} FROM Addresses, GuestsInQuarantine
                WHERE Addresses.id = GuestsInQuarantine.addressId AND
                (GuestsInQuarantine.firstname LIKE @persName + '%' OR GuestsInQuarantine.middlename LIKE @persName + '%' OR GuestsInQuarantine.lastname LIKE @persName + '%' )
                UNION
               {selectClause} FROM Addresses, Residents
                WHERE Addresses.id = Residents.addressId AND
                (Residents.firstname LIKE @persName + '%' OR Residents.middlename LIKE @persName + '%' OR Residents.lastname LIKE @persName + '%' )";

            connectionHelper.NewConnection(query);
                connectionHelper.sqlCommand.Parameters.AddWithValue("@persName", personName);
            
            return executeGetQuery(connectionHelper);

        }


        public List<Address> Get(ConnectionHelper connectionHelper)
        {
            string query = $"{selectClause} FROM Addresses";
               
            connectionHelper.NewConnection(query);

            return executeGetQuery(connectionHelper);
        }

        private List<Address> executeGetQuery(ConnectionHelper connectionHelper)
        {
            List<Address> addresses = new List<Address>();
            Address address;
            SqlDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
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

        //DETELE
        public void Delete(ConnectionHelper connectionHelper)
        {
            string query = "DELETE FROM Addresses WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", id);
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

            connectionHelper.sqlCommand.Parameters.AddWithValue("@id",id);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@strId", streetId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@num", number);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@sq", squaring);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@hab", habitallity);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numRes", numResBuildings);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numAgr", numAgrBuildings);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numCows", numCows);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numSheep", numSheep);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numGoats", numGoats);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numHorses", numHorses);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numDonkeys", numDonkeys);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numFeathered", numFeathered);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@numWalnut", numWalnutTrees);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
}
