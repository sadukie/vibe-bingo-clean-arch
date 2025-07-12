using VibeBingo.Application;

namespace vibe_bingo_clean_arch;

public static class ServiceRegistration
{
    public static void AddVibeBingoServices(this IServiceCollection services)
    {
        services.AddSingleton<BingoService>();
    }
}
