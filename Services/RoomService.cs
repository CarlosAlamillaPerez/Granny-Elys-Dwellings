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
                Name = "Departamento Azul",
                Price = "6,500",
                Address = "Calle: Carlos Greene Colonia: Infonavit Atasta #729, 86100",
                Services = new List<string> { "Agua (Fria & Caliente)", "Luz", "Internet", "Gas", "Aire Acondicionado (Minisplit)", "1 Smart TV", "Baño completo", "Cocina completa:",},
                ImagenPrincipal = "/images/habitacion1.jpg",
                Imagenes = new List<string> { "/images/habitacion1.jpg", "/images/habitacion2.jpg", "/images/habitacion3.jpg"},
                Description = "Habitación tipo Loft Petite para 1 o 2 personas, con todos los servicios incluidos.",
                Description_2 = new List<string> { "Estufa", "Refrijerador", "Microondas", "Cafetera", "Licuadora", "Lavatrastes", "Utencilios de cocina: (Sartenes, Vasos, Platos, Tenedores, Cucharas & Cuchillos)."},
                DescriptionCard = "Departamento para 1 o 2 personas, con todos los servicios incluidos.",
                Restricciones = new List<string> { "No Mascotas", "No Fumadores", "No menores de edad (Niños,Niñas o Bebés)"},
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
