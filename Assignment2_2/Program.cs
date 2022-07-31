using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_2
{
    class Program
    {
        public delegate void Action<T>(T a);
        static void Perform <T>(Action<T> act , params T[] arr)
        {
            foreach(var a in arr)
            {
                act(a);
            }
        }
        public static int GreaterCount(List<double> list, double min)
        {
            int count = 0;
            foreach (double d in list)
            {
                if (d >= min)
                {
                    count += 1;
                }
                else { continue; }
            }
            return count;
        }
         public static int  GreaterCount <T>(IEnumerable<T> eble, T min)
        {
            int count = 0;
            int i1 = Convert.ToInt32(min);
            foreach (T d in eble)
            {
                int i = Convert.ToInt32(eble);              
                if (i >= i1)
                {
                    count += 1;
                }
            }
            return count;
        }
    static void Main(string[] args)
        {
            List<double> temperature = new List<double>(5);
            temperature.Add(26);
            temperature.Add(32);
            temperature.Add(15);
            temperature.Add(47);
            temperature.Add(25);
            IEnumerable<double> temperature1 =  temperature;
            Console.WriteLine( Program.GreaterCount(temperature1, 25));
            double[] d = new double[5] { 5, 2, 3, 4, 5 };
            Console.WriteLine( Program.GreaterCount(d, 2));
            //foreach(double d in temperature)
            //{
            //    if(d >= 25)
            //    {
            //        Console.WriteLine(d);
            //    }

            //}
        }
    }
}
