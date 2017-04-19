using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    class Program
    {
        public static int Accumulate(Func<int, int, int> combiner, int nullValue, IEnumerable<int> l)
        {
            if (l.Count() == 0)
                return nullValue;
            var first = l.First();
            l = l.Skip(1);
            return combiner(first, Accumulate(combiner, nullValue, l));
        }



        public static int SumOfSquares(IEnumerable<int> values) {

            return Accumulate((x, y) => (x * x) + y, 0, values);
        }

        static void Main(string[] args)
        {
            Program prog = new Program();
            Console.WriteLine(SumOfSquares(new List<int> { 1,2,3,4,5 }));
            Console.ReadKey();
        }
    }
}
