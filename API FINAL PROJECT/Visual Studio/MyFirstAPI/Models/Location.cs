using System;
namespace MyFirstAPI.Models
{
    public class Location
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public bool DiscoveredCheck { get; set; }
        public int RecommendedLevel { get; set; }
    }
}
