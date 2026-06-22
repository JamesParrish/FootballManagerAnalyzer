using System.Text;
using FootballManagerAnalyzer.Application.Models;
using FootballManagerAnalyzer.Application.Services.Interfaces;
using FootballManagerAnalyzer.UI.Services.Interfaces;
using Microsoft.AspNetCore.Components.Forms;

namespace FootballManagerAnalyzer.UI.Services
{
    public class FileParser : IFileParser
    {
        private readonly ISquadDataParser _squadDataParser;
        public FileParser(ISquadDataParser squadDataParser)
        {
            _squadDataParser = squadDataParser;
        }

        public async Task<IEnumerable<Player>> ParseAsync(IBrowserFile file)
        {
            var lines = new List<string>();

            using (var streamReader = new StreamReader(file.OpenReadStream(), Encoding.UTF8, true))
            {
                String line;
                while ((line = await streamReader.ReadLineAsync()) != null)
                {
                    lines.Add(line);
                }
            }

            return _squadDataParser.Parse(lines);
        }
    }
}
