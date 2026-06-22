using FootballManagerAnalyzer.UI.Services;
using FootballManagerAnalyzer.UI.Services.Interfaces;

namespace FootballManagerAnalyzer.UI
{
    public static class DependencyInjection
    {
        public static void InjectUi(this IServiceCollection services)
        {
            services.AddTransient<IFileParser, FileParser>();
            services.AddTransient<IAttributesService, AttributesService>();
        }
    }
}
