using static Cobranzas.Extensions.Utilidades;
using System.ComponentModel.DataAnnotations;

namespace Cobranzas.Models.Bean
{
    public class Demanda_Interna
    {
        public int ID_DEMANDA_INTERNA_PRINCIPAL { get; set; }
        [Display(Name = "Acción")]
        [Required(ErrorMessage = "Se requiere ingresar la acción")]
        [Mayusculas(ErrorMessage = "El nombre debe estar en mayúsculas")]
        public string ACCION { get; set; } = null!; 
    }
}
