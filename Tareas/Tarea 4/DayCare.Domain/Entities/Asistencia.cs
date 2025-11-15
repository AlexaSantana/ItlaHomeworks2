using Daycare.Domain.Core;

namespace Daycare.Domain.Entities
{
    public class Asistencia : BaseEntity
    {
        public DateTime Fecha { get; set; }
        public bool Presente { get; set; }

        public int InfanteId { get; set; }
        public Infante? Infante { get; set; }
    }
}
