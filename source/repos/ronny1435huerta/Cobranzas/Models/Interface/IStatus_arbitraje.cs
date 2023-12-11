using Cobranzas.Models.Bean;

namespace Cobranzas.Models.Interface
{
    public interface IStatus_arbitraje
    {
        IEnumerable<Status_arbitraje> ListaStatus_arbitraje();

        //Agregamos un nuevo procurador
        string Agregar(Status_arbitraje status_arbitraje);

        //Buscamos un procurador por su id
        Status_arbitraje Buscar(int id);
        //Actualizamos un procurador
        string Actualizar(Status_arbitraje status_arbitraje);
        //Eliminamos un procurador
        string Eliminar(int status_arbitraje);
    }
}
