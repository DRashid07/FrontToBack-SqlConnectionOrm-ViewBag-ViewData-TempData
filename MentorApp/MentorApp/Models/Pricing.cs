namespace MentorApp.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsAdvanced { get; set; }
        public List<PricingServices> PricingServices { get; set; } = new List<PricingServices>();
    }
}
