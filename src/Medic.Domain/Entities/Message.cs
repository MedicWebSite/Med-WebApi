using Medic.Domain.Commons;

namespace Medic.Domain.Entities;

public class Message : Auditable
{
    public long UserId { get; set; }
    public User User { get; set; }
    
    public long DoctorId { get; set; }
    public Doctor Doctor { get; set; }

    public bool IsFromUser { get; set; }
    
    public string Text { get; set; }
}