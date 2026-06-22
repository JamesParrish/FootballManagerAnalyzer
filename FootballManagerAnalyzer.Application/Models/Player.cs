
namespace FootballManagerAnalyzer.Application.Models
{
    public class Player
    {
        public string PositionSelected { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public IEnumerable<Position> Positions { get; set; }
        public string BestPosition { get; set; }
        public string BestRole { get; set; }
        public Attributes Attributes { get; set; }
    }
}
