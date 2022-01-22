using System;
using Velentr.Math.FixedPointMath.Precision4;
using Velentr.Math.FixedPointMath.Precision6;

namespace Velentr.Math.DevEnv
{
    class Program
    {
        static void Main(string[] args)
         {
            FPL4 a1 = 3.501;
            FPL6 a2 = 3.5012;
            FPL6 a3 = 3.50125;
            FPL6 a4 = 3.5012572;
            var b1 = (FPL4)3.501;
            var b2 = (FPL6)3.5012;
            var b3 = (FPL6)3.50125;
            var b4 = (FPL6)3.5012573;

            var x = FPL4Math.Sin(a1);
            var x2 = FPL4Math.Asin(x);
            var y = System.Math.Sin(a1);
            var y2 = System.Math.Asin(x);

            var z = System.Math.Round(y, FPL4.Precision);
            var z2 = System.Math.Round(y2, FPL4.Precision);

            if (true) ;
        }
    }
}
