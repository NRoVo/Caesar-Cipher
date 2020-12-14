using BenchmarkDotNet.Running;

namespace CaesarCipher.Benchmark
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            BenchmarkRunner.Run<CaesarCipherImplementationBenchmarks>();
        }
    }
}