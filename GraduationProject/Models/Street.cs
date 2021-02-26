using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;


namespace GraduationProject.Models
{
    public class Street: Model<Street>
    {
        

        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        //Запълване на обекта с информация
        public void Fill(SqlDataReader reader)
        {
            Id = reader.GetInt32(0);
            Name = reader.GetString(1);
        }

        //Заявки
        
        //GET
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

        //INSERT
        public int Insert(ConnectionHelper connectionHelper)
        {
            int id;
            string query = "INSERT INTO Streets (name) output INSERTED.id VALUES (@name)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@name", Name);
            id = (int) connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();
            return id;
        }

        //DELETE
        public void Delete(ConnectionHelper connectionHelper)
        {
            string query = "DELETE FROM Streets WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }

        //UPDATE
        public void Update(ConnectionHelper connectionHelper)
        {

            string query = "UPDATE Streets SET name = @name WHERE id = @id";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@id", Id);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@name", Name);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlConnection.Close();
        }
    }
    
}
