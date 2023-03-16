namespace ACNHBugGuide.Models;

public class Bugs
{
    
}

// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class AgriasButterfly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Ant
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class AtlasMoth
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Availability
    {
        [JsonPropertyName("month-northern")]
        public string MonthNorthern { get; set; }

        [JsonPropertyName("month-southern")]
        public string MonthSouthern { get; set; }

        [JsonPropertyName("time")]
        public string Time { get; set; }

        [JsonPropertyName("isAllDay")]
        public bool IsAllDay { get; set; }

        [JsonPropertyName("isAllYear")]
        public bool IsAllYear { get; set; }

        [JsonPropertyName("location")]
        public string Location { get; set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; set; }

        [JsonPropertyName("month-array-northern")]
        public List<int> MonthArrayNorthern { get; set; }

        [JsonPropertyName("month-array-southern")]
        public List<int> MonthArraySouthern { get; set; }

        [JsonPropertyName("time-array")]
        public List<int> TimeArray { get; set; }
    }

    public class Bagworm
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class BandedDragonfly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class BellCricket
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class BlueWeevilBeetle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class BrownCicada
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Centipede
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class CicadaShell
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class CitrusLongHornedBeetle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class CommonBluebottle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class CommonButterfly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Cricket
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class CyclommatusStag
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Damselfly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class DarnerDragonfly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class DivingBeetle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class DroneBeetle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class DungBeetle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class EarthBoringDungBeetle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class EmperorButterfly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class EveningCicada
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("alt-catch-phrase")]
        public List<string> AltCatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Firefly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Flea
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Fly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class GiantCicada
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("alt-catch-phrase")]
        public List<string> AltCatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class GiantStag
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class GiantWaterBug
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class GiraffeStag
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class GoldenStag
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class GoliathBeetle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Grasshopper
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class GreatPurpleEmperor
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class HermitCrab
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Honeybee
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class HornedAtlas
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class HornedDynastid
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class HornedElephant
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class HornedHercules
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class JewelBeetle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Ladybug
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class LongLocust
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class MadagascanSunsetMoth
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class ManFacedStinkBug
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Mantis
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class MigratoryLocust
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class MiyamaStag
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class MoleCricket
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class MonarchButterfly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Mosquito
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Moth
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Name
    {
        [JsonPropertyName("name-USen")]
        public string NameUSen { get; set; }

        [JsonPropertyName("name-EUen")]
        public string NameEUen { get; set; }

        [JsonPropertyName("name-EUde")]
        public string NameEUde { get; set; }

        [JsonPropertyName("name-EUes")]
        public string NameEUes { get; set; }

        [JsonPropertyName("name-USes")]
        public string NameUSes { get; set; }

        [JsonPropertyName("name-EUfr")]
        public string NameEUfr { get; set; }

        [JsonPropertyName("name-USfr")]
        public string NameUSfr { get; set; }

        [JsonPropertyName("name-EUit")]
        public string NameEUit { get; set; }

        [JsonPropertyName("name-EUnl")]
        public string NameEUnl { get; set; }

        [JsonPropertyName("name-CNzh")]
        public string NameCNzh { get; set; }

        [JsonPropertyName("name-TWzh")]
        public string NameTWzh { get; set; }

        [JsonPropertyName("name-JPja")]
        public string NameJPja { get; set; }

        [JsonPropertyName("name-KRko")]
        public string NameKRko { get; set; }

        [JsonPropertyName("name-EUru")]
        public string NameEUru { get; set; }
    }

    public class OrchidMantis
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class PaperKiteButterfly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class PeacockButterfly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class PillBug
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Pondskater
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class QueenAlexandrasBirdwing
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class RainbowStag
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class RajahBrookesBirdwing
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class RedDragonfly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class RiceGrasshopper
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class RobustCicada
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("alt-catch-phrase")]
        public List<string> AltCatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Root
    {
        [JsonPropertyName("common_butterfly")]
        public CommonButterfly CommonButterfly { get; set; }

        [JsonPropertyName("yellow_butterfly")]
        public YellowButterfly YellowButterfly { get; set; }

        [JsonPropertyName("tiger_butterfly")]
        public TigerButterfly TigerButterfly { get; set; }

        [JsonPropertyName("peacock_butterfly")]
        public PeacockButterfly PeacockButterfly { get; set; }

        [JsonPropertyName("common_bluebottle")]
        public CommonBluebottle CommonBluebottle { get; set; }

        [JsonPropertyName("paper_kite_butterfly")]
        public PaperKiteButterfly PaperKiteButterfly { get; set; }

        [JsonPropertyName("great_purple_emperor")]
        public GreatPurpleEmperor GreatPurpleEmperor { get; set; }

        [JsonPropertyName("monarch_butterfly")]
        public MonarchButterfly MonarchButterfly { get; set; }

        [JsonPropertyName("emperor_butterfly")]
        public EmperorButterfly EmperorButterfly { get; set; }

        [JsonPropertyName("agrias_butterfly")]
        public AgriasButterfly AgriasButterfly { get; set; }

        [JsonPropertyName("rajah_brookes_birdwing")]
        public RajahBrookesBirdwing RajahBrookesBirdwing { get; set; }

        [JsonPropertyName("queen_alexandras_birdwing")]
        public QueenAlexandrasBirdwing QueenAlexandrasBirdwing { get; set; }

        [JsonPropertyName("moth")]
        public Moth Moth { get; set; }

        [JsonPropertyName("atlas_moth")]
        public AtlasMoth AtlasMoth { get; set; }

        [JsonPropertyName("madagascan_sunset_moth")]
        public MadagascanSunsetMoth MadagascanSunsetMoth { get; set; }

        [JsonPropertyName("long_locust")]
        public LongLocust LongLocust { get; set; }

        [JsonPropertyName("migratory_locust")]
        public MigratoryLocust MigratoryLocust { get; set; }

        [JsonPropertyName("rice_grasshopper")]
        public RiceGrasshopper RiceGrasshopper { get; set; }

        [JsonPropertyName("grasshopper")]
        public Grasshopper Grasshopper { get; set; }

        [JsonPropertyName("cricket")]
        public Cricket Cricket { get; set; }

        [JsonPropertyName("bell_cricket")]
        public BellCricket BellCricket { get; set; }

        [JsonPropertyName("mantis")]
        public Mantis Mantis { get; set; }

        [JsonPropertyName("orchid_mantis")]
        public OrchidMantis OrchidMantis { get; set; }

        [JsonPropertyName("honeybee")]
        public Honeybee Honeybee { get; set; }

        [JsonPropertyName("wasp")]
        public Wasp Wasp { get; set; }

        [JsonPropertyName("brown_cicada")]
        public BrownCicada BrownCicada { get; set; }

        [JsonPropertyName("robust_cicada")]
        public RobustCicada RobustCicada { get; set; }

        [JsonPropertyName("giant_cicada")]
        public GiantCicada GiantCicada { get; set; }

        [JsonPropertyName("walker_cicada")]
        public WalkerCicada WalkerCicada { get; set; }

        [JsonPropertyName("evening_cicada")]
        public EveningCicada EveningCicada { get; set; }

        [JsonPropertyName("cicada_shell")]
        public CicadaShell CicadaShell { get; set; }

        [JsonPropertyName("red_dragonfly")]
        public RedDragonfly RedDragonfly { get; set; }

        [JsonPropertyName("darner_dragonfly")]
        public DarnerDragonfly DarnerDragonfly { get; set; }

        [JsonPropertyName("banded_dragonfly")]
        public BandedDragonfly BandedDragonfly { get; set; }

        [JsonPropertyName("damselfly")]
        public Damselfly Damselfly { get; set; }

        [JsonPropertyName("firefly")]
        public Firefly Firefly { get; set; }

        [JsonPropertyName("mole_cricket")]
        public MoleCricket MoleCricket { get; set; }

        [JsonPropertyName("pondskater")]
        public Pondskater Pondskater { get; set; }

        [JsonPropertyName("diving_beetle")]
        public DivingBeetle DivingBeetle { get; set; }

        [JsonPropertyName("giant_water_bug")]
        public GiantWaterBug GiantWaterBug { get; set; }

        [JsonPropertyName("stinkbug")]
        public Stinkbug Stinkbug { get; set; }

        [JsonPropertyName("man-faced_stink_bug")]
        public ManFacedStinkBug ManFacedStinkBug { get; set; }

        [JsonPropertyName("ladybug")]
        public Ladybug Ladybug { get; set; }

        [JsonPropertyName("tiger_beetle")]
        public TigerBeetle TigerBeetle { get; set; }

        [JsonPropertyName("jewel_beetle")]
        public JewelBeetle JewelBeetle { get; set; }

        [JsonPropertyName("violin_beetle")]
        public ViolinBeetle ViolinBeetle { get; set; }

        [JsonPropertyName("citrus_long-horned_beetle")]
        public CitrusLongHornedBeetle CitrusLongHornedBeetle { get; set; }

        [JsonPropertyName("rosalia_batesi_beetle")]
        public RosaliaBatesiBeetle RosaliaBatesiBeetle { get; set; }

        [JsonPropertyName("blue_weevil_beetle")]
        public BlueWeevilBeetle BlueWeevilBeetle { get; set; }

        [JsonPropertyName("dung_beetle")]
        public DungBeetle DungBeetle { get; set; }

        [JsonPropertyName("earth-boring_dung_beetle")]
        public EarthBoringDungBeetle EarthBoringDungBeetle { get; set; }

        [JsonPropertyName("scarab_beetle")]
        public ScarabBeetle ScarabBeetle { get; set; }

        [JsonPropertyName("drone_beetle")]
        public DroneBeetle DroneBeetle { get; set; }

        [JsonPropertyName("goliath_beetle")]
        public GoliathBeetle GoliathBeetle { get; set; }

        [JsonPropertyName("saw_stag")]
        public SawStag SawStag { get; set; }

        [JsonPropertyName("miyama_stag")]
        public MiyamaStag MiyamaStag { get; set; }

        [JsonPropertyName("giant_stag")]
        public GiantStag GiantStag { get; set; }

        [JsonPropertyName("rainbow_stag")]
        public RainbowStag RainbowStag { get; set; }

        [JsonPropertyName("cyclommatus_stag")]
        public CyclommatusStag CyclommatusStag { get; set; }

        [JsonPropertyName("golden_stag")]
        public GoldenStag GoldenStag { get; set; }

        [JsonPropertyName("giraffe_stag")]
        public GiraffeStag GiraffeStag { get; set; }

        [JsonPropertyName("horned_dynastid")]
        public HornedDynastid HornedDynastid { get; set; }

        [JsonPropertyName("horned_atlas")]
        public HornedAtlas HornedAtlas { get; set; }

        [JsonPropertyName("horned_elephant")]
        public HornedElephant HornedElephant { get; set; }

        [JsonPropertyName("horned_hercules")]
        public HornedHercules HornedHercules { get; set; }

        [JsonPropertyName("walking_stick")]
        public WalkingStick WalkingStick { get; set; }

        [JsonPropertyName("walking_leaf")]
        public WalkingLeaf WalkingLeaf { get; set; }

        [JsonPropertyName("bagworm")]
        public Bagworm Bagworm { get; set; }

        [JsonPropertyName("ant")]
        public Ant Ant { get; set; }

        [JsonPropertyName("hermit_crab")]
        public HermitCrab HermitCrab { get; set; }

        [JsonPropertyName("wharf_roach")]
        public WharfRoach WharfRoach { get; set; }

        [JsonPropertyName("fly")]
        public Fly Fly { get; set; }

        [JsonPropertyName("mosquito")]
        public Mosquito Mosquito { get; set; }

        [JsonPropertyName("flea")]
        public Flea Flea { get; set; }

        [JsonPropertyName("snail")]
        public Snail Snail { get; set; }

        [JsonPropertyName("pill_bug")]
        public PillBug PillBug { get; set; }

        [JsonPropertyName("centipede")]
        public Centipede Centipede { get; set; }

        [JsonPropertyName("spider")]
        public Spider Spider { get; set; }

        [JsonPropertyName("tarantula")]
        public Tarantula Tarantula { get; set; }

        [JsonPropertyName("scorpion")]
        public Scorpion Scorpion { get; set; }
    }

    public class RosaliaBatesiBeetle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class SawStag
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class ScarabBeetle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Scorpion
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Snail
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Spider
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Stinkbug
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Tarantula
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class TigerBeetle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class TigerButterfly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class ViolinBeetle
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class WalkerCicada
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("alt-catch-phrase")]
        public List<string> AltCatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class WalkingLeaf
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class WalkingStick
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class Wasp
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class WharfRoach
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

    public class YellowButterfly
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("file-name")]
        public string FileName { get; set; }

        [JsonPropertyName("name")]
        public Name Name { get; set; }

        [JsonPropertyName("availability")]
        public Availability Availability { get; set; }

        [JsonPropertyName("price")]
        public int Price { get; set; }

        [JsonPropertyName("price-flick")]
        public int PriceFlick { get; set; }

        [JsonPropertyName("catch-phrase")]
        public string CatchPhrase { get; set; }

        [JsonPropertyName("museum-phrase")]
        public string MuseumPhrase { get; set; }

        [JsonPropertyName("image_uri")]
        public string ImageUri { get; set; }

        [JsonPropertyName("icon_uri")]
        public string IconUri { get; set; }
    }

