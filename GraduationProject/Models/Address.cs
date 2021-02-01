using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GraduationProject.Models
{
    public class Address : Model
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

        public static int InsertAddress(ConnectionHelper connectionHelper, Address address)
        {
            int id;
            string query = @"INSERT INTO Addresses 
                            (streetId, number, squaring, habitallity, numResBuildings, numAgrBuildings, numCows, numSheep, numGoats, numHorses, numDonkeys, numFeathered, numWalnutTrees ) 
                            VALUES (@StrId, @num, @sq, @hab, @resB, @agrB, @cows, @sheep, @goats, @horses, @donkeys, @feathered, @Walnut)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@StrId", address.streetId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@num", address.number);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@sq", address.squaring);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@hab", address.habitallity);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@resB", address.numResBuildings);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@agrB", address.numAgrBuildings);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@cows", address.numCows);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@sheep", address.numSheep);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@goats", address.numGoats);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@horses", address.numHorses);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@donkeys", address.numDonkeys);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@feathered", address.numFeathered);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@Walnut", address.numWalnutTrees);

            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();

            query = @"SELECT id  FROM Addresses 
                    WHERE streetId = @StrId AND number = @num";
            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@StrId", address.streetId);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@num", address.number);
            SqlDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            reader.Read();
            id = reader.GetInt32(0);

            connectionHelper.sqlConnection.Close();
            return id;
        }

        public static List<Address> GetAddresses(ConnectionHelper connectionHelper, object obj = null, string criteria = "")
        {
            List<Address> addresses = new List<Address>();
            Address address;
            string param = "";

  
            string[] queryConcats = new string[] 
            { "",
              " WHERE streetId = @param",
              @", Residents, GusetsInQuarantine 
                    WHERE Addresses.id = Residents.AddressId AND Addresses.id = GusetsInQuarantine.AddressId AND
                    Residents.firstName LIKE '@param%' OR GusetsInQuarantine.firstName LIKE '@param%' OR
                    Residents.lastName LIKE '@param%' OR GusetsInQuarantine.lastName LIKE '@param%'"
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
             
            string query = @"SELECT id,streetId, number, squaring, habitallity, numResBuildings, numAgrBuildings, numCows, numSheep, numGoats, numHorses, numDonkeys, numFeathered, numWalnutTrees
                            FROM Addresses" + queryConcats[state];
            connectionHelper.NewConnection(query);
            if (param != "")
                connectionHelper.sqlCommand.Parameters.AddWithValue("@param",param);
            SqlDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                address = new Address();
                address.Fill(reader);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return addresses;
            
        }

 
    }
}
