using System.ComponentModel.DataAnnotations;
using static Cobranzas.Extensions.Utilidades;

namespace Cobranzas.Models.Bean
{
    public class Apoderado
    {
        public int ID_APODERADO { get; set; }
        [Display(Name = "Nombre de apoderado")]
        [Required(ErrorMessage ="Se requiere ingresar el nombre")]
        [Mayusculas(ErrorMessage = "El nombre debe estar en mayúsculas")]
        public string NOMBRE_APODERADO { get; set; } = null!;
      
    }
}
