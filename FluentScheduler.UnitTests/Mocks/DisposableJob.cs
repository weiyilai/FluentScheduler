namespace FluentScheduler.UnitTests.Mocks;

using System;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Design", "CA1812")]
internal class DisposableJob : IJob, IDisposable
{
    public DisposableJob() => Disposed = false;

    public static bool Disposed { get; private set; }

    public void Execute() { }

    public void Dispose() => Disposed = true;
}
