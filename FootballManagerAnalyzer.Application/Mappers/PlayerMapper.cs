using System.Text.RegularExpressions;
using FootballManagerAnalyzer.Application.Extensions;
using FootballManagerAnalyzer.Application.Mappers.Interfaces;
using FootballManagerAnalyzer.Application.Models;

namespace FootballManagerAnalyzer.Application.Mappers
{
    internal class PlayerMapper : IPlayerMapper
    {
        public Player Map(string input)
        {
            var properties = GetProperties(input);

            var positionsString = properties.GetAttribute(DataColumn.Position);

            var player = new Player
            {
                PositionSelected = properties.GetAttribute(DataColumn.PositionSelected),
                Name = properties.GetAttribute(DataColumn.Name),
                Position = positionsString,
                Positions = GetPositions(positionsString),
                BestPosition = properties.GetAttribute(DataColumn.BestPosition),
                BestRole = properties.GetAttribute(DataColumn.BestRole),
                Attributes = MapAttributes(properties)
            };

            return player;
        }

        private IEnumerable<Position> GetPositions(string positionsString)
        {
            var positions = new List<Position>();

            if (positionsString.Contains("GK"))
            {
                positions.Add(Position.Goalkeeper);
            }

            var defenderRegex = new Regex(@".*D[\w/]* \(\w*C\w*\).*");
            if (defenderRegex.IsMatch(positionsString))
            {
                positions.Add(Position.Defender);
            }

            var fullBackRegex = new Regex(@".*D[\w/]* \(\w*[L|R]\w*\).*");
            var wingBackRegex = new Regex(@".*WB[\w/]* \(\w*[L|R]\w*\).*");
            if (fullBackRegex.IsMatch(positionsString) || wingBackRegex.IsMatch(positionsString))
            {
                positions.Add(Position.WingBack);
            }

            if (positionsString.Contains("DM"))
            {
                positions.Add(Position.DefensiveMidfielder);
            }

            var midfielderRegex = new Regex(@".*[\w/]*(^M|[^A]M)[\w/]* \(\w*C\w*\).*");
            if (midfielderRegex.IsMatch(positionsString))
            {
                positions.Add(Position.CentralMidfielder);
            }

            var attackingMidfielderRegex = new Regex(@".*[\w/]*AM[\w/]* \(\w*C\w*\).*");
            if (attackingMidfielderRegex.IsMatch(positionsString))
            {
                positions.Add(Position.AttackingMidfielder);
            }

            var wingerRegex = new Regex(@".*[\w/]*AM[\w/]* \(\w*[L|R]\w*\).*");
            if (wingerRegex.IsMatch(positionsString))
            {
                positions.Add(Position.Winger);
            }

            if (positionsString.Contains("ST"))
            {
                positions.Add(Position.Striker);
            }

            return positions;
        }

        private Attributes MapAttributes(IList<string> properties)
        {
            var attributes = new Attributes
            {
                Acceleration = properties.GetIntAttribute(DataColumn.Acceleration),
                Agility = properties.GetIntAttribute(DataColumn.Agility),
                Balance = properties.GetIntAttribute(DataColumn.Balance),
                Jumping = properties.GetIntAttribute(DataColumn.Jumping),
                NaturalFitness = properties.GetIntAttribute(DataColumn.NaturalFitness),
                Pace = properties.GetIntAttribute(DataColumn.Pace),
                Stamina = properties.GetIntAttribute(DataColumn.Stamina),
                Strength = properties.GetIntAttribute(DataColumn.Strength),
                Corners = properties.GetIntAttribute(DataColumn.Corners),
                Crossing = properties.GetIntAttribute(DataColumn.Crossing),
                Dribbling = properties.GetIntAttribute(DataColumn.Dribbling),
                Finishing = properties.GetIntAttribute(DataColumn.Finishing),
                FirstTouch = properties.GetIntAttribute(DataColumn.FirstTouch),
                FreeKicks = properties.GetIntAttribute(DataColumn.FreeKicks),
                Heading = properties.GetIntAttribute(DataColumn.Heading),
                LongShots = properties.GetIntAttribute(DataColumn.LongShots),
                LongThrows = properties.GetIntAttribute(DataColumn.LongThrows),
                Marking = properties.GetIntAttribute(DataColumn.Marking),
                Passing = properties.GetIntAttribute(DataColumn.Passing),
                Penalties = properties.GetIntAttribute(DataColumn.Penalties),
                Tackling = properties.GetIntAttribute(DataColumn.Tackling),
                Technique = properties.GetIntAttribute(DataColumn.Technique),
                Aggression = properties.GetIntAttribute(DataColumn.Aggression),
                Anticipation = properties.GetIntAttribute(DataColumn.Anticipation),
                Bravery = properties.GetIntAttribute(DataColumn.Bravery),
                Composure = properties.GetIntAttribute(DataColumn.Composure),
                Concentration = properties.GetIntAttribute(DataColumn.Concentration),
                Decisions = properties.GetIntAttribute(DataColumn.Decisions),
                Determination = properties.GetIntAttribute(DataColumn.Determination),
                Flair = properties.GetIntAttribute(DataColumn.Flair),
                Leadership = properties.GetIntAttribute(DataColumn.Leadership),
                OffTheBall = properties.GetIntAttribute(DataColumn.OffTheBall),
                Positioning = properties.GetIntAttribute(DataColumn.Positioning),
                Teamwork = properties.GetIntAttribute(DataColumn.Teamwork),
                Vision = properties.GetIntAttribute(DataColumn.Vision),
                WorkRate = properties.GetIntAttribute(DataColumn.WorkRate),
            };

            return attributes;
        }

        private IList<string> GetProperties(string input)
        {
            var properties = input
                .Trim('|')
                .Split('|')
                .Select(p => p.Trim())
                .ToList();

            return properties;
        }
    }
}
