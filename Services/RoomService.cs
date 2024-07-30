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
                Price = "$7,500",
                Deposito = "$7,500",
                Address = "Villahermosa, Tabasco. Calle: Carlos Greene Colonia: Infonavit Atasta #726, 86100.",
                Estancia = "6 Meses en adelante.",
                Description = "Departamento tipo 'Loft' planta baja, con todos los servicios incluidos. Zona no inundable, cerca de la DACS, Hospital del Niño, Hospital de la Mujer, Deportiva, Plaza Cristal, etc...",
                DescriptionCard = "Departamento para 1 o 2 personas tipo 'Loft' planta baja, con todos los servicios incluidos.",
                ImagenPrincipal = "/images/DepaAzul1.jpg",
                Imagenes = new List<string>
                {
                    "/images/DepaAzul1.jpg",
                    "/images/DepaAzul2.jpg",
                    "/images/DepaAzul3.jpg",
                    "/images/DepaAzul4.jpg",
                    "/images/DepaAzul5.jpg",
                    "/images/DepaAzul6.jpg",
                    "/images/DepaAzul7.jpg",
                    "/images/DepaAzul8.jpg",
                    "/images/DepaAzul9.jpg",
                    "/images/DepaAzul10.jpg",
                    "/images/DepaAzul11.jpg",
                    "/images/DepaAzul12.jpg",
                    "/images/DepaAzul13.jpg",
                },
                Services = new List<string>
                {
                    "Agua (Fria & Caliente)",
                    "Internet",
                    "Gas",
                    "Entrada independiente",
                    "Cama Queen Size",
                    "Sala (2 piezas)",
                    //"Mesita de centro",
                    "Barra comedor",
                    "2 Ventiladores de techo",
                    "1 Aire acondicionado (Minisplit) ",
                    "1 Smart TV 32'",
                    "1 Espejo de Pared",
                    "1 Plancha de ropa",
                    "1 Burro de planchar",
                    "2 Burós de cama",
                    "1 Buró mediano para ropa",
                    "Clóset mediano de puertas con divisiones & ganchos",
                    "Boiler",
                    //"Área de lavado & secado",
                    //"Lavadora",
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
                Restricciones = new List<string>
                {
                    "No Mascotas",
                    "No Fumadores"
                },
            },

            new RoomModel
            {
                Id = 2,
                Status = 1,
                Name = "Depto. Con Balcon",
                Price = "$9,000",
                Deposito = "$9,000",
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
                    "Cama Queen Size",
                    "Juego Sala (2 piezas)",
                    "Mesita de centro",
                    "Mesa Comedor",
                    "2 Aires acondicionados (Minisplit)",
                    "1 Smart TV 32'",
                    "2 Espejos de pared",
                    "1 Plancha de ropa",
                    "1 Burro de planchar",
                    "2 Burós de cama",
                    "1 Buró grande para ropa",
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
                Price = "$6,500",
                Deposito = "$6,500",
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
                    "Clóset grande con divisiones & ganchos",
                    "Mesa comedor / Esritorio",
                    "2 Burós de cama & 2 lámparas de mesa",
                    "1 Espejo de Pared & 1 espejo pequeño",
                    "1 Aire acondicionado (Minisplit)",
                    "1 Smart TV 32' ",
                    "1 Plancha de ropa",
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
                Price = "$7,000",
                Deposito = "$7,000",
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
                    "Juego Sala (2 piezas)",
                    "Mesita de centro",
                    "Barra comedor",
                    "1 Ventilador de techo con lámpara",
                    "1 Aire acondicionado (Minisplit) ",
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
                    "1 Aire acondicionado (Minisplit) ",
                    "1 Smart TV 32' (Habitación)",
                    "1 Espejo de Pared",
                    "1 Buró mediano para ropa",
                    "1 Plancha de ropa",
                    "1 Burro de planchar",
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
                Name = "Hermosa Casa Del Caribe",
                Price = "Desde $1,800",
                Deposito = "0",
                Address = "Playa Del Carmen, Quintana Roo. Fraccionamiento privida 'Olivos 2', Paseo San Pedro, Sobre Av. Solidaridad. C.P: 77724",
                Estancia = "3 días en adelante.",
                Description = "🏄‍♂️ ¡Casa Vacacional! 🏊‍♂ hasta para 10 personas a 5 mins de centros comerciales, 12 mins de playas 🌊 & la famosa 5ta. avenida 🍹. Consta de 3 recámaras (1 en planta baja, 2 en planta alta), con todos los servicios incluidos.",
                DescriptionCard = "🏄‍♂️ ¡Casa Vacacional! 🏊‍♂ hasta para 10 personas a 5 mins de centros comerciales, 12 mins de playas 🌊 & la famosa 5ta. avenida 🍹",
                ImagenPrincipal = "/images/Caribe1.jpg",
                Imagenes = new List<string>
                {
                    "/images/Caribe100.jpg",
                    "/images/Caribe101.jpg",
                    "/images/Caribe1.jpg",
                    "/images/Caribe2.jpg",
                    "/images/Caribe3.jpg",
                    "/images/Caribe4.jpg",
                    "/images/Caribe5.jpg",
                    "/images/Caribe6.jpg",
                    "/images/Caribe7.jpg",
                    "/images/Caribe15.jpg",
                    "/images/Caribe16.jpg",
                    "/images/Caribe51.jpg",
                    "/images/Caribe56.jpg",
                    "/images/Caribe38.jpg",
                    "/images/Caribe8.jpg",
                    "/images/Caribe9.jpg",
                    "/images/Caribe67.jpg",
                    "/images/Caribe10.jpg",
                    "/images/Caribe11.jpg",
                    "/images/Caribe12.jpg",
                    "/images/Caribe13.jpg",
                    "/images/Caribe14.jpg",
                    "/images/Caribe59.jpg",
                    "/images/Caribe60.jpg",
                    "/images/Caribe61.jpg",
                    "/images/Caribe62.jpg",
                    "/images/Caribe63.jpg",
                    "/images/Caribe19.jpg",
                    "/images/Caribe69.jpg",
                    "/images/Caribe70.jpg",
                    "/images/Caribe71.jpg",
                    "/images/Caribe72.jpg",
                    "/images/Caribe44.jpg",
                    "/images/Caribe42.jpg",
                    "/images/Caribe20.jpg",
                    "/images/Caribe21.jpg",
                    "/images/Caribe22.jpg",
                    "/images/Caribe23.jpg",
                    "/images/Caribe24.jpg",
                    "/images/Caribe25.jpg",
                    "/images/Caribe26.jpg",
                    "/images/Caribe27.jpg",
                    "/images/Caribe28.jpg",
                    "/images/Caribe29.jpg",
                    "/images/Caribe30.jpg",
                    "/images/Caribe45.jpg",
                    "/images/Caribe31.jpg",
                    "/images/Caribe32.jpg",
                    "/images/Caribe33.jpg",
                    "/images/Caribe34.jpg",
                    "/images/Caribe35.jpg",
                    "/images/Caribe36.jpg",
                    "/images/Caribe110.jpg",
                    "/images/Caribe96.jpg",
                    "/images/Caribe97.jpg",
                    "/images/Caribe98.jpg",
                    "/images/Caribe99.jpg",
                    "/images/Caribe120.jpg",
                    "/images/Caribe121.jpg",
                    "/images/Caribe122.jpg",
                    "/images/Caribe123.jpg",
                    "/images/Caribe130.jpg",

                },
                Services = new List<string>
                {
                    "Agua (Fria & Caliente)",
                    "Luz",
                    "Internet",
                    "Gas",
                    "Entrada independiente",
                    "Sala (2 piezas)",
                    "Mesita de centro",
                    "Mesa comedor",
                    "1 Aire acondicionado en sala (Minisplit)",
                    "1 Smart TV",
                    "Boiler",
                    "Patio",
                    "Área de lavado & secado",
                    "Lavadora",
                    "1 Baño completo",
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
                    "Cama Queen Size",
                    "1 Aire acondicionado (Minisplit)",
                    "2 Búrós de cama",
                    "2 lámparas de mesa",
                    "Closet muy grande de puertas & divisiones",
                    "Baño completo (en sala)",
                },
                Services_4 = new List<string>
                {
                    "2 Camas individual/matrimonial en litera",
                    "1 Buró pequeño",
                    "1 espejo de pared",
                    "Closet grande & divisiones",
                    "Espejo grande en closet",
                    "Baño completo (propio)",
                },
                Services_5 = new List<string>
                {
                    "Cama King Size (Habitación Principal).",
                    "2 Búrós de cama",
                    "2 lámparas de mesa",
                    "Closet muy grande de puertas & divisiones",
                    "Baño completo (propio)",
                },
                Services_extra = new List<string>
                {
                    "Plancha de ropa",
                    "Burro de planchar",
                    "Sofá cama",
                    "Smart TV 32'",
                    "Espejo de pared circular",
                },
                Restricciones = new List<string>
                {
                    "No Mascotas",
                    "No Fumadores"
                },
            },
            new RoomModel
            {
                Id = 6,
                Status = 1,
                Name = "Las Bugambilias",
                Price = "$12,000",
                Deposito = "$12,000",
                Address = "Villahermosa, Tabasco. Fraccionamiento privada 'Bugambilias' Colonia: Atasta",
                Estancia = "1 año en adelante.",
                Description = "Casa grande en privada bugambilias con 3 habitaciones. Zona no inundable, cerca de la DACS, Hospital del Niño, Hospital de la Mujer, Deportiva, Plaza Cristal, etc...",
                DescriptionCard = "Casa grande en privada bugambilias con 3 habitaciones, sin servicios incluidos.",
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
                    "Recibidor",
                    "Área de Sala",
                    "Pátio de lavado",
                    "Pasillo de servicios/Garage",
                    "Cochera para 3 vehículos (sin techar)",
                    "Boiler",
                    "1/2 Baño",
                    "1 Aire acondicionado en sala (Minisplit) ",
                    "Cocina grande:",
                },
                Services_2 = new List<string>
                {
                    "Estufa",
                    "Refrijerador",
                    "Lavatrastes",
                    "Alacena grande con divisiones",
                    "Dispensador de agua",
                    //"Microondas",
                    //"Licuadora",
                    //"Cafetera",
                    //"Utencilios de cocina: (Sartenes, vasos, platos, tenedores, cucharas, cuchillos, etc...)."
                },
                Services_3 = new List<string>
                {
                    "Baño completo",
                    "1 Aire acondicionado (Minisplit) ",
                    "Clóset grande de puertas con divisiones & ganchos",
                    "Espejo de closet grande",
                },
                Services_4 = new List<string>
                {
                    "Baño compartido",
                    "1 Aire acondicionado (Minisplit) ",
                    "Clóset grande de puertas con divisiones & ganchos",
                },
                Services_5 = new List<string>
                {
                    "Baño compartido",
                    "1 Aire acondicionado (Minisplit) ",
                    "Clóset grande de puertas con divisiones & ganchos",
                },
                //Restricciones = new List<string>
                //{
                //    "No Mascotas",
                //    "No Fumadores",
                //},
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
