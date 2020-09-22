using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Vvedite den nedeli");
            string c = Console.ReadLine();
            den(c);
            Console.WriteLine("Vvedite x");
            double x = Convert.ToDouble(Console.ReadLine());
            x = FunctionY(x);
            Console.WriteLine("y = " + x);
            double x1, y1, x2, y2, x3, y3;
            Lewat_li(out x1, out y1, out x2, out y2, out x3, out y3);
            Console.ReadKey();
        }

        private static void Lewat_li(out double x1, out double y1, out double x2, out double y2, out double x3, out double y3)
        {
            Console.WriteLine("Vvedite x i y pervoi tochki");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite x i y vtoroi tochki");
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite x i y tretei tochki");
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            if (((x1 - x3) * (y2 - y3) - (x2 - x3) * (y1 - y3)) == 0)
                Console.WriteLine("Tochki na 1 pr9moi");
            else
            {
                double sc = (x2 - x1) * (y3 - y2) + (x3 - x2) * (y2 - y1);
                double ab = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
                double bc = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
                double u = Math.Acos(sc / ab / bc) * 180 / Math.PI;
                Console.WriteLine("Tochki ne na 1 pr9moi");
                Console.WriteLine("ygol = "+u);
            }
        }

        private static double FunctionY(double x)
        {
            
            if (x >= 1)
            {
                x = Math.Abs(x);
            }
            else
            {
                x = -(x / 3);
            }
            double y = Math.Log10(x + 0.5) + Math.Pow(Math.E, x) - Math.Pow(Math.E, (-x));
            return x;
        }

        private static void den(string c)
        {
            switch (c)
            {
                case "1":
                    Console.WriteLine("ponedelnik");
                    break;
                case "2":
                    Console.WriteLine("vtornik");
                    break;
                case "3":
                    Console.WriteLine("sreda");
                    break;
                case "4":
                    Console.WriteLine("4etverg");
                    break;
                case "5":
                    Console.WriteLine("p9|tnica");
                    break;
                case "6":
                    Console.WriteLine("sybbota");
                    break;
                case "7":
                    Console.WriteLine("voskresenie");
                    break;
                default:
                    Console.WriteLine("nevernii den");
                    break;
            }
        }
    }
}
