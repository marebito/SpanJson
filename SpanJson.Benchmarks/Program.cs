﻿using BenchmarkDotNet.Running;

namespace SpanJson.Benchmarks
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var ab = new AsyncBenchmark();
            ab.Count = 10;
            ab.Setup();
            ab.SerializeAnswerList().GetAwaiter().GetResult();
            // dotnet run -c Release -- --methods=ReadUtf8Char
            var switcher = new BenchmarkSwitcher(typeof(Program).Assembly);
            switcher.Run(args);
        }
    }
}