using BenchmarkDotNet.Attributes;

namespace Leetcode.Csharp.Benchmarks
{
    public class SingleElementInSortedArrayBenchmark
    {
        private static int[] _numbers1000000;
        private static int[] _numbers100000;
        private static int[] _numbers10000;
        private static int[] _numbers1000;
        private static int[] _numbers100;
        private static int[] _numbers10;


        static SingleElementInSortedArrayBenchmark()
        {
            _numbers1000000 = GenerateInput(1000000);
            _numbers100000 = GenerateInput(100000);
            _numbers10000 = GenerateInput(10000);
            _numbers1000 = GenerateInput(1000);
            _numbers100 = GenerateInput(100);
            _numbers10 = GenerateInput(10);
        }

        private static int[] GenerateInput(int max)
        {
            return Enumerable
                .Range(0, max)
                .Select(i =>
                {
                    if (i == max / 2)
                    {
                        return new int[] { i * 2 + 1 };
                    }
                    return Enumerable.Repeat(i * 2, 2);
                })
                .SelectMany(i => i)
                .OrderBy(x => x)
                .ToArray();
        }

        [Benchmark]
        public void V1_1000000() => SingleElementInSortedArray.SolveV1(_numbers1000000);

        [Benchmark]
        public void V2_1000000() => SingleElementInSortedArray.SolveV2(_numbers1000000);

        [Benchmark]
        public void V3_1000000() => SingleElementInSortedArray.SolveV3(_numbers1000000);

        [Benchmark]
        public void V4_1000000() => SingleElementInSortedArray.SolveV3(_numbers1000000);

        [Benchmark]
        public void V1_100000() => SingleElementInSortedArray.SolveV1(_numbers100000);

        [Benchmark]
        public void V2_100000() => SingleElementInSortedArray.SolveV2(_numbers100000);

        [Benchmark]
        public void V3_100000() => SingleElementInSortedArray.SolveV3(_numbers100000);

        [Benchmark]
        public void V4_100000() => SingleElementInSortedArray.SolveV3(_numbers100000);

        [Benchmark]
        public void V1_10000() => SingleElementInSortedArray.SolveV1(_numbers1000);

        [Benchmark]
        public void V2_10000() => SingleElementInSortedArray.SolveV2(_numbers1000);

        [Benchmark]
        public void V3_10000() => SingleElementInSortedArray.SolveV3(_numbers1000);

        [Benchmark]
        public void V4_10000() => SingleElementInSortedArray.SolveV3(_numbers1000);

        [Benchmark]
        public void V1_100() => SingleElementInSortedArray.SolveV1(_numbers100);

        [Benchmark]
        public void V2_100() => SingleElementInSortedArray.SolveV2(_numbers100);

        [Benchmark]
        public void V3_100() => SingleElementInSortedArray.SolveV3(_numbers100);

        [Benchmark]
        public void V4_100() => SingleElementInSortedArray.SolveV3(_numbers100);

        [Benchmark]
        public void V1_10() => SingleElementInSortedArray.SolveV1(_numbers10);

        [Benchmark]
        public void V2_10() => SingleElementInSortedArray.SolveV2(_numbers10);

        [Benchmark]
        public void V3_10() => SingleElementInSortedArray.SolveV3(_numbers10);

        [Benchmark]
        public void V4_10() => SingleElementInSortedArray.SolveV3(_numbers10);
    }
}
