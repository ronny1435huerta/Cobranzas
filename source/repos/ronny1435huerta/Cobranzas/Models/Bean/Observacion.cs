namespace Cobranzas.Models.Bean
{
    public class Observacion
    {
        public int ID_OBSERVACIONES { get; set; }
        public int ID_BASE { get; set; } 
	    public DateTime FECHA_REGISTRO { get; set; } 
        public int ID_USUARIO { get; set; }
	    public string DESCRIPCION { get; set; } = null!;
    }
}
