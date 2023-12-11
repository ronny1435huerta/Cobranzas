using Cobranzas.Models.Bean;

namespace Cobranzas.Models.Interface
{
    public interface IStatus_judicial
    {
        IEnumerable<status_judicial> ListaStatus_judicial();

        //Agregamos un nuevo procurador
        string Agregar(status_judicial status_Judicial);

        //Buscamos un procurador por su id
        status_judicial Buscar(int id);
        //Actualizamos un procurador
        string Actualizar(status_judicial status_judicial);
        //Eliminamos un procurador
        string Eliminar(int status_judicial);
    }
}
