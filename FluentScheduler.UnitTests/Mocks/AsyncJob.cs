namespace FluentScheduler.UnitTests.Mocks;

using System.Threading.Tasks;

public class AsyncJob : IAsyncJob
{
    public static int Calls { get; private set; }

    public async Task ExecuteAsync()
    {
        ++Calls;
        await Task.CompletedTask;
    }
}
