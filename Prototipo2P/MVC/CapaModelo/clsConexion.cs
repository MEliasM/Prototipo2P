using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace CapaModelo
{
    class clsConexion
    {
        public OdbcConnection conexion()
        {
            OdbcConnection conn = new OdbcConnection("Dsn=Segundo_Parcial");
            try
            {
                conn.Open();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conecto");
            }
            return conn;
        }

        public void desconexion(OdbcConnection conn)
        {
            try
            {
                conn.Close();
            }
            catch (OdbcException)
            {
                Console.WriteLine("No Conecto");
            }
        }
    }
}
