using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCentrum2
{
    public static class CsvParser
    {
        public static T[] Parse<T>(string csv, Func<string[], T> parser, Func<T, object> orderBy)
        {
            return Parse(csv.Split(new[] { '\n', '\r' }), parser, orderBy);
        }

        public static T[] Parse<T>(string[] csv, Func<string[], T> parser, Func<T, object> orderBy)
        {
            T[] output = new T[csv.Length];
            Parallel.For(0, csv.Length, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount },
                i =>
                {
                    output[i] = parser(csv[i].Split(new[] { ',', ';' }));
                });
            return output.Where(x => x != null).OrderBy(orderBy).ToArray();
        }
    }
}
