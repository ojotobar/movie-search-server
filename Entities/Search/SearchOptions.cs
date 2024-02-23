namespace Entities.Search
{
    public class SearchOptions
    {
        public string Title { get; set; } = string.Empty;
        public bool IsValid => 
            !string.IsNullOrWhiteSpace(Title);
    }
}
