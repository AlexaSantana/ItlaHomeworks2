using System;

namespace Daycare.Application.Dtos
{
    public class InfanteDto : DtoBase
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public DateTime BirthDate { get; set; }
        public string GroupName { get; set; } = null!;
        public int TutorId { get; set; }
    }
}
