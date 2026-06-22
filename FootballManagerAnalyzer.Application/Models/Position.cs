using System.ComponentModel.DataAnnotations;

namespace FootballManagerAnalyzer.Application.Models
{
    public enum Position
    {
        [Display(Name = "All")]
        Unknown,
        Goalkeeper,
        Defender,
        [Display(Name = "Wing Back")]
        WingBack,
        [Display(Name = "Defensive Midfielder")]
        DefensiveMidfielder,
        [Display(Name = "Central Midfielder")]
        CentralMidfielder,
        [Display(Name = "Attacking Midfielder")]
        AttackingMidfielder,
        Winger,
        Striker
    }
}
