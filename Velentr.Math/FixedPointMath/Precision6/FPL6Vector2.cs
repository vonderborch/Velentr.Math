namespace Velentr.Math.FixedPointMath.Precision6
{
    public struct FPL6Vector2
    {

        public FPL6 X;
        public FPL6 Y;

        public static FPL6Vector2 Create(FPL6 X, FPL6 Y)
        {
            FPL6Vector2 result;
            result.X = X;
            result.Y = Y;
            return result;
        }

        public static FPL6Vector2 Add(FPL6Vector2 inputA, FPL6Vector2 inputB)
        {
            FPL6Vector2 result;
            result.X = inputA.X + inputB.X;
            result.Y = inputA.Y + inputB.Y;
            return result;
        }

        public static FPL6Vector2 Subtract(FPL6Vector2 inputA, FPL6Vector2 inputB)
        {
            FPL6Vector2 result;
            result.X = inputA.X - inputB.X;
            result.Y = inputA.Y - inputB.Y;
            return result;
        }

        public static FPL6Vector2 Multiply(FPL6Vector2 inputA, FPL6Vector2 inputB)
        {
            FPL6Vector2 result;
            result.X = inputA.X * inputB.X;
            result.Y = inputA.Y * inputB.Y;
            return result;
        }

        public static FPL6Vector2 Divide(FPL6Vector2 inputA, FPL6Vector2 inputB)
        {
            FPL6Vector2 result;
            result.X = inputA.X / inputB.X;
            result.Y = inputA.Y / inputB.Y;
            return result;
        }
    }
}
