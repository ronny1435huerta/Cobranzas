using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Xml.Linq;

namespace Cobranzas.Models.Bean
{
    public class Usuario
    {
        public int ID_USUARIO { get; set; }
        [Required(ErrorMessage = "Ingrese un nombre de usuario")]
        [Display(Name = "Nombre de usuario")]
        public string USERNAME { get; set; } = null!;
        [Required(ErrorMessage = "Ingrese una contraseña")]
        [Display(Name = "Contraseña")]
        [PasswordPropertyText]
        [Compare("passwordConfirm", ErrorMessage = "La contraseña no es igual")]
        public string CONTRA_USUARIO { get; set; } = null!;
        [Required(ErrorMessage ="Confirme su contraseña")]
        [Display(Name = "Confirme contraseña")]
        [PasswordPropertyText]
        public string? passwordConfirm { get; set; }
        
        [Display(Name = "Fecha de registro")]
        public DateTime FECHA_REGISTRO { get; set; }
        [Required(ErrorMessage ="Ingrese su fecha de nacimiento")]
        [Display(Name = "Fecha de nacimiento")]
        public DateTime FECHA_NACIMIENTO { get; set; }
        public int STATUS_USUARIO { get; set; }
        [Required(ErrorMessage ="Ingrese un correo electrónico")]
        [Display(Name = "Correo electrónico")]
        [EmailAddress]
        public string? EMAIL { get; set; }
        public int FLAG { get; set; }
        [Required(ErrorMessage = "Ingrese su nombre")]
        [Display(Name = "Nombres")]
        public string? NOMBRE_USUARIO { get; set; }
        [Required(ErrorMessage ="Ingrese su apellido paterno")]
        [Display(Name = "Apellido paterno")]
        public string? APELLIDO_PATERNO { get; set; }
        [Required(ErrorMessage ="Ingrese su apellido materno")]
        [Display(Name = "Apellido materno")]
        public string? APELLIDO_MATERNO { get; set; }
        [Required(ErrorMessage ="Ingrese su teléfono")]
        [Display(Name = "Teléfono")]
        [RegularExpression("9[0-9]{8}", ErrorMessage = "Ingrese un número de celular válido")]
        public string? TELEFONO { get; set; }
        public List<Rol>? roles { get; set; }
        public Usuario()
        {
            roles = new List<Rol>();
        }
    }
}
