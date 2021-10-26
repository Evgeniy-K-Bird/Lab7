using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длинну ребра куба:");
            double x = Convert.ToDouble(Console.ReadLine());
            double v = CalV(x);
            double s = CalS(x);
            Console.WriteLine("Объем куба равен {0}", v);
            Console.WriteLine("Площадь всех граней составляет {0}", s);
            Console.ReadKey();
        }
        static double CalV(double a)
        {
            double v = a * a * a;
            v = Math.Round(v, 2);
            return v;
        }
        static double CalS(double a)
        {
            double s = Math.Round((a * a) * 6, 2);
            return s;
        }
    }
}
