using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http;

namespace PetDataADO
{
    public class ConnectedArchitecture
    {
        public static void GetAllCats(string conString, string query, out SqlConnection connection, out SqlCommand command, out SqlDataReader reader)
        {
            using (connection=new SqlConnection(conString)) // opens the connection with Sql database
            {
                try
                {
                    connection.Open();
                    using (command = new SqlCommand(query, connection))
                    {
                        reader=command.ExecuteReader();// this command will exceute the command and return the values
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine($"{reader[0]} - {reader["Name"]}");
                            }
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                    //log errors
                }
                finally {
                    connection.Close();
                }
               
            }
        }
        public static void UpdateCatNameById(string conString, out SqlConnection connection, out SqlCommand command, int id, string name)
        {
            string query = "UpdateCatName";
            using (connection = new SqlConnection(conString))
            {
                try
                {                    
                    using (command=new SqlCommand(query,connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter parameter;
                        parameter = command.Parameters.Add("@Id", SqlDbType.Int);
                        parameter.Value = id;

                        parameter = command.Parameters.Add("@name", SqlDbType.VarChar);
                        parameter.Value = name;

                        connection.Open();

                        int rowsAffected=command.ExecuteNonQuery();
                        Console.WriteLine($"Cat name updated, {rowsAffected} row(s) affected");
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //delete by id

        public static void DeleteCatById(string conString, out SqlConnection connection, out SqlCommand command, int id)
        {
            string query = "SP_Deletecat";
            using (connection = new SqlConnection(conString))
            {
                try
                {
                    using (command = new SqlCommand(query, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        SqlParameter parameter;
                        parameter = command.Parameters.Add("@catId", SqlDbType.Int);
                        parameter.Value = id;

                        connection.Open();

                        int rowsAffected = command.ExecuteNonQuery();
                        Console.WriteLine($"Cat name Deleted, {rowsAffected} row(s) affected");
                    }
                }
                finally
                {
                    connection.Close();
                }
            }
        }




    }
}
