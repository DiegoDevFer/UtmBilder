using System.Text.RegularExpressions;
using UtmBilder.Core.ValueObjects.Exceptions;

namespace UtmBilder.Core.ValueObjects
{
    public class Url : ValueObjects
    {
        private const string UrlRegexPatern = @"/^https?:\/\/(?:www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b(?:[-a-zA-Z0-9()@:%_\+.~#?&\/=]*)$/";
        ///<summary>
        /// Create a new  URL
        ///</summary>
        ///<param name="address">Address of URL (Website link)</param>
        public Url(string address)
        {
            Address = address;
            if (Regex.IsMatch(Address, UrlRegexPatern))
            {
                throw new InvalidUrlException("teste de validade de url");
            };
        }

        ///<summary>
        /// Address of URL (Website link)
        ///</summary>
        public string Address { get; private set; }
    }
}