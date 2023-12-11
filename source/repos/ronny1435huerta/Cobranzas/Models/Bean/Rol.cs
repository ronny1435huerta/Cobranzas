using System.ComponentModel.DataAnnotations;

namespace Cobranzas.Models.Bean
{
    public class Rol
    {
        public int ID_ROL { get; set; }
        public string NOMBRE { get; set; } = null!;
    }
}
