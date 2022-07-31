using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2_1
{
    class Program
    {
        public struct Pair<T , U> {
        public readonly T Fst;
        public readonly U Snd;
        public Pair(T fst, U snd)
        {
            this.Fst = fst;
            this.Snd = snd;
        }
        public Pair<int , string> swap(Pair<string, int> s)
            {
                Pair<int, string> s1 = new Pair<int, string>(s.Snd, s.Fst);
                return s1;
            }
        public override String ToString()
        {
            return "("+ Fst + " , " + Snd + ")";
        }
    }
    static void Main(string[] args)
        {
            Pair<string, int> a = new Pair<string, int> ( "a", 1 );
            Pair<string, int> a1 = new Pair<string, int>("b", 2);
            Pair<string, int> a2 = new Pair<string, int>("c", 3);
            Pair<string, int> a3 = new Pair<string, int>("d", 4);
            Pair<int, int> a4 = new Pair<int, int>(2, 5);
            Pair<string, double> b = new Pair<string, double>("abc", 5.8);
            Pair<string, int>[] Grades = new Pair<string, int>[5];
            Grades[0] = a;
            Grades[1] = a1;
            Grades[2] = a2;
            Pair<Pair<int, int>, string> Appointment = new Pair<Pair<int, int>, string>(a4 , "abc");
            foreach(Pair<string,int> i in Grades)
            {
                Console.WriteLine(i);
            }
        }
    }
}
