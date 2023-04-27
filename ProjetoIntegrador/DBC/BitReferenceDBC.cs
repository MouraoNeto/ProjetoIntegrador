using ProjetoIntegrador.Entidades;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace ProjetoIntegrador.DBC
{
    public class BitReferenceDBC
    {
        public static string ConnectionString = @"DATA SOURCE=MOURAO-NITRO; INTEGRATED SECURITY=SSPI; INITIAL CATALOG=ProjetoIntegrador";

        public static List<BitReference> GetBitReferenceList()
        {
            List<BitReference> list = new List<BitReference>();

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlCommand = "SELECT * FROM BitReference";

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            BitReference BitReference = new BitReference()
                            {
                                Id = reader.GetInt32(0),
                                Num1 = reader.GetInt32(1)
                            };
                            list.Add(BitReference);
                        }
                    }
                }
            }

            return list;
        }

        public static void InsertBitReference(BitReference BitReference)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();

                string sqlCommand = "INSERT INTO BitReference([Num1]) VALUES (@num1)";

                using (SqlCommand command = new SqlCommand(sqlCommand, connection))
                {
                    command.Parameters.AddWithValue("@num1", BitReference.Num1);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}