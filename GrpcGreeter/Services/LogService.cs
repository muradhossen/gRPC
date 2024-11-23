
using Grpc.Core;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace GrpcGreeter.Services;

public class LogService  : Logger.LoggerBase
{
    private readonly ILogger<LogService> _logger;

    public LogService(ILogger<LogService> logger)
    {
        _logger = logger;
    }

    public override async Task<LogResponse> LogInfo(LogRequest request, ServerCallContext context)
    {

        _logger.LogInformation(request.Message);

        return new LogResponse
        {
            IsSaved = true,
        };

    }
}
