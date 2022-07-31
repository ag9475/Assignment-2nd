using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2._2
{
    class Program
    {
        public struct TestTime
        {
            public int minutes;
            private readonly int hours;
            public TestTime(int hh, int mm)
            {
                this.minutes =  mm;
                this.hours = hh;
            }
            public static TestTime operator +(TestTime t1, TestTime t2)
            {
                TestTime temp = new TestTime((t1.hours + t2.hours), (t1.minutes + t2.minutes));
                return temp;
            }
            public static TestTime operator -(TestTime t1, TestTime t2)
            {
                TestTime temp = new TestTime((t1.hours - t2.hours), (t1.minutes - t2.minutes));
                return temp;
            }
            public static explicit operator int(TestTime T1)
            {
                int t = (T1.hours - 12) * 60 + T1.minutes;
                return t;
            }
            public static explicit operator TestTime(int t)
            {
                TestTime tt = new TestTime(((t / 60) * 60) , (t % 60));
                return tt;
            }
            public int Minutes()
            {
                return minutes;
            }
            public int Hours()
            {
                return hours;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter time as : hh,mm");
            string t = Console.ReadLine();
            int h = Convert.ToInt32(t.Substring(0, 2));
            int m = Convert.ToInt32(t.Substring(3, 2));
            TestTime T = new TestTime(h, m);
            TestTime T1 = new TestTime(10, 23);
            Console.WriteLine("Hours = {0} and Minutes = {1}",(T + new TestTime(1,2)).Hours(), (T + new TestTime(1, 2)).Minutes());
            TestTime t2 = T1;
            T1.minutes = 100;
            Console.WriteLine("T1 : {0} T2 : {1}", T1.minutes, t2.minutes);
            TestTime t3 = new TestTime(10, 54);
            int b = (int)t3;
            TestTime t4 = t2 + (TestTime)23;
            
        }
    }
}