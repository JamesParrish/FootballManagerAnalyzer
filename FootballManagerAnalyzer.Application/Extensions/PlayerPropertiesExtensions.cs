using FootballManagerAnalyzer.Application.Models;

namespace FootballManagerAnalyzer.Application.Extensions
{
    internal static class PlayerPropertiesExtensions
    {
        internal static string GetAttribute(this IList<string> properties, DataColumn dataColumn)
        {
            return properties[(int)dataColumn];
        }

        internal static int GetIntAttribute(this IList<string> properties, DataColumn dataColumn)
        {
            var value = properties[(int)dataColumn];

            if (!int.TryParse(value, out var intValue))
            {
                return 0;
            }

            return intValue;
        }
    }
}
