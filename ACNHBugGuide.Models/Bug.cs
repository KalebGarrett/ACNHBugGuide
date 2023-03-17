using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ACNHBugGuide.Models;

public class Bug
{
    [JsonPropertyName("id")] public int Id { get; set; }

    [JsonPropertyName("file-name")] public string FileName { get; set; }

    [JsonPropertyName("name")] public Name Name { get; set; }

    [JsonPropertyName("availability")] public Availability Availability { get; set; }

    [JsonPropertyName("price")] public int Price { get; set; }

    [JsonPropertyName("price-flick")] public int PriceFlick { get; set; }

    [JsonPropertyName("catch-phrase")] public string CatchPhrase { get; set; }

    [JsonPropertyName("museum-phrase")] public string MuseumPhrase { get; set; }

    [JsonPropertyName("image_uri")] public string ImageUri { get; set; }

    [JsonPropertyName("icon_uri")] public string IconUri { get; set; }
}

public class Availability
{
    [JsonPropertyName("month-northern")] public string MonthNorthern { get; set; }

    [JsonPropertyName("month-southern")] public string MonthSouthern { get; set; }

    [JsonPropertyName("time")] public string Time { get; set; }

    [JsonPropertyName("isAllDay")] public bool IsAllDay { get; set; }

    [JsonPropertyName("isAllYear")] public bool IsAllYear { get; set; }

    [JsonPropertyName("location")] public string Location { get; set; }

    [JsonPropertyName("rarity")] public string Rarity { get; set; }

    [JsonPropertyName("month-array-northern")]
    public List<int> MonthArrayNorthern { get; set; }

    [JsonPropertyName("month-array-southern")]
    public List<int> MonthArraySouthern { get; set; }

    [JsonPropertyName("time-array")] public List<int> TimeArray { get; set; }
}

public class Name
{
    [JsonPropertyName("name-USen")] public string NameUSen { get; set; }

    [JsonPropertyName("name-EUen")] public string NameEUen { get; set; }

    [JsonPropertyName("name-EUde")] public string NameEUde { get; set; }

    [JsonPropertyName("name-EUes")] public string NameEUes { get; set; }

    [JsonPropertyName("name-USes")] public string NameUSes { get; set; }

    [JsonPropertyName("name-EUfr")] public string NameEUfr { get; set; }

    [JsonPropertyName("name-USfr")] public string NameUSfr { get; set; }

    [JsonPropertyName("name-EUit")] public string NameEUit { get; set; }

    [JsonPropertyName("name-EUnl")] public string NameEUnl { get; set; }

    [JsonPropertyName("name-CNzh")] public string NameCNzh { get; set; }

    [JsonPropertyName("name-TWzh")] public string NameTWzh { get; set; }

    [JsonPropertyName("name-JPja")] public string NameJPja { get; set; }

    [JsonPropertyName("name-KRko")] public string NameKRko { get; set; }

    [JsonPropertyName("name-EUru")] public string NameEUru { get; set; }
}