using Ordenes2023.Dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordenes2023.Datos
{
    internal class Helper
    {
        private SqlConnection cnn;
        private static Helper instancia;

        private Helper()
       {
            cnn = new SqlConnection(@"Data Source=DESKTOP-SFDA7AL\MSSQLSERVER2;Initial Catalog=db_ordenes;Integrated Security=True");
            
        }
        public static Helper ObtenerInstancia()
        {
            if (instancia == null)
                instancia = new Helper();
            return instancia;
        }

        public DataTable ConsultarMateriales()
        {
            DataTable result = new DataTable();
            cnn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection= cnn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "[dbo].[SP_CONSULTAR_MATERIALES]";
            result.Load(cmd.ExecuteReader());
            cnn.Close();

            return result;
        }

        public DataTable ConsultarDB(string NombreSP)
        {
            DataTable tabla = new DataTable();
            cnn.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = cnn;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = NombreSP;

            tabla.Load(comando.ExecuteReader());
            cnn.Close();
            return tabla;
        }



        public bool EjecutarInsert (OrdenRetiro O)
        {
            bool resultado = true;
            SqlTransaction t = null;
            try
            {
                cnn.Open();
                t = cnn.BeginTransaction();
                SqlCommand comando = new SqlCommand();
                comando.Connection = cnn;
                comando.Transaction = t;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "SP_INSERTAR_ORDEN";
                comando.Parameters.AddWithValue("@responsable", O.responsable);
                

                SqlParameter parametro = new SqlParameter();
                parametro.ParameterName = "@nro";
                parametro.SqlDbType = SqlDbType.Int;
                parametro.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametro);

                comando.ExecuteNonQuery();

                int nroOrden = (int)parametro.Value;
                int detalleNro = 1;
                SqlCommand cmdDetalle;

                foreach (DetalleOrden dp in O.detalles)
                {
                    cmdDetalle = new SqlCommand("SP_INSERTAR_DETALLES", cnn, t);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@nro_orden", nroOrden);
                    cmdDetalle.Parameters.AddWithValue("@detalle", detalleNro);
                    cmdDetalle.Parameters.AddWithValue("@codigo", dp.material.codigo);
                    cmdDetalle.Parameters.AddWithValue("@cantidad", dp.cantidad);
                    cmdDetalle.ExecuteNonQuery();
                    detalleNro++;
                }
                t.Commit();
            }
            catch
            {
                if (t != null)
                    t.Rollback();
                resultado = false;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();
            }

            return resultado;
        }

        internal bool EjecutarInsert(Ordenes o)
        {
            throw new NotImplementedException();
        }
    }
}
