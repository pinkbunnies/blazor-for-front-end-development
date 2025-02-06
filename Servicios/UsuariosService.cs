using TareasBlazor.Modelos;

namespace TareasBlazor.Servicios
{
    /// <summary>
    /// Servicio para gestionar el registro de usuarios.
    /// Permite almacenar usuarios en memoria y verificar si un correo ya existe.
    /// </summary>
    public class UsuariosService
    {
        // Lista de usuarios registrados.
        private readonly List<Usuario> usuarios = new();

        /// <summary>
        /// Verifica si el correo electrónico ya está registrado (sin distinguir mayúsculas/minúsculas).
        /// </summary>
        public bool EmailExiste(string email)
        {
            return usuarios.Any(u => u.CorreoElectronico.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary>
        /// Registra un nuevo usuario.
        /// </summary>
        public void RegistrarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        /// <summary>
        /// Devuelve la lista de usuarios registrados.
        /// </summary>
        public IEnumerable<Usuario> ObtenerUsuarios() => usuarios;
    }
}
