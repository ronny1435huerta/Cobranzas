using Cobranzas.Models.Bean;

namespace Cobranzas.Models.Interface
{
    public interface IPrincipal
    {
        //Distrito
        IEnumerable<Distrito> ListarDistritos();
        //Bancos
        IEnumerable<Banco> ListarBancos();
        //Moneda
        IEnumerable<Moneda> ListarMonedas();
        //Documento
        IEnumerable<Documento> ListarDocumentos();
    }
}
