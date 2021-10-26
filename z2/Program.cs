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
            double v, s;
            GetParam(x, out v, out s);
            Console.WriteLine("Объем куба равен {0}", v);
            Console.WriteLine("Площадь всех граней составляет {0}", s);
            Console.ReadKey();
        }
        static void GetParam(double a, out double v, out double s)
        {
            v = Math.Round(a * a * a, 2);
            s = Math.Round((a * a) * 6, 2);
        }
    }
}
