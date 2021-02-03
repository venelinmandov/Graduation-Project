using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace GraduationProject.Models
{
    public interface Model
    {
       public void Fill(SqlDataReader reader);

        public void Insert(ConnectionHelper connectionHelper);
    }
}
