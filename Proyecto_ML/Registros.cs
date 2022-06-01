using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_ML
{
    //public class Registros
    //{
    //    Conexion cn = new Conexion();
        
    //    public DataTable MostrarRegistros()
    //    {
    //        SqlDataAdapter da = new SqlDataAdapter("ML_MOSTRARREGISTROS", cn.LeerCadena());
    //        da.SelectCommand.CommandType = CommandType.StoredProcedure;
    //        DataTable dt = new DataTable();
    //        da.Fill(dt);
    //        return dt;
    //    }
    //}

    public class Consulta
    {

        public DataTable MostrarFacturas(string id, string ot)
        {
            DataTable dt = new DataTable();

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);
            cn.Open();

            SqlCommand command = new SqlCommand("sp_SelectRegistroFacturas", cn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@IdMain", id);
            param = new SqlParameter("@OrdenDeTrabajo", ot);
            param.Direction = ParameterDirection.Input;
            command.Parameters.Add(param);

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            da.Fill(dt);
            return dt;
        }
    }
}
