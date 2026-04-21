namespace apbd_cw6.Models;

public static class DataStorage
{
    public static List<Room> Rooms = new()
    {
        new Room { Id = 1, Name = "Alpha", BuildingCode = "A", Floor = 1, Capacity = 10, HasProject = true, isActive = true },
        new Room { Id = 2, Name = "Beta", BuildingCode = "A", Floor = 2, Capacity = 30, HasProject = true, isActive = true },
        new Room { Id = 3, Name = "Gamma", BuildingCode = "B", Floor = 1, Capacity = 15, HasProject = false, isActive = true },
        new Room { Id = 4, Name = "Delta", BuildingCode = "C", Floor = 3, Capacity = 50, HasProject = true, isActive = false }
    };

    public static List<Reservation> Reservations = new()
    {
        new Reservation { Id = 1, RoomId = 1, OrganizerName = "Ivan Ivanov", Topic = "C# Basics", Date = new DateOnly(2026, 5, 10), StartTime = new TimeOnly(10, 0), EndTime = new TimeOnly(12, 0), Status = "confirmed" }
    };
}