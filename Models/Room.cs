namespace GrannyEly.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public List<string> Services { get; set; }
        public string ImageUrl { get; set; }
    }
}
