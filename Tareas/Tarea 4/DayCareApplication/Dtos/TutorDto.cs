namespace Daycare.Application.Dtos
{
    public class TutorDto : DtoBase
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Relation { get; set; } = null!; // Madre, Padre, etc.
    }
}
