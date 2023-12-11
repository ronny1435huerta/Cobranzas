using static Cobranzas.Extensions.Utilidades;
using System.ComponentModel.DataAnnotations;

namespace Cobranzas.Models.Bean
{
    public class Tipo_impulso
    {
        public int ID_TIPO_IMPULSO { get; set; }
        [Display(Name = "Acción")]
        [Required(ErrorMessage = "Se requiere ingresar la acción")]
        [Mayusculas(ErrorMessage = "El nombre debe estar en mayúsculas")]
        public string? ACCION { get; set; }
    }
}
