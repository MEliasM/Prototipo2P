﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo
{
    public class clsSentencias
    {
        clsConexion con = new clsConexion();
        public OdbcDataAdapter llenarTbl(string tabla)
        {
            string sql = "SELECT *FROM" + tabla + " ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }

    }
}
