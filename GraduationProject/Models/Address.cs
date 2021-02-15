using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GraduationProject.Models
{
    public class Address: Model<Address>
    {
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

        public List<Address> Get(ConnectionHelper connectionHelper, object obj = null, string criteria = "")
        {
            List<Address> addresses = new List<Address>();
            Address address;
            string param = "2";

            string[] queryConcats = new string[] 
            { "",
              " WHERE streetId = @param",
              @" ,GuestsInQuarantine
                WHERE Addresses.id = GuestsInQuarantine.addressId AND
                (GuestsInQuarantine.firstname LIKE @param + '%' OR GuestsInQuarantine.middlename LIKE @param + '%' OR GuestsInQuarantine.lastname LIKE @param + '%' )
                UNION
                SELECT  Addresses.id, streetId, number, squaring, habitallity, numResBuildings, numAgrBuildings, numCows, numSheep, numGoats, numHorses, numDonkeys, numFeathered, numWalnutTrees 
                FROM Addresses,Residents
                WHERE Addresses.id = Residents.addressId AND
                (Residents.firstname LIKE @param + '%' OR Residents.middlename LIKE @param + '%' OR Residents.lastname LIKE @param + '%' )"
            };
      
            int state = 0;
            switch (criteria)
            {
                case "street":
                    state = 1;
                    param = ((Street)obj).id.ToString();
                    break;
                case "person":
                    state = 2;
                    param = (string)obj;
                    break;
            }
             
            string query = @"SELECT DISTINCT Addresses.id, streetId, number, squaring, habitallity, numResBuildings,
                            numAgrBuildings, numCows, numSheep, numGoats, numHorses, numDonkeys, numFeathered, numWalnutTrees FROM Addresses" + queryConcats[state];
            connectionHelper.NewConnection(query);
            if (param != "")
                connectionHelper.sqlCommand.Parameters.AddWithValue("@param", param);
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

        public List<Address> Get(ConnectionHelper connectionHelper)
        {
            return Get(connectionHelper,null,"");
        }
    }
}
