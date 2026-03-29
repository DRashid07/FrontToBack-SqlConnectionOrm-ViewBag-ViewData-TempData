namespace MentorApp.Models
{
    public class Service
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public List<PricingServices> PricingServices { get; set; } = new List<PricingServices>();
    }
}
