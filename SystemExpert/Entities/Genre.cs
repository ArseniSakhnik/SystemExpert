using System.Collections.Generic;
using SystemExpert.Enums;

namespace SystemExpert.Entities
{
    public class Genre
    {
        public string Name { get; set; }
        public Feature FeatureId { get; set; } = Feature.Нет;
        public List<MusicalGroup> Groups { get; set; }
    }
}