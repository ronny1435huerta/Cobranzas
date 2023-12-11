using Cobranzas.Models.Bean;
using Cobranzas.Models.Interface;
using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.Data.SqlClient;

namespace Cobranzas.Models.Repository
{
    public class UsuarioRepositorio: IUsuario
    {
        private string cadena;
        public UsuarioRepositorio()
        {
            //De esta forma obtenemos la cadena de conexión
            cadena = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("cn");
        }
            List<Usuario> usuarios = new List<Usuario>();

        public IEnumerable<Usuario> ListarUsuario()
        {
            List<Usuario> usuarios = new List<Usuario>();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_USUARIO", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    usuarios.Add(new Usuario
                    {
                        ID_USUARIO=dr.GetInt32(0),
                        NOMBRE_USUARIO=dr.GetString(1),
                        CONTRA_USUARIO=dr.GetString(2),
                        USERNAME=dr.GetString(3),
                        FECHA_REGISTRO=dr.GetDateTime(4),
                        FECHA_NACIMIENTO= dr.GetDateTime(5),
                        STATUS_USUARIO=dr.GetInt32(6),
                        EMAIL=dr.GetString(7),
                        FLAG=dr.GetInt32(8),
                        APELLIDO_PATERNO= dr.GetString(9),
                        APELLIDO_MATERNO=dr.GetString(10),
                        TELEFONO=dr.GetString(11),
                    });
                }

                dr.Close();
            }

            return usuarios;
        }
        public IEnumerable<Rol> ListarRol()
        {
            List<Rol> Rol = new List<Rol>();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //abrimos la conexiòn
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_ROL", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //ingresaremos los datos obtenidos de la base de datos en el orden correspondiente
                    Rol.Add(new Rol
                    {
                        ID_ROL = dr.GetInt32(0),
                        NOMBRE = dr.GetString(1),
                    });
                }
                dr.Close();

            }
            return Rol;
        }
        public IEnumerable<Usuario_Rol> ListarUsuarioRol()
        {
            List<Usuario_Rol> USUARIO_ROLES = new List<Usuario_Rol>();
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                //abrimos la conexiòn
                cn.Open();
                SqlCommand cmd = new SqlCommand("SP_LISTAR_USUARIO_ROL", cn);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //ingresaremos los datos obtenidos de la base de datos en el orden correspondiente
                    USUARIO_ROLES.Add(new Usuario_Rol
                    {
                        ID_USUARIO = dr.GetInt32(0),
                        ID_ROL = dr.GetInt32(1),
                    });
                }
                dr.Close();

            }
            return USUARIO_ROLES;
        }


        public string RegistroUsuario(Usuario usuario)
        {
            string mensaje = "";
            using (SqlConnection cn = new SqlConnection(cadena))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("SP_REGISTRAR_USUARIO", cn);
                    //aperturar la base de datos
                    cn.Open();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    //Agregamos los atributos del procurador
                    cmd.Parameters.AddWithValue("@NOMBRE_USUARIO", usuario.NOMBRE_USUARIO);
                    cmd.Parameters.AddWithValue("@CONTRA_USUARIO", usuario.CONTRA_USUARIO);
                    cmd.Parameters.AddWithValue("@USERNAME", usuario.USERNAME);
                    cmd.Parameters.AddWithValue("@FECHA_REGISTRO", usuario.FECHA_REGISTRO);
                    cmd.Parameters.AddWithValue("@FECHA_NACIMIENTO", usuario.FECHA_NACIMIENTO);
                    cmd.Parameters.AddWithValue("@STATUS_USUARIO", usuario.STATUS_USUARIO);
                    cmd.Parameters.AddWithValue("@EMAIL", usuario.EMAIL);
                    cmd.Parameters.AddWithValue("@FLAG", usuario.FLAG);
                    cmd.Parameters.AddWithValue("@APELLIDO_PATERNO", usuario.APELLIDO_PATERNO);
                    cmd.Parameters.AddWithValue("@APELLIDO_MATERNO", usuario.APELLIDO_MATERNO);
                    cmd.Parameters.AddWithValue("@TELEFONO", usuario.TELEFONO);
                    //realizamos la respectiva ejecucion...
                    int c = cmd.ExecuteNonQuery();

                    mensaje = $"Usuario registrado {c} en base";
                    cn.Close();

                }
                catch (Exception ex)
                {

                    mensaje = ex.Message;
                } 

            }  

           
            return mensaje;
        }
    } //fin de la clase repositorio
} //fin del namespace
