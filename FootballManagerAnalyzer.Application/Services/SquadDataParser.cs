using System.Text.RegularExpressions;
using FootballManagerAnalyzer.Application.Mappers.Interfaces;
using FootballManagerAnalyzer.Application.Models;
using FootballManagerAnalyzer.Application.Services.Interfaces;

namespace FootballManagerAnalyzer.Application.Services
{
    internal class SquadDataParser : ISquadDataParser
    {
        private readonly IPlayerMapper _playerMapper;

        public SquadDataParser(IPlayerMapper playerMapper)
        {
            _playerMapper = playerMapper;
        }

        public IEnumerable<Player> Parse(IEnumerable<string> input)
        {
            return input.Where(l => IsDataLine(l)).Select(l => _playerMapper.Map(l));
        }

        private bool IsDataLine(string line)
        {
            // Any line with a number is a valid data line
            var dataLineRegex = new Regex(@".*\d.*");
            return dataLineRegex.IsMatch(line);
        }
    }
}
