namespace MentorApp.Models
{
    public class Slider
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Desc { get; set; } = null!;
        public string ButtonLink { get; set; } = null!;
    }
}
