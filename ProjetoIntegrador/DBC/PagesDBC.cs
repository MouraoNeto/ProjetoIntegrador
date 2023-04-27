using System.Collections.Generic;
using ProjetoIntegrador.Entidades;
using System.Data.SqlClient;

namespace ProjetoIntegrador.DBC
{
    public class PagesDBC
    {
        public static string ConnectionString = @"DATA SOURCE=DESKTOP-2KBJAIR\SQLEXPRESS2023; INTEGRATED SECURITY=SSPI; INITIAL CATALOG=ProjetoIntegrador";

        public static List<Pages> GetPagesList()
        {
            List<Pages> list = new List<Pages>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlCommand = "SELECT * FROM Pages";

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Pages Pages = new Pages()
                            {
                                Id = reader.GetInt32(0),
                                Cod = reader.GetInt32(1),
                                Numero = reader.GetInt32(2)
                            };
                            list.Add(Pages);
                        }
                    }
                }
            }

            return list;
        }

        public static void InsertPages(Pages Pages)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlCommand = "INSERT INTO Pages([Cod], [Numero]) VALUES (@Cod, @Numero)";

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    command.Parameters.AddWithValue("@num1", Pages.Cod);
                    command.Parameters.AddWithValue("@num1", Pages.Numero);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}