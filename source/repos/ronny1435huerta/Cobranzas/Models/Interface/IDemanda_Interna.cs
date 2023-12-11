using Cobranzas.Models.Bean;

namespace Cobranzas.Models.Interface
{
    public interface IDemanda_Interna
    {
        IEnumerable<Demanda_Interna> ListaDemanda_interna();

        //Agregamos un nuevo procurador
        string Agregar(Demanda_Interna demanda_interna);

        //Buscamos un procurador por su id
        Demanda_Interna Buscar(int id);
        //Actualizamos un procurador
        string Actualizar(Demanda_Interna demanda_interna);
        //Eliminamos un procurador
        string Eliminar(int demanda_interna);
    }
}
