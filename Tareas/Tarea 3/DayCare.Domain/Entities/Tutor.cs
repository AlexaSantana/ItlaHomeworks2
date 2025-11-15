using System.Collections.Generic;
using Daycare.Domain.Core;

namespace Daycare.Domain.Entities
{
    public class Tutor : Person
    {
        public string Relation { get; set; } = null!;
        public ICollection<Infante> Infantes { get; set; } = new List<Infante>();
        public ICollection<Mensaje> Mensajes { get; set; } = new List<Mensaje>();
    }
}
