namespace FluentScheduler.TestApplication;

using System;
using System.Diagnostics.CodeAnalysis;
using static Serilog.Log;

[SuppressMessage("Design", "CA1812")]
internal class DisposableJob : IJob, IDisposable
{
    public void Execute() => Logger.Information("Disposable: executing");

    public void Dispose() => Logger.Information("Disposable: disposed");
}
