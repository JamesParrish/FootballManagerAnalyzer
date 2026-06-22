using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace FootballManagerAnalyzer.UI.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum input)
        {
            var displayAttribute = input.GetType()
                .GetMember(input.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>();

            return displayAttribute?.GetName() ?? input.ToString();
        }
    }
}
