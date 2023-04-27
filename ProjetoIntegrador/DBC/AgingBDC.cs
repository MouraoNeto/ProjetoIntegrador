using ProjetoIntegrador.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoIntegrador.DBC
{
    public class AgingBDC
    {
        public static string ConnectionString = @"DATA SOURCE=MOURAO-NITRO; INTEGRATED SECURITY=SSPI; INITIAL CATALOG=ProjetoIntegrador";

        public static List<Aging> GetAgingList()
        {
            List<Aging> list = new List<Aging>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlCommand = "SELECT * FROM Aging";

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Aging aging = new Aging()
                            {
                                Id = reader.GetInt32(0),
                                Contador = reader.GetInt32(1)
                            };
                            list.Add(aging);
                        }
                    }
                }
            }

            return list;
        }

        public static void InsertAging(Aging aging)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlCommand = "INSERT INTO Aging([Contador]) VALUES (@contador)";

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    command.Parameters.AddWithValue("@contador", aging.Contador);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}