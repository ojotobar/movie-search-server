using Newtonsoft.Json;

namespace Entities.Models
{
    public class MovieData
    {
        [JsonProperty("Title")]
        public string? Title { get; set; }
        [JsonProperty("Year")]
        public string? Year { get; set; }
        [JsonProperty("imdbID")]
        public string? ImDbId { get; set; }
        [JsonProperty("Poster")]
        public string? Poster { get; set; }
        [JsonProperty("Type")]
        public string? Type { get; set; }
    }
}
