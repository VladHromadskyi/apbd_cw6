using System.ComponentModel.DataAnnotations;

namespace apbd_cw6.Models;

public class Reservation
{
    public int Id { get; set; }
    
    [Required]
    public int RoomId { get; set; }

    [Required(ErrorMessage = "Organizer name is required")]
    public string OrganizerName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Topic is required")]
    public string Topic { get; set; } = string.Empty;

    public DateOnly Date { get; set; }
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }

    public string Status { get; set; } = "planned"; // planned, confirmed, cancelled
}