using Daycare.Domain.Entities;
using Daycare.Infrastructure.Context;
using Daycare.Infrastructure.Core;
using Daycare.Infrastructure.Interfaces;

namespace Daycare.Infrastructure.Repositories
{
    public class InfanteRepository
        : BaseRepository<Infante>, IInfanteRepository
    {
        public InfanteRepository(DayCareContext context)
            : base(context)
        {
        }
    }
}
