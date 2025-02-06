using TareasBlazor.Modelos;

namespace TareasBlazor.Servicios
{
    /// <summary>
    /// Servicio que gestiona la sesión del usuario actual.
    /// Permite almacenar el usuario que ha iniciado sesión.
    /// </summary>
    public class SesionUsuarioService
    {
        // Usuario actualmente registrado en la sesión.
        public Usuario? UsuarioRegistrado { get; set; }
    }
}
