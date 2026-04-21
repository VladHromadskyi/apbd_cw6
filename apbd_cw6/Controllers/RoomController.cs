using apbd_cw6.Models;
using Microsoft.AspNetCore.Mvc;

namespace apbd_cw6.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RoomController : ControllerBase
{
    // 1. GET /api/rooms 
    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(DataStorage.Rooms);
    }

    // 2. GET /api/rooms/{id} 
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var room = DataStorage.Rooms.FirstOrDefault(r => r.Id == id);
        if (room == null) return NotFound(new { message = "Room not found" });
        return Ok(room);
    }

    // 3. GET /api/rooms/building/{buildingCode} 
    [HttpGet("building/{buildingCode}")]
    public IActionResult GetByBuilding(string buildingCode)
    {
        var rooms = DataStorage.Rooms
            .Where(r => r.BuildingCode.Equals(buildingCode, StringComparison.OrdinalIgnoreCase))
            .ToList();
        return Ok(rooms);
    }

    // 4. GET /api/rooms/search 
    [HttpGet("search")]
    public IActionResult SearchRooms([FromQuery] int? minCapacity, [FromQuery] bool? hasProjector, [FromQuery] bool? activeOnly)
    {
        var query = DataStorage.Rooms.AsQueryable();

        if (minCapacity.HasValue)
            query = query.Where(r => r.Capacity >= minCapacity.Value);

        if (hasProjector.HasValue)
            query = query.Where(r => r.HasProject == hasProjector.Value);

        if (activeOnly.HasValue && activeOnly.Value)
            query = query.Where(r => r.isActive);

        return Ok(query.ToList());
    }
}