using Daycare.Domain.Entities;
using Daycare.Infrastructure.Context;
using Daycare.Infrastructure.Core;
using Daycare.Infrastructure.Interfaces;

namespace Daycare.Infrastructure.Repositories
{
    public class ActividadRepository
        : BaseRepository<Actividad>, IActividadRepository
    {
        public ActividadRepository(DayCareContext context)
            : base(context)
        {
        }
    }
}
