namespace FluentScheduler.UnitTests.Mocks;

using System;
using System.Diagnostics.CodeAnalysis;

[SuppressMessage("Design", "CA1812")]
internal class StronglyTypedTestJob : IJob
{
    public void Execute() => Console.WriteLine("Hi");
}