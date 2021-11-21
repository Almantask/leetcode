using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Csharp.Benchmarks
{
    public class SingleElementInSortedArrayBenchmark
    {
        private static int[] _numbers;


        static SingleElementInSortedArrayBenchmark()
        {
            const int max = 100000;
            _numbers = Enumerable
                .Range(0, max)
                .Select(i => 
                    {
                        if(i == max / 2)
                        {
                            return new int[] { i * 2 + 1};
                        }
                        return Enumerable.Repeat(i * 2, 2);
                    })
                .SelectMany(i => i)
                .OrderBy(x => x)
                .ToArray();
        }

        [Benchmark]
        public void V1() => SingleElementInSortedArray.SolveV1(_numbers);

        [Benchmark]
        public void V2() => SingleElementInSortedArray.SolveV2(_numbers);

        [Benchmark]
        public void V3() => SingleElementInSortedArray.SolveV3(_numbers);
    }
}
