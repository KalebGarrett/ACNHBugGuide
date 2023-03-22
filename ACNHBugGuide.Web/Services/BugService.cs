using System.Text.Json;
using ACNHBugGuide.Models;

namespace ACNHBugGuide.Web.Services;

public class BugService
{
    public List<Bug> Bugs { get; set; } = null;
    public async Task<List<Bug>> GetAll()
    {
        if (Bugs != null)
        {
            return Bugs;
        }
        using var client = new HttpClient();
        var result = await client.GetAsync("https://www.acnhapi.com/v1/bugs");
        if (result.IsSuccessStatusCode)
        {
            var json = await result.Content.ReadAsStringAsync();

            var dictionary = JsonSerializer.Deserialize<Dictionary<string, Bug>>(json);
            Bugs = dictionary.Values.ToList();
            return Bugs;
        }

        return new List<Bug>();
    }

    public async Task<Bug> Get(string fileName)
    {
        if (Bugs == null)
        {
            await GetAll();
        }
        
        var bug = Bugs?.FirstOrDefault(x => x.FileName == fileName.ToLower());
        return bug;
    }
    
}