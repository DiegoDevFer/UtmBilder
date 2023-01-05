using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UtmBilder.Core
{
    public class Utm
    {

        public Utm(Url url, Campaign campaign)
        {
            Url = url;
            Campaign = campaign;
        }

        public Url Url { get; private set; }
        public Campaign Campaign { get; private set; }

        public static implicit operator string(Utm utm) => utm.ToString();

        public static implicit operator Utm(string link)
        {
            if (string.IsNullOrEmpty(link))
                throw new InvalidUrlException();

            var url = new Url(link);
            var segments = url.Address.Split("?");
            if (segments.length == 1)
                throw new InvalidUrlException("No segments were provides");
        }

        public override string ToString()
        {
            var segments = new List<String>();

            segments.AddIfNotNull("utm_source", Campaign.Source);
            segments.AddIfNotNull("utm_medium", Campaign.Medium);
            segments.AddIfNotNull("utm_campaign", Campaign.Name);
            segments.AddIfNotNull("utm_id", Campaign.Id);
            segments.AddIfNotNull("utm_term", Campaign.Term);
            segments.AddIfNotNull("utm_content", Campaign.Content);

            return $"{Url.Address}?{string.Join("&", segments)}";
        }

    }
}