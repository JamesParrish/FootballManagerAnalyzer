using FootballManagerAnalyzer.Application.Models;
using FootballManagerAnalyzer.UI.Services.Interfaces;

namespace FootballManagerAnalyzer.UI.Services
{
    public class AttributesService : IAttributesService
    {
        private const int RequiredWeighting = 3;
        private const int PreferredWeighting = 2;

        public decimal GetAverageRating(Attributes attributes)
        {
            var relevantAttributes = new List<int>
            {
                attributes.Acceleration,
                attributes.Agility,
                attributes.Balance,
                attributes.Jumping,
                attributes.NaturalFitness,
                attributes.Pace,
                attributes.Stamina,
                attributes.Strength,
                attributes.Corners,
                attributes.Crossing,
                attributes.Dribbling,
                attributes.Finishing,
                attributes.FirstTouch,
                attributes.FreeKicks,
                attributes.Heading,
                attributes.LongShots,
                attributes.LongThrows,
                attributes.Marking,
                attributes.Passing,
                attributes.Penalties,
                attributes.Tackling,
                attributes.Technique,
                attributes.Aggression,
                attributes.Anticipation,
                attributes.Bravery,
                attributes.Composure,
                attributes.Concentration,
                attributes.Decisions,
                attributes.Determination,
                attributes.Flair,
                attributes.Leadership,
                attributes.OffTheBall,
                attributes.Positioning,
                attributes.Teamwork,
                attributes.Vision,
                attributes.WorkRate
            };

            var average = GetAverage(relevantAttributes);

            return average;
        }

        public decimal GetAveragePhysicalRating(Attributes attributes)
        {
            var relevantAttributes = new List<int>
            {
                attributes.Acceleration,
                attributes.Agility,
                attributes.Balance,
                attributes.Jumping,
                attributes.NaturalFitness,
                attributes.Pace,
                attributes.Stamina,
                attributes.Strength
            };

            var average = GetAverage(relevantAttributes);

            return average;
        }

        public decimal GetAverageDefenderRating(Attributes attributes)
        {
            var requiredAttributes = new List<int>
            {
                attributes.Jumping,
                attributes.Strength,
                attributes.Heading,
                attributes.Marking,
                attributes.Tackling,
                attributes.Positioning
            };

            var requiredAverage = GetAverage(requiredAttributes);

            var preferredAttributes = new List<int>
            {
                attributes.Pace,
                attributes.Aggression,
                attributes.Anticipation,
                attributes.Bravery,
                attributes.Composure,
                attributes.Concentration,
                attributes.Decisions
            };

            var preferredAverage = GetAverage(preferredAttributes);

            var average = ((requiredAverage * RequiredWeighting) + (preferredAverage * PreferredWeighting)) / (RequiredWeighting + PreferredWeighting);

            return average;
        }

        public decimal GetAverageWingBackRating(Attributes attributes)
        {
            var requiredAttributes = new List<int>
            {
                attributes.Acceleration,
                attributes.Pace,
                attributes.Stamina,
                attributes.Crossing,
                attributes.Dribbling,
                attributes.Marking,
                attributes.Passing,
                attributes.Tackling,
                attributes.OffTheBall,
                attributes.Teamwork,
                attributes.WorkRate
            };

            var requiredAverage = GetAverage(requiredAttributes);

            var preferredAttributes = new List<int>
            {
                attributes.Agility,
                attributes.Balance,
                attributes.FirstTouch,
                attributes.Technique,
                attributes.Anticipation,
                attributes.Concentration,
                attributes.Decisions,
                attributes.Positioning
            };

            var preferredAverage = GetAverage(preferredAttributes);

            var average = ((requiredAverage * RequiredWeighting) + (preferredAverage * PreferredWeighting)) / (RequiredWeighting + PreferredWeighting);

            return average;
        }

        public decimal GetAverageDefensiveMidfielderRating(Attributes attributes)
        {
            var requiredAttributes = new List<int>
            {
                attributes.Stamina,
                attributes.Tackling,
                attributes.Aggression,
                attributes.Anticipation,
                attributes.Teamwork,
                attributes.WorkRate
            };

            var requiredAverage = GetAverage(requiredAttributes);

            var preferredAttributes = new List<int>
            {
                attributes.Agility,
                attributes.Pace,
                attributes.Strength,
                attributes.Marking,
                attributes.Bravery,
                attributes.Concentration,
                attributes.Positioning
            };

            var preferredAverage = GetAverage(preferredAttributes);

            var average = ((requiredAverage * RequiredWeighting) + (preferredAverage * PreferredWeighting)) / (RequiredWeighting + PreferredWeighting);

            return average;
        }

        public decimal GetAverageCentralMidfielderRating(Attributes attributes)
        {
            var requiredAttributes = new List<int>
            {
                attributes.FirstTouch,
                attributes.Passing,
                attributes.Tackling,
                attributes.Decisions,
                attributes.Teamwork
            };

            var requiredAverage = GetAverage(requiredAttributes);

            var preferredAttributes = new List<int>
            {
                attributes.Acceleration,
                attributes.Pace,
                attributes.Stamina,
                attributes.Technique,
                attributes.Anticipation,
                attributes.Composure,
                attributes.Concentration,
                attributes.OffTheBall,
                attributes.Vision,
                attributes.WorkRate
            };

            var preferredAverage = GetAverage(preferredAttributes);

            var average = ((requiredAverage * RequiredWeighting) + (preferredAverage * PreferredWeighting)) / (RequiredWeighting + PreferredWeighting);

            return average;
        }

