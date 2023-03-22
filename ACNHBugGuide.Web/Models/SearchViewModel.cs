using ACNHBugGuide.Models;

namespace ACNHBugGuide.Web.Models;

public class SearchViewModel
{
    public string Query { get; set; }
    public List <Bug> Results { get; set; }
}