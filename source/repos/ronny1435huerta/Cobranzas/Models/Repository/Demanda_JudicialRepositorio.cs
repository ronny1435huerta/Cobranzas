using Cobranzas.Models.Bean;
using Cobranzas.Models.Interface;
using Microsoft.Data.SqlClient;

namespace Cobranzas.Models.Repository
{
    public class Demanda_JudicialRepositorio:IDemanda_Judicial
    {
        private string cadena;
        public Demanda_JudicialRepositorio()
        {
            //De esta forma obtenemos la cadena de conexión
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("cn");
        }
        public string Actualizar(Demanda_Judicial demanda_judicial)
        {
            string mensaje = "";
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_ACTUALIZAR_DEMANDA_JUDICIAL", cn);
                    //aperturamos la base de datos
                    cn.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_DEMANDA_PRINCIPAL_JUDICIAL", demanda_judicial.ID_DEMANDA_PRINCIPAL_JUDICIAL);
                    cmd.Parameters.AddWithValue("@ACCION", demanda_judicial.ACCION);
                    //realizamos la respectiva ejecucion...
                    int c = cmd.ExecuteNonQuery();
                    mensaje = $"Demanda principal actualizada {c} en la base";
                    cn.Close();
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }    //fin del catch...

            }   //fin del using...

            //retornamos el mensaje
            return mensaje;
        }

        public string Agregar(Demanda_Judicial demanda_Interna)
        {
            string mensaje = "";
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_GUARDAR_DEMANDA_JUDICIAL", cn);
                    //aperturar la base de datos
                    cn.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Agregamos los atributos del procurador
                    cmd.Parameters.AddWithValue("@ACCION", demanda_Interna.ACCION);
                    //realizamos la respectiva ejecucion...
                    int c = cmd.ExecuteNonQuery();
                    mensaje = $"Demanda principal insertada {c} en base";


                }
                catch (Exception ex)
                {

                    mensaje = ex.Message;
                }   //fin del catch.....

            }    //fin del using...

            //retornamos el mensaje...
            return mensaje;
        }

        public Demanda_Judicial Buscar(int id)
        {
            Demanda_Judicial? bus = ListaDemanda_judicial().Where(v => v.ID_DEMANDA_PRINCIPAL_JUDICIAL == id).FirstOrDefault();
            //retornamos el registro buscardo
            return bus;
        }

        public string Eliminar(int demanda_interna)
        {
            string mensaje = "";
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_ELIMINAR_DEMANDA_JUDICIAL", cn);
                    //aperturamos la base de datos
                    cn.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ID_DEMANDA_PRINCIPAL_JUDICIAL", demanda_interna);
                    //realizamos la respectiva ejecucion...
                    int c = cmd.ExecuteNonQuery();
                    mensaje = $"Status demanda principal eliminada {c} en base";
                    cn.Close();
                }
                catch (Exception ex)
                {
                    mensaje = ex.Message;
                }    //fin del catch...

            }   //fin del using...

            //retornamos el mensaje
            return mensaje;
        }

        public IEnumerable<Demanda_Judicial> ListaDemanda_judicial()
        {
            List<Demanda_Judicial> demandas_judiciales = new List<Demanda_Judicial>();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //abrimos la conexiòn
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_DEMANDA_JUDICIAL", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //ingresaremos los datos obtenidos de la base de datos en el orden correspondiente
                    demandas_judiciales.Add(new Demanda_Judicial
                    {
                        ID_DEMANDA_PRINCIPAL_JUDICIAL = dr.GetInt32(0),
                        ACCION = dr.GetString(1),
                    });
                }
                dr.Close();

            }
            return demandas_judiciales;
        }
    }//fin de la clase
}