        public decimal GetAverageAttackingMidfielderRating(Attributes attributes)
        {
            var requiredAttributes = new List<int>
            {
                attributes.FirstTouch,
                attributes.Passing,
                attributes.Technique,
                attributes.Composure,
                attributes.Decisions,
                attributes.OffTheBall,
                attributes.Teamwork,
                attributes.Vision
            };

            var requiredAverage = GetAverage(requiredAttributes);

            var preferredAttributes = new List<int>
            {
                attributes.Agility,
                attributes.Pace,
                attributes.Dribbling,
                attributes.Anticipation,
                attributes.Flair,
            };

            var preferredAverage = GetAverage(preferredAttributes);

            var average = ((requiredAverage * RequiredWeighting) + (preferredAverage * PreferredWeighting)) / (RequiredWeighting + PreferredWeighting);

            return average;
        }

        public decimal GetAverageWingerRating(Attributes attributes)
        {
            var requiredAttributes = new List<int>
            {
                attributes.Acceleration,
                attributes.Agility,
                attributes.Pace,
                attributes.Dribbling,
                attributes.Passing,
                attributes.Technique,
            };

            var requiredAverage = GetAverage(requiredAttributes);

            var preferredAttributes = new List<int>
            {
                attributes.Balance,
                attributes.Stamina,
                attributes.Crossing,
                attributes.Finishing,
                attributes.FirstTouch,
                attributes.Anticipation,
                attributes.Composure,
                attributes.Decisions,
                attributes.Flair,
                attributes.OffTheBall,
                attributes.Vision,
                attributes.WorkRate
            };

            var preferredAverage = GetAverage(preferredAttributes);

            var average = ((requiredAverage * RequiredWeighting) + (preferredAverage * PreferredWeighting)) / (RequiredWeighting + PreferredWeighting);

            return average;
        }

        public decimal GetAverageStrikerRating(Attributes attributes)
        {
            var requiredAttributes = new List<int>
            {
                attributes.Acceleration,
                attributes.Pace,
                attributes.Finishing,
                attributes.FirstTouch,
                attributes.Composure,
                attributes.OffTheBall
            };

            var requiredAverage = GetAverage(requiredAttributes);

            var preferredAttributes = new List<int>
            {
                attributes.Agility,
                attributes.Balance,
                attributes.Stamina,
                attributes.Dribbling,
                attributes.Heading,
                attributes.Passing,
                attributes.Technique,
                attributes.Anticipation,
                attributes.Decisions,
                attributes.WorkRate
            };

            var preferredAverage = GetAverage(preferredAttributes);

            var average = ((requiredAverage * RequiredWeighting) + (preferredAverage * PreferredWeighting)) / (RequiredWeighting + PreferredWeighting);

            return average;
        }

        public decimal GetAverageThingRating(Attributes attributes)
        {
            var requiredAttributes = new List<int>
            {
                attributes.Acceleration,
                attributes.Agility,
                attributes.Balance,
                attributes.Jumping,
                attributes.NaturalFitness,
                attributes.Pace,
                attributes.Stamina,
                attributes.Strength,
                attributes.Corners,
                attributes.Crossing,
                attributes.Dribbling,
                attributes.Finishing,
                attributes.FirstTouch,
                attributes.FreeKicks,
                attributes.Heading,
                attributes.LongShots,
                attributes.LongThrows,
                attributes.Marking,
                attributes.Passing,
                attributes.Penalties,
                attributes.Tackling,
                attributes.Technique,
                attributes.Aggression,
                attributes.Anticipation,
                attributes.Bravery,
                attributes.Composure,
                attributes.Concentration,
                attributes.Decisions,
                attributes.Determination,
                attributes.Flair,
                attributes.Leadership,
                attributes.OffTheBall,
                attributes.Positioning,
                attributes.Teamwork,
                attributes.Vision,
                attributes.WorkRate
            };

            var requiredAverage = GetAverage(requiredAttributes);

            var preferredAttributes = new List<int>
            {
                attributes.Acceleration,
                attributes.Agility,
                attributes.Balance,
                attributes.Jumping,
                attributes.NaturalFitness,
                attributes.Pace,
                attributes.Stamina,
                attributes.Strength,
                attributes.Corners,
                attributes.Crossing,
                attributes.Dribbling,
                attributes.Finishing,
                attributes.FirstTouch,
                attributes.FreeKicks,
                attributes.Heading,
                attributes.LongShots,
                attributes.LongThrows,
                attributes.Marking,
                attributes.Passing,
                attributes.Penalties,
                attributes.Tackling,
                attributes.Technique,
                attributes.Aggression,
                attributes.Anticipation,
                attributes.Bravery,
                attributes.Composure,
                attributes.Concentration,
                attributes.Decisions,
                attributes.Determination,
                attributes.Flair,
                attributes.Leadership,
                attributes.OffTheBall,
                attributes.Positioning,
                attributes.Teamwork,
                attributes.Vision,
                attributes.WorkRate
            };

            var preferredAverage = GetAverage(preferredAttributes);

            var average = ((requiredAverage * RequiredWeighting) + (preferredAverage * PreferredWeighting)) / (RequiredWeighting + PreferredWeighting);

            return average;
        }

        private decimal GetAverage(IEnumerable<int> attributes)
        {
            return attributes.Sum() / attributes.Count();
        }
    }
}
