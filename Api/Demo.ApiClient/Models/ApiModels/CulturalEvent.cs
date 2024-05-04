using System;

namespace Demo.ApiClient.Models.ApiModels
{
    public class CulturalEvent
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }
        public string? Description { get; set; }
        public bool SignedUp { get; set; }
    }
}
