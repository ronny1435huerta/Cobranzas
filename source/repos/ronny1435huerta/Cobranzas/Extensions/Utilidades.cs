using BCrypt.Net;
using System.ComponentModel.DataAnnotations;

namespace Cobranzas.Extensions
{
    public class Utilidades
    {
        public class MayusculasAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                if (value != null)
                {
                    string stringValue = value.ToString();
                    if (stringValue != stringValue.ToUpper())
                    {
                        return new ValidationResult(ErrorMessage);
                    }
                }
                return ValidationResult.Success;
            }
        }
        public static string EncriptarCadena(string cadena)
        {
            try
            {
                // Genera un salt aleatorio para cada contraseña
                string salt = BCrypt.Net.BCrypt.GenerateSalt();

                // Hashea la cadena utilizando bcrypt
                string hash = BCrypt.Net.BCrypt.HashPassword(cadena, salt);

                return hash;
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades (puedes registrarla, lanzarla de nuevo, etc.)
                Console.WriteLine($"Error al encriptar cadena: {ex.Message}");
                return null;
            }
        }

        public static bool VerificarCadena(string cadena, string hashAlmacenado)
        {
            try
            {
                // Verifica la cadena con el hash almacenado
                return BCrypt.Net.BCrypt.Verify(cadena, hashAlmacenado);
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades (puedes registrarla, lanzarla de nuevo, etc.)
                Console.WriteLine($"Error al verificar cadena: {ex.Message}");
                return false;
            }
        }
    }
}
