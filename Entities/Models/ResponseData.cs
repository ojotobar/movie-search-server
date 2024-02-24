using Newtonsoft.Json;

namespace Entities.Models
{
    public class ResponseData
    {
        [JsonProperty("Search")]
        public List<MovieData>? Search { get; set; }
        [JsonProperty("Response")]
        public string? Response { get; set; }
    }
}
