using System;
namespace MyFirstAPI.Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public bool FoundCheck { get; set; }
        public Location? Location { get; set; }
    }
}
