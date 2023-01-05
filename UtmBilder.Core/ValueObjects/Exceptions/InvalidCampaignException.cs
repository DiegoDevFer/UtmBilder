using System.Text.RegularExpressions;

namespace UtmBilder.Core.ValueObjects.Exceptions
{
    public class InvalidCampaignException : Exception
    {
        private const string ErrorMessage = "Invalid UTM parameters!";
        public InvalidCampaignException(string message = ErrorMessage) : base(message)
        {

        }

        public static void ThrowIfNull(string item, string message = ErrorMessage)
        {
            if (string.IsNullOrEmpty(item))
            {
                throw new InvalidCampaignException(message);
            }
        }
    }
}