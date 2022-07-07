using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using FluentOutcomes;
using Console.Models;

namespace Console.Services;

public class AppService : IAppService
{
    private readonly ILogger<AppService> _logger;
    private readonly IConfiguration _config;

    public AppService(ILogger<AppService> logger, IConfiguration config)
    {
        _logger = logger;
        _config = config;
    }

    public void Run()
    {
        _logger.LogWarning("Starting...");

        var x = Outcome
            .Expect<Mock>()
            .SuccessIf(true)
            .Otherwise()
            .Return(() => {
                return new Mock();
            });

        _logger.LogWarning($"Mock: {x.Value.Message}");

    }
}