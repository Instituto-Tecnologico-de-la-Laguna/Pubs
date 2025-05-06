using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pubs
{
    public class Datos
    {
        string cadenaConexion= "Data Source=DESKTOP-H69TC9M\\SQLEXPRESS;initial catalog=pubs; integrated security=true";
        SqlConnection conexion=null;
        private SqlConnection abrirConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        private void cerrarConexion()
        {
            try {              
                    conexion.Close();                
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }

        }
        public DataSet comandoDS(string cmd)
        { 
            DataSet ds = new DataSet();
            try
            {               
                SqlDataAdapter comando = new SqlDataAdapter(cmd, abrirConexion());
                comando.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
            finally {
               // if (ds!= null)
                //    cerrarConexion();
            }
        }
    }
}
