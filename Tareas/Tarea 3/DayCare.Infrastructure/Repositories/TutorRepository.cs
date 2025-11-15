using Daycare.Domain.Entities;
using Daycare.Infrastructure.Context;
using Daycare.Infrastructure.Core;
using Daycare.Infrastructure.Interfaces;

namespace Daycare.Infrastructure.Repositories
{
    public class TutorRepository
        : BaseRepository<Tutor>, ITutorRepository
    {
        public TutorRepository(DayCareContext context)
            : base(context)
        {
        }
    }
}
