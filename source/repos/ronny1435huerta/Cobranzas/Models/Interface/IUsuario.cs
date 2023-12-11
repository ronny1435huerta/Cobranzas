using Cobranzas.Models.Bean;

namespace Cobranzas.Models.Interface
{
    public interface IUsuario
    {
        //Listaremos los usuarios
        IEnumerable<Usuario> ListarUsuario();
        IEnumerable<Rol> ListarRol();
        IEnumerable<Usuario_Rol> ListarUsuarioRol();

        string RegistroUsuario(Usuario usuario);

    }
}
