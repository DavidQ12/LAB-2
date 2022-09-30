using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRACTICA_NOSE.Properties;
using System.Configuration;

namespace PRACTICA_NOSE.DAL
{
    public class DATABASE
    {public static string getStrConnection()
        {
            return Settings.Default.empleadosConnectionString;
        }
        public SqlConnection getConnection()
        {
             SqlConnection Con = new SqlConnection(getStrConnection());
            return Con;

        }


    }
}
