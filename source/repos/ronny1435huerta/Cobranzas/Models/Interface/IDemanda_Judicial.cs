using Cobranzas.Models.Bean;

namespace Cobranzas.Models.Interface
{
    public interface IDemanda_Judicial
    {
        IEnumerable<Demanda_Judicial> ListaDemanda_judicial();

        //Agregamos un nuevo procurador
        string Agregar(Demanda_Judicial demanda_judicial);

        //Buscamos un procurador por su id
        Demanda_Judicial Buscar(int id);
        //Actualizamos un procurador
        string Actualizar(Demanda_Judicial demanda_judicial);
        //Eliminamos un procurador
        string Eliminar(int demanda_judicial);
    }
}
