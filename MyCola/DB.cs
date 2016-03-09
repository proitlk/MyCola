using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyCola
{
    public class DB
    {
        public MySqlConnection connection()
        {
            string strConn = "server=localhost; database=my_cola; uid=root; password=123456";
            return new MySqlConnection(strConn);
        }
    }
}
