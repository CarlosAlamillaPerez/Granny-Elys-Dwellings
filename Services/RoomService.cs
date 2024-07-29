using GrannyEly.Models;

namespace GrannyEly.Services
{
    public class RoomService
    {
        private List<RoomModel> _rooms;

        public RoomService()
        {
            _rooms = new List<RoomModel>
        {
            new RoomModel
            {
                Id = 1,
                Status = 1,
                Name = "Depto. Azul",
                Price = "6,500",
                Deposito = "6,500",
                Address = "Villahermosa, Tabasco. Calle: Carlos Greene Colonia: Atasta #726, 86100.",
                Estancia = "6 Meses en adelante.",
                Description = "Habitación tipo Loft Petite para 1 o 2 personas, con todos los servicios incluidos. Zona no inundable, cerca de la DACS, Hospital del Niño, Hospital de la Mujer, Deportiva.",
                DescriptionCard = "Departamento para 1 o 2 personas, con todos los servicios incluidos.",
                ImagenPrincipal = "/images/habitacion1.jpg",
                Imagenes = new List<string> { "/images/habitacion1.jpg", "/images/habitacion2.jpg", "/images/habitacion3.jpg"},
                Services = new List<string> { "Agua (Fria & Caliente)", "Luz", "Internet", "Gas", "Aire Acondicionado (Minisplit)", "1 Smart TV", "Baño completo", "Cocina completa:",},
                Services_2 = new List<string> { "Estufa", "Refrijerador", "Microondas", "Cafetera", "Licuadora", "Lavatrastes", "Utencilios de cocina: (Sartenes, Vasos, Platos, Tenedores, Cucharas & Cuchillos)."},
                Restricciones = new List<string> { "No Mascotas", "No Fumadores", "No menores de edad (Niños,Niñas o Bebés)"},
            },
            new RoomModel
            {
                Id = 2,
                Status = 1,
                Name = "Depto. Con Balcon",
                Price = "9,000",
                Deposito = "9,000",
                Address = "Villahermosa, Tabasco. Calle: Carlos Greene Colonia: Atasta #726, 86100.",
                Estancia = "6 Meses en adelante.",
                Description = "Departamento para 1 o 2 personas con Hermoso Balcón! en 2do piso, con todos los servicios incluidos. Zona no inundable, cerca de la DACS, Hospital del Niño, Hospital de la Mujer, Deportiva, Plaza Cristal, etc...",
                DescriptionCard = "Departamento para 1 o 2 personas con Hermoso Balcón! con todos los servicios incluidos.",
                ImagenPrincipal = "/images/Balcon1.jpg",
                Imagenes = new List<string>
                {
                    "/images/Balcon1.jpg",
                    "/images/Balcon2.jpg",
                    "/images/Balcon3.jpg",
                    "/images/Balcon4.jpg",
                    "/images/Balcon5.jpg",
                    "/images/Balcon6.jpg",
                    "/images/Balcon7.jpg",
                    "/images/Balcon8.jpg",
                    "/images/Balcon9.jpg",
                    "/images/Balcon10.jpg",
                    "/images/Balcon11.jpg",
                    "/images/Balcon12.jpg",
                    "/images/Balcon13.jpg",
                    "/images/Balcon14.jpg",
                    "/images/Balcon15.jpg",
                    "/images/Balcon16.jpg",
                    "/images/Balcon17.jpg"
                },
                Services = new List<string>
                {
                    "Agua (Fria & Caliente)",
                    "Luz",
                    "Internet",
                    "Gas",
                    "Entrada independiente",
                    "Cama Queen",
                    "Sala (2 piezas)",
                    "Mesita de centro",
                    "Mesa Comedor",
                    "2 Aires Acondicionados (Minisplit)",
                    "1 Smart TV",
                    "2 Espejos de cuarto",
                    "Buró grande para ropa",
                    "Burós de cama",
                    "Terraza",
                    "Área de lavado & secado",
                    "Lavadora",
                    "Boiler",
                    "Baño completo",
                    "Cajón de estacionamiento",
                    "Cocina completa:",
                },
                Services_2 = new List<string>
                {
                    "Estufa",
                    "Refrijerador",
                    "Microondas",
                    "Licuadora",
                    "Lavatrastes",
                    "Utencilios de cocina: (Sartenes, vasos, platos, tenedores, cucharas, cuchillos, etc...)."
                },
                Restricciones = new List<string>
                {
                    "No Mascotas",
                    "No Fumadores"
                },
            },
            new RoomModel
            {
                Id = 3,
                Status = 1,
                Name = "Depto. Loft Petit",
                Price = "6,500",
                Deposito = "6,500",
                Address = "Villahermosa, Tabasco. Calle: Carlos Greene Colonia: Infonavit Atasta #229, 86130.",
                Estancia = "6 Meses en adelante.",
                Description = "Departamento para 1 o 2 personas tipo 'Loft' planta baja, con todos los servicios incluidos. Zona no inundable, cerca de la DACS, Hospital del Niño, Hospital de la Mujer, Deportiva, Plaza Cristal, etc...",
                DescriptionCard = "Departamento para 1 o 2 personas tipo 'Loft' planta baja, con todos los servicios incluidos.",
                ImagenPrincipal = "/images/Loft1.jpg",
                Imagenes = new List<string>
                {
                    "/images/Loft1.jpg",
                    "/images/Loft2.jpg",
                    "/images/Loft3.jpg",
                    "/images/Loft4.jpg",
                    "/images/Loft5.jpg",
                    "/images/Loft6.jpg",
                    "/images/Loft7.jpg",
                    "/images/Loft8.jpg",
                    "/images/Loft9.jpg",
                    "/images/Loft10.jpg",
                    "/images/Loft11.jpg",
                    "/images/Loft12.jpg",
                    "/images/Loft13.jpg",
                    "/images/Loft14.jpg",
                },
                Services = new List<string>
                {
                    "Agua (Fria & Caliente)",
                    "Luz",
                    "Internet",
                    "Entrada independiente",
                    "Cama matrimonial",
                    "Burós de cama & lámparas",
                    "Clóset grande con divisiones & ganchos",
                    "Mesa comedor / Esritorio",
                    "1 Espejo de Pared & 1 espejo pequeño",
                    "1 Aire Acondicionado (Minisplit)",
                    "1 Smart TV 32' ",
                    "Boiler",
                    "Baño completo",
                    "Área de lavado & secado",
                    "Lavadora",
                    "Cajón de estacionamiento (A tratar)",
                    "Cocina completa:",
                },
                Services_2 = new List<string>
                {
                    "Estufa",
                    "Refrijerador",
                    "Microondas",
                    "Licuadora",
                    "Cafetera",
                    "Lavatrastes",
                    "Utencilios de cocina: (Sartenes, vasos, platos, tenedores, cucharas, cuchillos, etc...)."
                },
                Restricciones = new List<string>
                {
                    "No Mascotas",
                    "No Fumadores"
                },
            },
                new RoomModel
            {
                Id = 4,
                Status = 1,
                Name = "La Casita",
                Price = "7,000",
                Deposito = "7,000",
                Address = "Villahermosa, Tabasco. Calle: Carlos Greene Colonia: Infonavit Atasta #726, 86100.",
                Estancia = "6 Meses en adelante.",
                Description = "Casita para 1 o 2 personas de 2 pisos con 1 habitación & una terraza pequeña, con todos los servicios incluidos. Zona no inundable, cerca de la DACS, Hospital del Niño, Hospital de la Mujer, Deportiva, Plaza Cristal, etc...",
                DescriptionCard = "Departamento para 1 o 2 personas de 2 pisos con 1 habitación & una terraza pequeña, con todos los servicios incluidos.",
                ImagenPrincipal = "/images/Casita1.jpg",
                Imagenes = new List<string>
                {
                    "/images/Casita1.jpg",
                    "/images/Casita2.jpg",
                    "/images/Casita3.jpg",
                    "/images/Casita4.jpg",
                    "/images/Casita5.jpg",
                    "/images/Casita6.jpg",
                    "/images/Casita7.jpg",
                    "/images/Casita8.jpg",
                    "/images/Casita9.jpg",
                    "/images/Casita10.jpg",
                },
                Services = new List<string>
                {
                    "Agua (Fria & Caliente)",
                    "Internet",
                    "Gas",
                    "Entrada independiente",
                    "Sala (2 piezas)",
                    "Mesita de centro",
                    "Ventilador de techo con lámpara",
                    "Barra comedor",
                    "1 Aire Acondicionado (Minisplit) ",
                    "1 TV 32' (En sala)",
                    "Baño completo",
                    "Cocina completa:",
                },
                Services_2 = new List<string>
                {
                    "Estufa",
                    "Refrijerador",
                    "Microondas",
                    "Licuadora",
                    "Cafetera",
                    "Dispensador de agua",
                    "Lavatrastes",
                    "Utencilios de cocina: (Sartenes, vasos, platos, tenedores, cucharas, cuchillos, etc...)."
                },
                Services_3 = new List<string>
                {
                    "Cama matrimonial",
                    "1 Aire Acondicionado (Minisplit) ",
                    "1 Smart TV 32' (Habitación)",
                    "1 Espejo de Pared",
                    "Buró mediano para ropa",
                    "Clóset grande de puertas con divisiones & ganchos",
                    "Boiler",
                    "Terraza",
                    "Área de lavado & secado",
                    "Lavadora",
                },
                Restricciones = new List<string>
                {
                    "No Mascotas",
                    "No Fumadores",
                },
            },
            new RoomModel
            {
                Id = 5,
                Status = 2,
                Name = "La Casita",
                Price = "7,000",
                Deposito = "7,000",
                Address = "Villahermosa, Tabasco. Calle: Carlos Greene Colonia: Infonavit Atasta #726, 86100.",
                Estancia = "6 Meses en adelante.",
                Description = "Casita para 1 o 2 personas de 2 pisos con 1 habitación & una terraza pequeña, con todos los servicios incluidos. Zona no inundable, cerca de la DACS, Hospital del Niño, Hospital de la Mujer, Deportiva, Plaza Cristal, etc...",
                DescriptionCard = "Departamento para 1 o 2 personas de 2 pisos con 1 habitación & una terraza pequeña, con todos los servicios incluidos.",
                ImagenPrincipal = "/images/Casita1.jpg",
                Imagenes = new List<string>
                {
                    "/images/Casita1.jpg",
                    "/images/Casita2.jpg",
                    "/images/Casita3.jpg",
                    "/images/Casita4.jpg",
                    "/images/Casita5.jpg",
                    "/images/Casita6.jpg",
                    "/images/Casita7.jpg",
                    "/images/Casita8.jpg",
                    "/images/Casita9.jpg",
                    "/images/Casita10.jpg",
                },
                Services = new List<string>
                {
                    "Agua (Fria & Caliente)",
                    "Internet",
                    "Gas",
                    "Entrada independiente",
                    "Cama matrimonial",
                    "Sala (2 piezas)",
                    "Mesita de centro",
                    "Ventilador de techo con lámpara",
                    "Barra comedor",
                    "2 Aires Acondicionados (Minisplits) ",
                    "1 TV 32' (En sala) & 1 Smart TV 32' (Habitación) ",
                    "1 Espejo de Pared",
                    "Buró mediano para ropa",
                    "Clóset grande de puertas con divisiones & ganchos",
                    "Boiler",
                    "Terraza",
                    "Área de lavado & secado",
                    "Lavadora",
                    "Baño completo",
                    "Cocina completa:",
                },
                Services_2 = new List<string>
                {
                    "Estufa",
                    "Refrijerador",
                    "Microondas",
                    "Licuadora",
                    "Cafetera",
                    "Dispensador de agua",
                    "Lavatrastes",
                    "Utencilios de cocina: (Sartenes, vasos, platos, tenedores, cucharas, cuchillos, etc...)."
                },
                Services_3 = new List<string>
                {
                    "Estufa",
                    "Refrijerador",
                    "Microondas",
                    "Licuadora",
                    "Cafetera",
                    "Dispensador de agua",
                    "Lavatrastes",
                    "Utencilios de cocina: (Sartenes, vasos, platos, tenedores, cucharas, cuchillos, etc...)."
                },
                Restricciones = new List<string>
                {
                    "No Mascotas",
                    "No Fumadores"
                },
            },
            // Añade más habitaciones aquí
        };
        }

        public List<RoomModel> GetAllRooms()
        {
            return _rooms;
        }

        public RoomModel GetRoom(int id)
        {
            return _rooms.FirstOrDefault(r => r.Id == id);
        }
    }
}
