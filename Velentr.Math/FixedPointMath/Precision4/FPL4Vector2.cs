namespace Velentr.Math.FixedPointMath.Precision4
{
    public struct FPL4Vector2
    {

        public FPL4 X;
        public FPL4 Y;

        public FPL4Vector2(FPL4 X, FPL4 Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public static FPL4Vector2 Create(FPL4 X, FPL4 Y)
        {
            FPL4Vector2 result;
            result.X = X;
            result.Y = Y;
            return result;
        }

        public static FPL4Vector2 Add(FPL4Vector2 inputA, FPL4Vector2 inputB)
        {
            FPL4Vector2 result;
            result.X = inputA.X + inputB.X;
            result.Y = inputA.Y + inputB.Y;
            return result;
        }

        public static FPL4Vector2 Subtract(FPL4Vector2 inputA, FPL4Vector2 inputB)
        {
            FPL4Vector2 result;
            result.X = inputA.X - inputB.X;
            result.Y = inputA.Y - inputB.Y;
            return result;
        }

        public static FPL4Vector2 Multiply(FPL4Vector2 inputA, FPL4Vector2 inputB)
        {
            FPL4Vector2 result;
            result.X = inputA.X * inputB.X;
            result.Y = inputA.Y * inputB.Y;
            return result;
        }

        public static FPL4Vector2 Divide(FPL4Vector2 inputA, FPL4Vector2 inputB)
        {
            FPL4Vector2 result;
            result.X = inputA.X / inputB.X;
            result.Y = inputA.Y / inputB.Y;
            return result;
        }
    }
}
