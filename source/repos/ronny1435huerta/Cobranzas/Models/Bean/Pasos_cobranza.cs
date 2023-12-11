using System.ComponentModel.DataAnnotations;
using static Cobranzas.Extensions.Utilidades;

namespace Cobranzas.Models.Bean
{
    public class Pasos_cobranza
    {
        public int ID_PASOS_COBRANZA {get;set;}
        [Display(Name = "Acción")]
        [Required(ErrorMessage = "Se requiere ingresar el nombre de la acción")]
        [Mayusculas(ErrorMessage = "El nombre de la acción debe estar en mayúsculas")]
        public string ACCION { get; set; } = null!;
    }
}
