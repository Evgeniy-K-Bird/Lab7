using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите три стороны первого треугольника:");
            double a1 = Convert.ToDouble(Console.ReadLine());
            double b1 = Convert.ToDouble(Console.ReadLine());
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите три стороны второго треугольника:");
            double a2 = Convert.ToDouble(Console.ReadLine());
            double b2 = Convert.ToDouble(Console.ReadLine());
            double c2 = Convert.ToDouble(Console.ReadLine());
            double s1 = CalS(a1, b1, c1);
            double s2 = CalS(a2, b2, c2);
            if (s1==s2)
            {
             Console.WriteLine("Площадь треугольников равна, S={0}", s1);
            }
            else
                if (s1 > s2)
            {
                Console.WriteLine("Площадь первого треугольника больше, S={0}", s1);
            }
            else
            {
                Console.WriteLine("Площадь  второго треугольника больше, S={0}", s2);
            }
            Console.ReadKey();
        }
        static double CalS(double a, double b, double c)
        {
            double ab = a;
            double ac = b;
            double bc = c;
            double p = (ab + ac + bc) / 2;
            double s = Math.Sqrt(p * (p - ab) * (p - ac) * (p - bc));
            s = Math.Round(s, 2);
            return s;
        }
    }
}
