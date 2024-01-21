using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExchangeAndMony.data
{
    class conection
    {
        public static SqlConnection con = new SqlConnection(@"Server =DESKTOP-6FOQ2KB\SQLEXPRESS;DataBase=db_Account1;Trusted_Connection=yes");

    }
}
