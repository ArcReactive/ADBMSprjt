using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ADBMSpro01
{
    class DBconnection
    {
        //connection.
        public static SqlConnection myCon = null;


        //set connection path.
        public SqlConnection setCon()
        {
            myCon = new SqlConnection("Data Source=DESKTOP-UKFGO45;Initial Catalog=ADBMSpro1;Integrated Security=True");
            myCon.Open();

            return myCon;
        }

    }
}
