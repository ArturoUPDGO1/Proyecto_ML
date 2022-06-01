using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ML
{
    public class Registros
    {
        Conexion cn = new Conexion();
        
        public DataTable MostrarRegistros()
        {
            SqlDataAdapter da = new SqlDataAdapter("ML_MOSTRARREGISTROS", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }

    class Consulta
    {
        Conexion cn = new Conexion();

        public DataTable MostrarFacturas()
        {
            SqlDataAdapter da = new SqlDataAdapter("sp_SelectRegistroFacturas", cn.LeerCadena());
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
