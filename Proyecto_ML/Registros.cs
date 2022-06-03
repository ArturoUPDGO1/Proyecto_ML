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

        public DataTable MostrarFacturas(string id, string ot, string eco, string mon, string fc, string rs, string nf, string con, string ciu, string mci, string estml)
        {
            DataTable dt = new DataTable();

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["unica"].ConnectionString);
            cn.Open();

            SqlCommand command = new SqlCommand("sp_SelectRegistroFacturas", cn);
            command.CommandType = CommandType.StoredProcedure;

            SqlParameter param = new SqlParameter("@IdMain", id);
            command.Parameters.Add(param);
            param = new SqlParameter("@OrdenDeTrabajo", ot);
            command.Parameters.Add(param);
            param = new SqlParameter("@NumEconomico", eco);
            command.Parameters.Add(param);
            param = new SqlParameter("@Monto", mon);
            command.Parameters.Add(param);
            param = new SqlParameter("@FechaCot", fc);
            command.Parameters.Add(param);
            param = new SqlParameter("@RazonSocial", rs);
            command.Parameters.Add(param);
            param = new SqlParameter("@NumFactura", nf);
            command.Parameters.Add(param);
            param = new SqlParameter("@Conceptos", con);
            command.Parameters.Add(param);
            param = new SqlParameter("@Ciudad", ciu);
            command.Parameters.Add(param);
            param = new SqlParameter("@MontoCImpuesto", mci);
            command.Parameters.Add(param);
            param = new SqlParameter("@Estatus", estml);
            command.Parameters.Add(param);

            cn.Close();

            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = command;
            da.Fill(dt);
            return dt;
        }
    }
}
