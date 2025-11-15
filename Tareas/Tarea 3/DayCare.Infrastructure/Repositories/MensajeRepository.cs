using Daycare.Domain.Entities;
using Daycare.Infrastructure.Context;
using Daycare.Infrastructure.Core;
using Daycare.Infrastructure.Interfaces;

namespace Daycare.Infrastructure.Repositories
{
    public class MensajeRepository
        : BaseRepository<Mensaje>, IMensajeRepository
    {
        public MensajeRepository(DayCareContext context)
            : base(context)
        {
        }
    }
}
