using ProjetoIntegrador.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoIntegrador.DBC
{
    public class WsClockDBC
    {
        public static string ConnectionString = @"DATA SOURCE=MOURAO-NITRO; INTEGRATED SECURITY=SSPI; INITIAL CATALOG=ProjetoIntegrador";

        public static List<WsClock> GetWsClockList()
        {
            List<WsClock> list = new List<WsClock>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlCommand = "SELECT * FROM WsClock";

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            WsClock WsClock = new WsClock()
                            {
                                Id = reader.GetInt32(0),
                                TLU = reader.GetDateTime(1),
                                BitM = reader.GetInt32(2),
                                Age = reader.GetInt32(3),
                                CVT = reader.GetInt32(4)
                            };
                            list.Add(WsClock);
                        }
                    }
                }
            }

            return list;
        }

        public static void InsertWsClock(WsClock WsClock)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlCommand = "INSERT INTO WsClock([TLU],[BitM],[CVT],[Age]) VALUES (@TLU, @BitM, @CVT, @Age)";

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    command.Parameters.AddWithValue("@TLU", WsClock.TLU);
                    command.Parameters.AddWithValue("@BitM", WsClock.BitM);
                    command.Parameters.AddWithValue("@CVT", WsClock.CVT);
                    command.Parameters.AddWithValue("@Age", WsClock.Age);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}