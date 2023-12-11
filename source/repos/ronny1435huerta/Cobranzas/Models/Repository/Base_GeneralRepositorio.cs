using Cobranzas.Models.Bean;
using Cobranzas.Models.Interface;
using Microsoft.Data.SqlClient;

namespace Cobranzas.Models.Repository
{
    public class Base_GeneralRepositorio : IBase_General
    {
        private string cadena;
        public Base_GeneralRepositorio()
        {
            //De esta forma obtenemos la cadena de conexión
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("cn");
        }
        public IEnumerable<Base_General> ListarBase()
        {
            List<Base_General> base_generals = new List<Base_General>();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //abrimos la conexiòn
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_BASE_GENERAL", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //ingresaremos los datos obtenidos de la base de datos en el orden correspondiente
                    base_generals.Add(new Base_General
                    {
                        ID_BASE =dr.GetInt32(0),
                        ALBUM =dr.GetString(1),
                        FECHA_CONSIGNACION = dr.GetDateTime(2),
                        MARCA = dr.GetString(3),
                        MODELO = dr.GetString(4),
                        PRECIO_PACTADO = dr.GetDecimal(5),
                        CONTRATO = dr.GetString(6),
                        ID_DOCUMENTO = dr.GetInt32(7),
                        NUMERO_DOCUMENTO = dr.GetString(8),
                        NOMBRE_PROPIETARIO = dr.GetString(9),
                        TIPO = dr.GetString(10),
                        CELULAR = dr.GetString(11),
                        CELULAR2 = dr.GetString(12),
                        CORREO = dr.GetString(13),
                        DIRECCION = dr.GetString(14),
                        ID_DISTRITO = dr.GetInt32(15),
                        TIPO_PENALIDAD = dr.GetString(16),
                        PAGARE = dr.GetString(17),
                        FECHA_COBRO = dr.GetDateTime(18),
                        ID_STATUS_CLIENTE = dr.GetInt32(19),
                        ID_DEMANDA_INTERNA_PRINCIPAL = dr.GetInt32(19),
                        ID_DEMANDA_PRINCIPAL_JUDICIAL = dr.GetInt32(20),
                        FECHA_INGRESO_DEMANDA = dr.GetDateTime(21),
                        FECHA_ARBITRAJE = dr.GetDateTime(22),
                        ID_MONEDA = dr.GetInt32(23),
                        PENALIDAD = dr.GetDecimal(24),
                        MORA = dr.GetDecimal(25),
                        MORA_TOTAL = dr.GetDecimal(26),
                        DIAS_MORA = dr.GetInt32(27),
                        GASTOS_COBRANZA = dr.GetDecimal(28),
                        GASTOS_COCHERA = dr.GetDecimal(29),
                        FECHA_EMBARGO = dr.GetDateTime(30),
                        GASTOS_COCHERA_TOTAL = dr.GetDecimal(31),
                        GASTO_TOTAL = dr.GetDecimal(32),
                        STATUS_SUNARP = dr.GetString(33),
                        MARCA_AUTO_CAUTELAR = dr.GetString(34),
                        MODELO_AUTO_CAUTELAR = dr.GetString(35),
                        FECHA_AUTO_CAUTELAR = dr.GetDateTime(36),
                        PARTIDA_REGISTRAL_AUTO_CAUTELAR = dr.GetString(37),
                        PLACA_AUTO_CAUTELAR = dr.GetString(38),
                        ID_STATUS_JUDICIAL = dr.GetInt32(39),
                        ID_STATUS_PODER_JUDICIAL = dr.GetInt32(40),
                        ID_PASO_COBRANZA = dr.GetInt32(41),
                        FECHA_INGRESO_MC = dr.GetDateTime(42),
                        FECHA_CONCESORIO = dr.GetDateTime(43),
                        ID_APODERADO = dr.GetInt32(44),
                        ID_PROCURADOR = dr.GetInt32(45),
                        TIPO_JUZGADO = dr.GetString(46),
                        ID_DISTRITO_JUZGADO = dr.GetInt32(47),
                        NUMERO_DE_JUZGADO = dr.GetString(48),
                        NUMERO_EXPEDIENTE = dr.GetString(49),
                        CODIGO_CAUTELAR = dr.GetString(50),
                        NOMBRE_ESPECIALISTA = dr.GetString(51),
                        MONTO_PETITORIO = dr.GetDecimal(52),
                        ID_TIPO_IMPULSO = dr.GetInt32(53),
                        ID_USUARIO = dr.GetInt32(54),
                        TIPO_SOLICITUD_MEDIDA_CAUTELAR = dr.GetString(55),
                        RESPUESTA_MEDIDA_CAUTELAR = dr.GetString(56),
                        MEDIDA_CAUTELAR = dr.GetString(57),
                        ESTADO_REGISTRO = dr.GetString(58),
                    });
                }
                dr.Close();

            }
            return base_generals;
        }
    }
}
