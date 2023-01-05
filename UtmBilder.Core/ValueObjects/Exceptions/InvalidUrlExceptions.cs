using System.Text.RegularExpressions;

namespace UtmBilder.Core.ValueObjects.Exceptions
{
    public class InvalidUrlException : Exception
    {
        private const string ErrorMessage = "Invalid URL!";
        private const string UrlRegexPatern = @"/^https?:\/\/(?:www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b(?:[-a-zA-Z0-9()@:%_\+.~#?&\/=]*)$/";
        public InvalidUrlException(string message = ErrorMessage) : base(message)
        {

        }

        public static void ThrowIfInvalidUrl(string address, string message = ErrorMessage)
        {
            if (string.IsNullOrEmpty(address))
            {
                throw new InvalidUrlException(message);
            }

            if (!Regex.IsMatch(address, UrlRegexPatern))
            {
                throw new InvalidUrlException(message);
            }
        }
    }
}