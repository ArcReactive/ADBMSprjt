﻿using System;
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
            myCon = new SqlConnection("Data Source=DESKTOP-UKFGO45;Initial Catalog=ADBMSpro1;Integrated Security=True"); //Nuwan
            //myCon = new SqlConnection("Data Source=LAPTOP-74BFFP6C;Initial Catalog=ADBMSpro1;Integrated Security=True"); //Kavindu
            //myCon = new SqlConnection("Data Source=DESKTOP-4JL5SE9;Initial Catalog=ADBMSpro1;Integrated Security=True"); //Vikum
            //myCon = new SqlConnection(""); //Lakith
            myCon.Open();

            return myCon;
        }

    }
}
