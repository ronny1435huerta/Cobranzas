namespace Cobranzas.Models.Bean
{
    public class Procurador_Distrito
    {
        public int ID_PROCURADOR { get; set; }
        public string NOMBRE_PROCURADOR { get; set; }
        public int ID_DISTRITO { get; set; }
        public string NOMBRE { get; set; }
        public List<Distrito>? DistritosDisponibles { get; set; }
        public List<Distrito>? DistritosAsignados { get; set; }
    }
}
