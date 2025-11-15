using Daycare.Domain.Entities;
using Daycare.Infrastructure.Context;
using Daycare.Infrastructure.Core;
using Daycare.Infrastructure.Interfaces;

namespace Daycare.Infrastructure.Repositories
{
    public class AsistenciaRepository 
        : BaseRepository<Asistencia>, IAsistenciaRepository
    {
        public AsistenciaRepository(DayCareContext context)
            : base(context)
        {
        }
    }
}
