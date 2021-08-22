using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;

namespace GraduationProject.Models
{
    class Disease : Model<Disease>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public enum DiseaseType { Animal, Inhabitant };

        public override string ToString()
        {
            return Name;
        }

        public void Fill(SQLiteDataReader reader)
        {
            Id = reader.GetInt32(0);
            Name = reader.GetString(1);
        }
        public void Insert(ConnectionHelper connectionHelper)
        {
            throw new NotImplementedException();
        }

        public List<Disease> Get(ConnectionHelper connectionHelper, DiseaseType diseaseType)
        {
            List<Disease> diseases = new List<Disease>();
            Disease disease;
            string tableName = diseaseType == DiseaseType.Animal ? "AnimalsDiseases" : "InhabitantsDiseases";
            string query = $"SELECT id, name FROM {tableName} ORDER BY name";
            connectionHelper.NewConnection(query);
            SQLiteDataReader reader = connectionHelper.sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                disease = new Disease();
                disease.Fill(reader);
                diseases.Add(disease);
            }
            reader.Close();
            connectionHelper.sqlConnection.Close();
            return diseases;
        }
        public List<Disease> Get(ConnectionHelper connectionHelper)
        {
            throw new NotImplementedException();
        }

        public void Delete(ConnectionHelper connectionHelper)
        {
            throw new NotImplementedException();
        }

        public void Update(ConnectionHelper connectionHelper)
        {
            throw new NotImplementedException();
        }

        
    }
}
