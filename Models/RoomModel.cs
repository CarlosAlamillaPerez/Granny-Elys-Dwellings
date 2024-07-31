namespace GrannyEly.Models
{
    public class RoomModel
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public string? Deposito { get; set; }
        public string Address { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Estancia { get; set; } = string.Empty;
        public List<string> Imagenes { get; set; } = new List<string>();
        public string ImagenPrincipal { get; set; } = string.Empty;
        public List<string> Services { get; set; } = new List<string>();
        public List<string> Services_2 { get; set; } = new List<string>();
        public List<string>? Services_3 { get; set; }
        public List<string>? Services_4 { get; set; }
        public List<string>? Services_5 { get; set; }
        public List<string>? Services_extra { get; set; }
        public string DescriptionCard { get; set; } = string.Empty;
        public List<string>? Restricciones { get; set; }
    }
}
