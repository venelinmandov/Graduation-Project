using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace GraduationProject.Models
{
    public class Street: Model<Street>
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
        public List<Street> Get(ConnectionHelper connectionHelper, string name = "")
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

        public List<Street> Get(ConnectionHelper connectionHelper)
        {
            return Get(connectionHelper,"");
        }


        public int Insert(ConnectionHelper connectionHelper)
        {
            int id;
            string query = "INSERT INTO Streets (name) output INSERTED.id VALUES (@name)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@name", name);
            id = (int) connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();
            return id;
        }

        public void Delete(ConnectionHelper connectionHelper)
        {
            string query = "DELETE FROM Streets WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        public void Update(ConnectionHelper connectionHelper)
        {
            throw new System.NotImplementedException();
        }
    }
}
