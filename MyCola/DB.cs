using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCola
{
    class DB
    {
        public MySqlConnection connection()
        {
            string connection = "server=localhost; database=my_cola; uid=root; password=123456";
        }
    }
}
