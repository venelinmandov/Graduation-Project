using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace GraduationProject.Models
{
    public class Street: Model
    {
        public int id;
        public string name;

        public override string ToString()
        {
            return name;
        }

        public void Fill(SqlDataReader reader)
        {
            id = reader.GetInt32(0);
            name = reader.GetString(1);
        }

        //Заявки
        public static List<Street> GetStreets(ConnectionHelper connectionHelper, string name = "")
        {
            string queryConcat = "";
            if (name != "")
            {
                queryConcat = " WHERE name LIKE @name + '%'";
            }
            string query = "SELECT id, name FROM Streets" + queryConcat + " ORDER BY name";

            connectionHelper.NewConnection(query);

            List<Street> streets = new List<Street>();
            Street street;

            if (name != "")
            { 
                connectionHelper.sqlCommand.Parameters.AddWithValue("@name", name);
            }
            
                
            SqlDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                street = new Street();
                street.Fill(reader);
                streets.Add(street);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return streets;
        }




        public void InsertStreet(ConnectionHelper connectionHelper)
        {
            string query = "INSERT INTO Streets (name) VALUES (@name)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@name", name);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        public void DeleteStreet(ConnectionHelper connectionHelper)
        {
            string query = "DELETE FROM Streets WHERE id = @id";
            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        
    }
}
