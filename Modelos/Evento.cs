using System.ComponentModel.DataAnnotations;

namespace TareasBlazor.Modelos
{
    /// <summary>
    /// Modelo que representa un evento.
    /// Incluye propiedades para el nombre, fecha, ubicación y una descripción larga.
    /// La fecha se valida para que no sea posterior al 31/12/2075.
    /// </summary>
    public class Evento
    {
        // Identificador único del evento.
        public int Id { get; set; }
        // Nombre del evento.
        public string Nombre { get; set; } = string.Empty;

        // Fecha del evento, validada para que sea anterior al 31/12/2075.
        [Range(typeof(DateTime), "1/1/1900", "12/31/2075", ErrorMessage = "La fecha debe ser anterior al 31/12/2075.")]
        public DateTime Fecha { get; set; }
        // Ubicación donde se realiza el evento.
        public string Ubicacion { get; set; } = string.Empty;
        // Descripción larga del evento.
        public string Descripcion { get; set; } = string.Empty;
    }
}
