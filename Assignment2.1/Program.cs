using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_8
{
    class Program
    {
        public delegate void IntAction(int a) ;
        public static void PrintInt(int a)
        {
                Console.WriteLine(a);                  
        }
        IntAction Act = new IntAction(PrintInt);
        public static void perform(IntAction Act , params int[] list)
        {
            Act(42);
            foreach(int i in list)
            {
                Act(i);
            }
        }
        static void Main(string[] args)
        {
            perform(PrintInt,5,6,7,8);
        }
    }
}