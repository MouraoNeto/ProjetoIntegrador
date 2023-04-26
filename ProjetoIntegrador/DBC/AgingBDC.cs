using ProjetoIntegrador.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace ProjetoIntegrador.DBC
{
    public class AgingBDC
    {
        public AgingBDC()
        {
            SqlConnection connection = new SqlConnection(@"");

            connection.Open();
        }

        public static void InsertAging(Aging aging)
        {
            string sqlComamand = "InsertAging";


        }
    }
}