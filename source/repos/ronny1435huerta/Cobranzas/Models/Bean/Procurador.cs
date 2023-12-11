using System.ComponentModel.DataAnnotations;
using static Cobranzas.Extensions.Utilidades;

namespace Cobranzas.Models.Bean
{
    public class Procurador
    {
        public int ID_PROCURADOR { get; set; }
        [Required(ErrorMessage= "Debe ingresar el nombre del procurador")]
        [Mayusculas(ErrorMessage = "El nombre debe estar en mayúsculas")]
        public string? NOMBRE_PROCURADOR { get; set; }        
        public List<Distrito> DISTRITOS { get; set; }
        public Procurador()
        {
            DISTRITOS = new List<Distrito>();
        }
    }

   
}
