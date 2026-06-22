using FootballManagerAnalyzer.Application.Models;

namespace FootballManagerAnalyzer.Application.Services.Interfaces
{
    public interface ISquadDataParser
    {
        IEnumerable<Player> Parse(IEnumerable<string> input);
    }
}
