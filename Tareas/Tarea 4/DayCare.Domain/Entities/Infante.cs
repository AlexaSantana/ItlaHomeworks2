using System.Collections.Generic;
using Daycare.Domain.Core;

namespace Daycare.Domain.Entities
{
    public class Infante : Person
    {
        public DateTime BirthDate { get; set; }
        public string GroupName { get; set; } = null!;
        public int TutorId { get; set; }
        public Tutor? Tutor { get; set; }
        public ICollection<Asistencia> Asistencias { get; set; } = new List<Asistencia>();
        public ICollection<Mensaje> Mensajes { get; set; } = new List<Mensaje>();
    }
}
