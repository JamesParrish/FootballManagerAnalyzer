using FootballManagerAnalyzer.Application.Models;

namespace FootballManagerAnalyzer.UI.Services.Interfaces
{
    public interface IAttributesService
    {
        decimal GetAverageRating(Attributes attributes);
        decimal GetAveragePhysicalRating(Attributes attributes);
        decimal GetAverageDefenderRating(Attributes attributes);
        decimal GetAverageWingBackRating(Attributes attributes);
        decimal GetAverageDefensiveMidfielderRating(Attributes attributes);
        decimal GetAverageCentralMidfielderRating(Attributes attributes);
        decimal GetAverageAttackingMidfielderRating(Attributes attributes);
        decimal GetAverageWingerRating(Attributes attributes);
        decimal GetAverageStrikerRating(Attributes attributes);
    }
}
