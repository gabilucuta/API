namespace Internship2022WebAPI.Data
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public int[] Ratings { get; set; }
        public DateTime currentDateTime { get; set; } = DateTime.UtcNow;
        
    }
}
