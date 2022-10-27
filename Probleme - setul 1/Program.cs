using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probleme___setul_1
{
    internal class Program
    {
        static void p1()
        {
            string[] t = Console.ReadLine().Split(' ');
            float a = float.Parse(t[0]);
            float b = float.Parse(t[1]);
            float x;
            x = -b / a;
            Console.WriteLine("X este egal cu:");
            Console.Write(x);

        }
        static void p2()
        {
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            int c = int.Parse(t[2]);
            float delta = b * b - (4 * a * c);
            Console.WriteLine("delta="+delta);
            if (delta >= 0)
            {
                double raddelta = Math.Sqrt(delta);
                double x1 = (-b + raddelta) / (2 * a);
                double x2 = (-b - raddelta) / (2 * a);
                Console.WriteLine("x1=" + x1 + ";");
                Console.Write("x2=" + x2);
            }
            if (delta < 0)
            {
                delta = -delta;
                double raddelta = Math.Sqrt(delta);
                Console.WriteLine("x1=(" + -b + "+i" + raddelta + ")/" + 2 * a);
                Console.WriteLine("x2=(" + -b + "-i" + raddelta + ")/" + 2 * a);
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul problemei:");
            int nrp = int.Parse(Console.ReadLine());
            if (nrp == 1)
            {
                Console.WriteLine("Problema " + nrp);
                p1();
            }
            if(nrp == 2)
            {
                Console.WriteLine("Problema " + nrp);
                p2();
            }
            if (nrp == 3)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 4)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 5)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 6)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 7)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 8)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 9)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 10)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 11)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 12)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 13)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 14)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 15)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 16)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 17)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 18)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 19)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 20)
            {
                Console.WriteLine("Problema " + nrp);
            }
            if (nrp == 21)
            {
                Console.WriteLine("Problema " + nrp);
            }
            Console.ReadKey();
        }
    }
}
