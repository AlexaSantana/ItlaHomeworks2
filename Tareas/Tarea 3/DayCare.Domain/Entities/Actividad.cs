using System.Collections.Generic;
using Daycare.Domain.Core;

namespace Daycare.Domain.Entities
{
    public class Actividad : BaseEntity
    {
        public string Titulo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Grupo { get; set; } = null!;
        public ICollection<Mensaje> Mensajes { get; set; } = new List<Mensaje>();
    }
}
