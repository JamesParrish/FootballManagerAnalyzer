using FootballManagerAnalyzer.Application.Mappers;
using FootballManagerAnalyzer.Application.Mappers.Interfaces;
using FootballManagerAnalyzer.Application.Services;
using FootballManagerAnalyzer.Application.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace FootballManagerAnalyzer.Application
{
    public static class DependencyInjection
    {
        public static void InjectApplication(this IServiceCollection services)
        {
            services.AddTransient<ISquadDataParser, SquadDataParser>();
            services.AddTransient<IPlayerMapper, PlayerMapper>();
        }
    }
}
