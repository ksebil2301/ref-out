using System;

namespace ref_out
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 10;
            double y = 20;
            double total1 = Total1(x, ref y);
            Console.WriteLine(total1);

            double z = 10;
            double t = 20;
            double isk;    // iskonto bellidir.
            double total2 = Total2(z, t, out isk);
            Console.WriteLine(total2);
        }
        static double Total1(double x, ref double y)
        {
            return ((x + y) * 0.18) +x +y;
        }
        static double Total2(double z, double t, out double isk)
        {
            isk = 0.9;// özel iskontoyu belirlemek gerekir. bu yüzden dışarda değer verilmesine gerek yoktur.
            return z+t+((z + (t * isk)) * 0.18);
        }
    }
}
