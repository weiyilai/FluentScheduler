using System.Diagnostics.CodeAnalysis;

namespace FluentScheduler.UnitTests.Mocks;

[SuppressMessage("Design", "CA1812")]
internal class CtorJob : IJob
{
    public CtorJob() => ++Calls;

    public static int Calls { get; private set; }

    public void Execute() { }
}
