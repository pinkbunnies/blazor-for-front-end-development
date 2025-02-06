using TareasBlazor.Modelos;

namespace TareasBlazor.Servicios
{
    /// <summary>
    /// Servicio para gestionar eventos.
    /// Almacena eventos en memoria y pre-carga 12 eventos de demostración.
    /// </summary>
    public class EventosService
    {
        // Lista que almacena los eventos en memoria.
        private readonly List<Evento> eventos = new();

        /// <summary>
        /// Constructor: pre-carga 12 eventos de demostración.
        /// </summary>
        public EventosService()
        {
            // Evento demo 1: Feria del Cerdito.
            eventos.Add(new Evento
            {
                Id = 1,
                Nombre = "Feria del Cerdito",
                Fecha = DateTime.Now.AddDays(5),
                Ubicacion = "Plaza Central",
                Descripcion = "Un evento donde se celebra la cultura del cerdito, con degustaciones y actividades para toda la familia."
            });
            
            // Evento demo 2: Concurso de Sonidos Cerditos.
            eventos.Add(new Evento
            {
                Id = 2,
                Nombre = "Concurso de Sonidos Cerditos",
                Fecha = DateTime.Now.AddDays(10),
                Ubicacion = "Auditorio Animal",
                Descripcion = "Participa en el concurso del mejor sonido cerdito. ¡Ven y demuestra tu talento!"
            });

            // Evento demo 3: Exposición de Arte Cerdito.
            eventos.Add(new Evento
            {
                Id = 3,
                Nombre = "Exposición de Arte Cerdito",
                Fecha = DateTime.Now.AddDays(15),
                Ubicacion = "Galería Cerdita",
                Descripcion = "Disfruta de una exposición única de arte inspirado en cerdos y su encanto."
            });

            // Evento demo 4: Carrera de Cerdos Voladores.
            eventos.Add(new Evento
            {
                Id = 4,
                Nombre = "Carrera de Cerdos Voladores",
                Fecha = DateTime.Now.AddDays(20),
                Ubicacion = "Estadio del Cerdo",
                Descripcion = "Vive la emoción de una carrera insólita, ¡con cerdos voladores en competencia!"
            });

            // Evento demo 5: Festival del Jamón.
            eventos.Add(new Evento
            {
                Id = 5,
                Nombre = "Festival del Jamón",
                Fecha = DateTime.Now.AddDays(25),
                Ubicacion = "Centro Gastronómico",
                Descripcion = "Celebra el delicioso mundo del jamón en este festival gastronómico."
            });

            // Evento demo 6: Desfile de Cerditos Elegantes.
            eventos.Add(new Evento
            {
                Id = 6,
                Nombre = "Desfile de Cerditos Elegantes",
                Fecha = DateTime.Now.AddDays(30),
                Ubicacion = "Avenida de la Moda",
                Descripcion = "Un desfile exclusivo con los cerdos más elegantes y estilizados."
            });

            // Evento demo 7: Taller de Cocina Cerdita.
            eventos.Add(new Evento
            {
                Id = 7,
                Nombre = "Taller de Cocina Cerdita",
                Fecha = DateTime.Now.AddDays(35),
                Ubicacion = "Escuela Culinaria",
                Descripcion = "Aprende a cocinar deliciosos platillos inspirados en el cerdito."
            });

            // Evento demo 8: Noche de Cuentos Cerditos.
            eventos.Add(new Evento
            {
                Id = 8,
                Nombre = "Noche de Cuentos Cerditos",
                Fecha = DateTime.Now.AddDays(40),
                Ubicacion = "Biblioteca Central",
                Descripcion = "Escucha fascinantes historias y leyendas sobre cerdos y su mística."
            });

            // Evento demo 9: Concierto de Rock Cerdito.
            eventos.Add(new Evento
            {
                Id = 9,
                Nombre = "Concierto de Rock Cerdito",
                Fecha = DateTime.Now.AddDays(45),
                Ubicacion = "Estadio Rock & Cerdo",
                Descripcion = "Disfruta de un concierto explosivo con bandas de rock y temática cerdita."
            });

            // Evento demo 10: Mercadillo del Cerdito.
            eventos.Add(new Evento
            {
                Id = 10,
                Nombre = "Mercadillo del Cerdito",
                Fecha = DateTime.Now.AddDays(50),
                Ubicacion = "Mercado Central",
                Descripcion = "Un mercadillo con productos artesanales y delicias inspiradas en cerdos."
            });

            // Evento demo 11: Concurso de Disfraces Cerditos.
            eventos.Add(new Evento
            {
                Id = 11,
                Nombre = "Concurso de Disfraces Cerditos",
                Fecha = DateTime.Now.AddDays(55),
                Ubicacion = "Plaza de la Diversión",
                Descripcion = "Compite con tu mejor disfraz inspirado en cerdos y gana increíbles premios."
            });

            // Evento demo 12: Cerdito Tech Expo.
            eventos.Add(new Evento
            {
                Id = 12,
                Nombre = "Cerdito Tech Expo",
                Fecha = DateTime.Now.AddDays(60),
                Ubicacion = "Centro de Convenciones",
                Descripcion = "Explora innovaciones tecnológicas y gadgets con un toque cerdito."
            });
        }

        /// <summary>
        /// Devuelve la lista de eventos almacenados.
        /// </summary>
        public IEnumerable<Evento> ObtenerEventos() => eventos;

        /// <summary>
        /// Agrega un nuevo evento, asignándole un ID incremental.
        /// </summary>
        public void AgregarEvento(Evento evento)
        {
            evento.Id = eventos.Any() ? eventos.Max(e => e.Id) + 1 : 1;
            eventos.Add(evento);
        }
    }
}
