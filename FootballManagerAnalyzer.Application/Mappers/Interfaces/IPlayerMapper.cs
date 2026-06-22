using FootballManagerAnalyzer.Application.Models;

namespace FootballManagerAnalyzer.Application.Mappers.Interfaces
{
    internal interface IPlayerMapper
    {
        Player Map(string input);
    }
}
