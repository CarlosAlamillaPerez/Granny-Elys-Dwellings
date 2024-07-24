using GrannyEly.Models;

namespace GrannyEly.Services
{
    public class RoomService
    {
        private List<Room> _rooms;

        public RoomService()
        {
            // Inicializa con datos de ejemplo
            _rooms = new List<Room>
        {
            new Room
            {
                Id = 1,
                Name = "Habitación Deluxe",
                Price = 100.00m,
                Description = "Habitación espaciosa con vista al mar",
                Address = "Calle Principal 123",
                Services = new List<string> { "WiFi", "TV", "Aire acondicionado" },
                ImageUrl = "/images/room1.jpg"
            },
            // Añade más habitaciones aquí
        };
        }

        public List<Room> GetAllRooms()
        {
            return _rooms;
        }

        public Room GetRoom(int id)
        {
            return _rooms.FirstOrDefault(r => r.Id == id);
        }
    }
}
