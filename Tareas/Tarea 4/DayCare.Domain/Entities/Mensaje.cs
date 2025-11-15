using System.Collections.Generic;
using Daycare.Domain.Core;

namespace Daycare.Domain.Entities
{
    public class Mensaje : BaseEntity
    {
        public string Titulo { get; set; } = null!;
        public string Contenido { get; set; } = null!;
        public DateTime FechaEnvio { get; set; } = DateTime.UtcNow;

        public int InfanteId { get; set; }
        public Infante? Infante { get; set; }

        public int TutorId { get; set; }
        public Tutor? Tutor { get; set; }

        public int? ActividadId { get; set; }
        public Actividad? Actividad { get; set; }
    }
}
