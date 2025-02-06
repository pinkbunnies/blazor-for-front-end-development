using System.ComponentModel.DataAnnotations;

namespace TareasBlazor.Modelos
{
    /// <summary>
    /// Modelo que representa un usuario.
    /// Incluye propiedades para el nombre, correo electrónico y contraseña.
    /// Se utilizan DataAnnotations para validar los campos.
    /// </summary>
    public class Usuario
    {
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El correo es obligatorio.")]
        [EmailAddress(ErrorMessage = "Correo inválido.")]
        public string CorreoElectronico { get; set; } = string.Empty;

        [Required(ErrorMessage = "La contraseña es obligatoria.")]
        public string Contraseña { get; set; } = string.Empty;
    }
}
