using Site_Api.enums;

namespace Site_Api.Models
{
    public class MinifiedShow
    {
        public required string Title { get; set; }
        public required string Year { get; set; }
        public string? Rated { get; set; }
        public string? Runtime { get; set; }
        public List<string>? Genre { get; set; }
        public string? Director { get; set; }
        public string? Writer { get; set; }
        public List<string>? Actors { get; set; }
        public string? Plot { get; set; }
        public string? Language { get; set; }
        public string? Country { get; set; }
        public string? Awards { get; set; }
        public Uri? Poster { get; set; }
        public int Metascore { get; set; }
        public float ImdbRating { get; set; }
        public int ImdbVotes { get; set; }
        public ShowType Type { get; set; }
        public List<Uri> Images { get; set; } = new List<Uri>();
    }
}
