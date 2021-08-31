using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetDataADO
{
    public class DisconnectedArchitecture
    {
        public static DataRowCollection GetCats(string conStr, string query, out SqlConnection connection, out SqlDataAdapter da, out DataSet ds)
        {
            using (connection= new SqlConnection(conStr))
            {
                da = new SqlDataAdapter(query, connection);// opens sql connection, fire the query, executes the query and get results
                ds = new DataSet();//to hold data from db
                int rows=da.Fill(ds, "Cats");
                if (rows != 0)
                {
                    return ds.Tables["Cats"].Rows;
                }
                else
                    throw new NullReferenceException();
            }
        }
    }
}
