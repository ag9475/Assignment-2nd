using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._7
{
    class Program
    {
        class B
        {
            public static void SM()
            {
                Console.WriteLine("In first class SM");
            }
            public virtual void VIM()
            {
                Console.WriteLine("In first class VIM");
            }
            public void NIM()
            {
                Console.WriteLine("In first class NIM");
            }
        }
        class C : B
        {
            public static void SM()
            {
                Console.WriteLine("In second class SM");
            }
            public override void VIM()
            {
                Console.WriteLine("In second class VIM");
            }
            public void NIM()
            {
                Console.WriteLine("In second class NIM");
            }
        }
        static void Main(string[] args)
        {
            B b = new B();
            C c = new C();
            b = c;
            B.SM();
            C.SM();
            b.VIM();
            b.NIM();
            c.VIM();
            c.VIM();
        }
    }
}

