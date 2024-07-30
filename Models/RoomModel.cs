namespace GrannyEly.Models
{
    public class RoomModel
    {
        public int Id { get; set; }
        public int Status { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string? Deposito { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Estancia { get; set; }
        public List<string> Imagenes { get; set; }
        public string ImagenPrincipal { get; set; }
        public List<string> Services { get; set; }
        public List<string> Services_2 { get; set; }
        public List<string>? Services_3 { get; set; }
        public List<string>? Services_4 { get; set; }
        public List<string>? Services_5 { get; set; }
        public List<string>? Services_extra { get; set; }
        public string DescriptionCard { get; set; }
        public List<string>? Restricciones { get; set; }
    }
}
