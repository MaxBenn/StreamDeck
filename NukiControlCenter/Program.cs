using System.Threading.Tasks;
using StreamDeckLib;
using StreamDeckLib.Config;

namespace NukiControlCenter;

internal class Program
{
    private static async Task Main(string[] args)
    {
        using (var config = ConfigurationBuilder.BuildDefaultConfiguration(args))
        {
            await ConnectionManager.Initialize(args, config.LoggerFactory)
                .RegisterAllActions(typeof(Program).Assembly)
                .StartAsync();
        }
    }
}