using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    class Program
    {
        public static int count(IEnumerable<double?> a)
        {
            int ctr = 0;
            foreach(double? i in a)
            {
                if(i != null)
                {
                    ctr += 1;
                }
            }
            return ctr;
        }
        public static double Min(IEnumerable<double?> a)
        {
            var result = a.OrderByDescending(x => x).First();
            return (double)result ;
        }
        public static double? avg(IEnumerable<double?> a)
        {
            double? d = 0;
            int len = 0;
            foreach (double? i in a)
            {
                if (i != null)
                {
                    d += i;
                    len += 1;
                }
            }
            return d/len;
        }
        public static double? sum(IEnumerable<double?> a)
        {
            double? d = 0;
            foreach (double? i in a)
            {
                if (i != null)
                {
                    d += i;
                }
            }
            return d;
        }
        static void Main(string[] args)
        {
            double?[] arr = new double?[5] { 3, 6, null, 1, 8 };
            Console.WriteLine(avg(arr));
            //Console.WriteLine(sum(arr));
            //Console.WriteLine(Min(arr));
            //Console.WriteLine(count(arr));
        }
    }
}
