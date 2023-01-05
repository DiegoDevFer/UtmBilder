using UtmBilder.Core.ValueObjects.Exceptions;

namespace UtmBilder.Core.ValueObjects
{
    public class Campaign : ValueObjects
    {
        public Campaign(
            string source,
            string medium,
            string name,
            string? id = null,
            string? term = null,
            string? content = null
        )
        {
            Source = source;
            Medium = medium;
            Name = name;
            Id = id;
            Term = term;
            Content = content;
            InvalidCampaignException.ThrowIfNull(Source, "Source is invalid!");
            InvalidCampaignException.ThrowIfNull(Medium, "Medium is invalid!");
            InvalidCampaignException.ThrowIfNull(Name, "Name is invalid!");
        }

        public string Source { get; private set; }
        public string Medium { get; private set; }
        public string Name { get; private set; }
        public string? Id { get; private set; }
        public string? Term { get; private set; }
        public string? Content { get; private set; }
    }
}