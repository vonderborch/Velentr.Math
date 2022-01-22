﻿namespace Velentr.Math.FixedPointMath.Precision4
{
    public static class FPL4Math
    {
        public static FPL4 PI = FPL4.CreateFromDouble(System.Math.PI);
        public static FPL4 TwoPI = PI * 2;
        public static FPL4 PIOver180 = PI / 180;
        public static FPL4 HalfPI = PI / 2;
        public static FPL4 QuarterPI = PI / 4;
        public static FPL4 E = FPL4.CreateFromDouble(System.Math.E);

        public static FPL4 Sqrt(FPL4 input)
        {
            return System.Math.Sqrt(input);
        }

        public static FPL4 Sin(FPL4 input)
        {
            if (input == 0) return 0;
            if (input < 0) return Sin(input.Inverse).Inverse;
            if (input > PI) return Sin(input - PI).Inverse;
            if (input > QuarterPI) return Cos(HalfPI - input);

            var input2 = input * input;
            return input * (input2 / 6 * (input2 / 20 * (input2 / 42 * (input2 / 72 * (input2 / 110 * (input2 / 156 - 1) + 1) - 1) + 1) - 1) + 1);
        }

        public static FPL4 Cos(FPL4 input)
        {
            if (input == 0) return 1;
            if (input < 0) return Cos(input.Inverse);
            if (input > PI) return Sin(input - PI).Inverse;
            if (input > QuarterPI) return Sin(HalfPI - input);

            var input2 = input * input;
            return input2 / 2 * (input2 / 12 * (input2 / 30 * (input2 / 56 * (input2 / 90 * (input2 / 132 - 1) + 1) - 1) + 1) - 1) + 1;
        }

        public static FPL4 Tan(FPL4 input)
        {
            return Sin(input) / Cos(input);
        }

        public static FPL4 Asin(FPL4 input)
        {
            return System.Math.Asin(input);
        }

        public static FPL4 Acos(FPL4 input)
        {
            return System.Math.Acos(input);
        }

        public static FPL4 Atan(FPL4 input)
        {
            return System.Math.Atan(input);
        }

        public static FPL4 Atan2(FPL4 inputA, FPL4 inputB)
        {
            return System.Math.Atan2(inputA, inputB);
        }

        public static FPL4 Abs(FPL4 input)
        {
            return input < 0
                ? input.Inverse
                : input;
        }

        public static FPL4 Pow(FPL4 input, int pow)
        {
            if (pow == 0) return 1;

            var isNegative = pow < 0;
            if (isNegative) pow = -pow;

            for (var i = 0; i < pow; i++)
                input *= input;

            return isNegative
                ? 1 / input
                : input;
        }

        private static FPL4 Round(FPL4 input, int decimals = 0)
        {
            decimals = Clamp(decimals, 0, 4);
            return System.Math.Round((double)input, Clamp(decimals, 0, 4));
        }

        private static FPL4 Ceiling(FPL4 input, int decimals = 0)
        {
            return System.Math.Ceiling((double)input);
        }

        private static FPL4 Floor(FPL4 input, int decimals = 0)
        {
            return System.Math.Floor((double)input);
        }

        private static FPL4 Clamp(FPL4 input, FPL4 minimum, FPL4 maximum)
        {
            return input > maximum
                ? maximum
                : input < minimum
                    ? minimum
                    : input;
        }

        public static FPL4 Log(FPL4 input, int newBase)
        {
            return System.Math.Log(input, newBase);
        }

        public static FPL4 LogE(FPL4 input)
        {
            return System.Math.Log(input);
        }

        public static FPL4 Log10(FPL4 input)
        {
            return System.Math.Log10(input);
        }
    }
}
