using ACNHBugGuide.Models;

namespace ACNHBugGuide.Web.Models;

public class IndexViewModel
{
    public List<Bug> Bugs { get; set; } = new List<Bug>();
}