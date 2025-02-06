using TareasBlazor.Modelos;

namespace TareasBlazor.Servicios
{
    /// <summary>
    /// Servicio para gestionar la asistencia a eventos.
    /// Permite marcar la asistencia de un usuario a un evento y obtener la lista de asistentes.
    /// </summary>
    public class ServicioAsistencia
    {
        // Diccionario que asocia el ID de un evento con la lista de usuarios asistentes.
        private readonly Dictionary<int, List<Usuario>> asistenciaEventos = new();

        /// <summary>
        /// Registra la asistencia de un usuario a un evento.
        /// </summary>
        public void MarcarAsistencia(int idEvento, Usuario usuario)
        {
            if (!asistenciaEventos.ContainsKey(idEvento))
            {
                asistenciaEventos[idEvento] = new List<Usuario>();
            }
            asistenciaEventos[idEvento].Add(usuario);
        }

        /// <summary>
        /// Obtiene la lista de usuarios que han asistido a un evento.
        /// </summary>
        public List<Usuario> ObtenerAsistencia(int idEvento)
        {
            return asistenciaEventos.ContainsKey(idEvento)
                ? asistenciaEventos[idEvento]
                : new List<Usuario>();
        }
    }
}
