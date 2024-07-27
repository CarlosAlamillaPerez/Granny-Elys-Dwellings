namespace GrannyEly.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Address { get; set; }
        public List<string> Services { get; set; }
        public List<string> Imagenes { get; set; }
        public string ImagenPrincipal { get; set; }
        public string Description { get; set; }
        public List<string> Description_2 { get; set; }
        public string DescriptionCard { get; set; }
        public List<string> Restricciones { get; set; }
    }
}
