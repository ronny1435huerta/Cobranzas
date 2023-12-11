using Cobranzas.Models.Bean;
using Cobranzas.Models.Interface;
using Microsoft.Data.SqlClient;

namespace Cobranzas.Models.Repository
{
    public class PrincipalRepositorio : IPrincipal
    {
        private string cadena;
        public PrincipalRepositorio()
        {
            //De esta forma obtenemos la cadena de conexión
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("cn");
        }

        public IEnumerable<Banco> ListarBancos()
        {
            List<Banco> bancos = new List<Banco>();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //abrimos la conexiòn
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_BANCO", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //ingresaremos los datos obtenidos de la base de datos en el orden correspondiente
                    bancos.Add(new Banco
                    {
                        ID_BANCO = dr.GetInt32(0),
                        NOMBRE = dr.GetString(1),
                    });
                }
                dr.Close();

            }
            return bancos;
        }

        public IEnumerable<Distrito> ListarDistritos()
        {
            List<Distrito> distritos = new List<Distrito>();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //abrimos la conexiòn
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_DISTRITO", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //ingresaremos los datos obtenidos de la base de datos en el orden correspondiente
                    distritos.Add(new Distrito
                    {
                        ID_DISTRITO = dr.GetInt32(0),
                        NOMBRE = dr.GetString(1),
                    });
                }
                dr.Close();

            }
            return distritos;
        }

        public IEnumerable<Documento> ListarDocumentos()
        {
            List<Documento> documentos = new List<Documento>();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //abrimos la conexiòn
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_DOCUMENTO", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //ingresaremos los datos obtenidos de la base de datos en el orden correspondiente
                    documentos.Add(new Documento
                    {
                        ID_DOCUMENTO = dr.GetInt32(0),
                        TIPO = dr.GetString(1),
                    });
                }
                dr.Close();

            }
            return documentos;
        }

        public IEnumerable<Moneda> ListarMonedas()
        {
            List<Moneda> monedas = new List<Moneda>();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //abrimos la conexiòn
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_MONEDA", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //ingresaremos los datos obtenidos de la base de datos en el orden correspondiente
                    monedas.Add(new Moneda
                    {
                        ID_MONEDA = dr.GetInt32(0),
                        NOMBRE = dr.GetString(1),
                    });
                }
                dr.Close();

            }
            return monedas;
        }
    }
}
