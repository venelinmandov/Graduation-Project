using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;

namespace GraduationProject.Models
{
    public interface Model<T>
    {
        //Запълване на обекта с информация
        public void Fill(SQLiteDataReader reader);

        //Заявки
        public List<T> Get(ConnectionHelper connectionHelper);

        public void Insert(ConnectionHelper connectionHelper);

        public void Delete(ConnectionHelper connectionHelper);

        public void Update(ConnectionHelper connectionHelper);

    }
}
