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
        // subprograme ajutatoare
        static bool prim(int n)
        {
            if (n < 2)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            for (int i = 3; i * i < n; i += 2)
                if (n % i == 0)
                    return false;
            return true;
        }
        //final subprograme
        //probleme
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
        static void p3()
        {
            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int k = int.Parse(t[1]);
            if (n % k == 0)
                Console.WriteLine(n + " se divide cu " + k);
            else
                Console.WriteLine(n + " nu se divide cu " + k);
        }
        static void p4()
        {
            int y = int.Parse(Console.ReadLine());
            if (y % 4 == 0)
                Console.WriteLine(y + " este an bisect");
            else
                Console.WriteLine(y + " nu este an bisect");
        }
        static void p5()
        {
            string[] t = Console.ReadLine().Split(' ');
            int n = int.Parse(t[0]);
            int k = int.Parse(t[1]);
            int p=0;
            for(int i = 0; i < k; i++)
            {
                p = n % 10;
                n /= 10;
            }
            Console.WriteLine("a " + k + "-a cifra de la sfarsitul numarului este " + p);

        }
        static void p6()
        {
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            int c = int.Parse(t[2]);
            int maxim = a;
            if (b > maxim)
                maxim = b;
            if (c > maxim)
                maxim = c;
            if (a + b + c - maxim > maxim)
                Console.WriteLine("numerele pot fi lungimile laturilor unui triunghi");
            else
                Console.WriteLine("numerele nu pot fi lungimile laturilor unui triunghi");
        }
        static void p7()
        {
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            int aux = a;
            a = b;
            b = aux;
            Console.WriteLine("a=" + a + " b=" + b);
        }
        static void p8()
        {
            string[] t = Console.ReadLine().Split(' ');
            int a = int.Parse(t[0]);
            int b = int.Parse(t[1]);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a=" + a + " b=" + b);
        }
        static void p9()
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    Console.Write(i + " ");
            }
        }
        static void p10()
        {
            int n = int.Parse(Console.ReadLine());
            if (prim(n))
                Console.WriteLine(n + " este numar prim");
            else
                Console.WriteLine(n + " nu este numar prim");

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
                p3();
            }
            if (nrp == 4)
            {
                Console.WriteLine("Problema " + nrp);
                p4();
            }
            if (nrp == 5)
            {
                Console.WriteLine("Problema " + nrp);
                p5();
            }
            if (nrp == 6)
            {
                Console.WriteLine("Problema " + nrp);
                p6();
            }
            if (nrp == 7)
            {
                Console.WriteLine("Problema " + nrp);
                p7();
            }
            if (nrp == 8)
            {
                Console.WriteLine("Problema " + nrp);
                p8();
            }
            if (nrp == 9)
            {
                Console.WriteLine("Problema " + nrp);
                p9();
            }
            if (nrp == 10)
            {
                Console.WriteLine("Problema " + nrp);
                p10();
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
