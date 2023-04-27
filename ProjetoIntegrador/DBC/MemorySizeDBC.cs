using ProjetoIntegrador.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoIntegrador.DBC
{
    public class MemorySizeDBC
    {
        public static string ConnectionString = @"DATA SOURCE=DESKTOP-2KBJAIR\SQLEXPRESS2023; INTEGRATED SECURITY=SSPI; INITIAL CATALOG=ProjetoIntegrador";

        public static List<MemorySize> GetMemorySizeList()
        {
            List<MemorySize> list = new List<MemorySize>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlCommand = "SELECT * FROM MemorySize";

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MemorySize MemorySize = new MemorySize()
                            {
                                Id = reader.GetInt32(0),
                                Tamanho = reader.GetString(1)
                            };
                            list.Add(MemorySize);
                        }
                    }
                }
            }

            return list;
        }

        public static void InsertMemorySize(MemorySize MemorySize)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlCommand = "INSERT INTO MemorySize([Tamanho]) VALUES (@num1)";

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    command.Parameters.AddWithValue("@num1", MemorySize.Tamanho);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}