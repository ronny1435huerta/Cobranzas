using Cobranzas.Models.Bean;

namespace Cobranzas.Models.Interface
{
    public interface IPasos_cobranza
    {
        IEnumerable<Pasos_cobranza> ListaPasos_cobranza();

        //Agregamos un nuevo procurador
        string Agregar(Pasos_cobranza pasos_cobranza);

        //Buscamos un procurador por su id
        Pasos_cobranza Buscar(int id);
        //Actualizamos un procurador
        string Actualizar(Pasos_cobranza pasos_cobranza);
        //Eliminamos un procurador
        string Eliminar(int pasos_cobranza);
    }
}
