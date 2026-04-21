using System.ComponentModel.DataAnnotations;

namespace apbd_cw6.Models;

public class Room
{
    public int Id { set; get; }
    
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; } = string.Empty;
    
    [Required(ErrorMessage = "Building code is required")]
    public string BuildingCode { get; set; } = string.Empty;
    
    public int Floor { get; set; }
    
    [Range(1, int.MaxValue, ErrorMessage = "Capacity must be greater than 0")]
    public int Capacity { get; set; }
    
    public bool HasProject { get; set; }
    public bool isActive { get; set; }
}