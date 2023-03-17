using System.Text.Json;
using ACNHBugGuide.Models;

namespace ACNHBugGuide.Web.Services;

public class BugService
{
    public async Task<List<Bug>> GetAll()
    {
        using var client = new HttpClient();
        var result = await client.GetAsync("https://www.acnhapi.com/v1/bugs");
        if (result.IsSuccessStatusCode)
        {
            var json = await result.Content.ReadAsStringAsync();

            var dictionary = JsonSerializer.Deserialize<Dictionary<string, Bug>>(json);
            return dictionary.Values.ToList();
        }

        return new List<Bug>();
    }
}