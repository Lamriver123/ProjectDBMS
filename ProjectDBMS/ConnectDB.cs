﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDBMS
{
    internal class ConnectDB
    {
        static string connectionString = "Data Source=MSI;Initial Catalog=QUAN_LY;Integrated Security=True;Encrypt=False;";

        static public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
