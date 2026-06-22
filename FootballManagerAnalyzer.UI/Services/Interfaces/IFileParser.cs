using FootballManagerAnalyzer.Application.Models;
using Microsoft.AspNetCore.Components.Forms;

namespace FootballManagerAnalyzer.UI.Services.Interfaces
{
    public interface IFileParser
    {
        Task<IEnumerable<Player>> ParseAsync(IBrowserFile file);
    }
}
