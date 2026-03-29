namespace MentorApp.Models
{
    public class PricingServices
    {
        public int PricingId { get; set; }
        public Pricing Pricing { get; set; } = null!;
        public int ServiceId { get; set; }
        public Service Service { get; set; } = null!;
    }
}
