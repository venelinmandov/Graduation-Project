using System.Collections.Generic;
using System.Data.SQLite;
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
        public void Fill(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            Name = reader.GetString(1);
        }

        //Заявки
        
        //GET
        public List<Street> Get(ConnectionHelper connectionHelper, string name)
        {
            string queryConcat = "";
            if (name != "")
            {
                queryConcat = " WHERE name LIKE @name || '%' ";
            }
            string query = "SELECT id, name FROM Streets" + queryConcat + " ORDER BY name";

            connectionHelper.NewConnection(query);

            List<Street> streets = new List<Street>();
            Street street;

            if (name != "")
            {
                connectionHelper.sqlCommand.Parameters.AddWithValue("@name", name);
                
            }


            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
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
        public void Insert(ConnectionHelper connectionHelper)
        {
            long id;
            string query = "INSERT INTO Streets (name) VALUES (@name)";

            connectionHelper.NewConnection(query);
            connectionHelper.sqlCommand.Parameters.AddWithValue("@name", Name);
            connectionHelper.sqlCommand.ExecuteNonQuery();
            connectionHelper.sqlCommand.CommandText = "SELECT last_insert_rowid()";
            id = (long)connectionHelper.sqlCommand.ExecuteScalar();
            connectionHelper.sqlConnection.Close();


            Id = (int)id;
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
