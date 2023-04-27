using ProjetoIntegrador.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoIntegrador.DBC
{
    public class CyclesDBC
    {
        public static string ConnectionString = @"DATA SOURCE=DESKTOP-2KBJAIR\SQLEXPRESS2023; INTEGRATED SECURITY=SSPI; INITIAL CATALOG=ProjetoIntegrador";

        public static List<Cycles> GetCyclesList()
        {
            List<Cycles> list = new List<Cycles>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlCommand = "SELECT * FROM Cycles";

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Cycles Cycles = new Cycles()
                            {
                                Id = reader.GetInt32(0),
                                Numero = reader.GetInt32(1)
                            };
                            list.Add(Cycles);
                        }
                    }
                }
            }

            return list;
        }

        public static void InsertCycles(Cycles Cycles)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlCommand = "INSERT INTO Cycles([Numero]) VALUES (@Numero)";

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    command.Parameters.AddWithValue("@Numero", Cycles.Numero);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}