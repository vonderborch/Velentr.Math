namespace Velentr.Math.FixedPointMath.Precision6
{

    public struct FPL6Vector3
    {
        public FPL6 X;
        public FPL6 Y;
        public FPL6 Z;

        public static FPL6Vector3 Create(FPL6 X, FPL6 Y, FPL6 Z)
        {
            FPL6Vector3 result;
            result.X = X;
            result.Y = Y;
            result.Z = Z;
            return result;
        }

        public static FPL6Vector3 Add(FPL6Vector3 inputA, FPL6Vector3 inputB)
        {
            FPL6Vector3 result;
            result.X = inputA.X + inputB.X;
            result.Y = inputA.Y + inputB.Y;
            result.Z = inputA.Z + inputB.Z;
            return result;
        }

        public static FPL6Vector3 Subtract(FPL6Vector3 inputA, FPL6Vector3 inputB)
        {
            FPL6Vector3 result;
            result.X = inputA.X - inputB.X;
            result.Y = inputA.Y - inputB.Y;
            result.Z = inputA.Z - inputB.Z;
            return result;
        }

        public static FPL6Vector3 Multiply(FPL6Vector3 inputA, FPL6Vector3 inputB)
        {
            FPL6Vector3 result;
            result.X = inputA.X * inputB.X;
            result.Y = inputA.Y * inputB.Y;
            result.Z = inputA.Z * inputB.Z;
            return result;
        }

        public static FPL6Vector3 Divide(FPL6Vector3 inputA, FPL6Vector3 inputB)
        {
            FPL6Vector3 result;
            result.X = inputA.X / inputB.X;
            result.Y = inputA.Y / inputB.Y;
            result.Z = inputA.Z / inputB.Z;
            return result;
        }
    }
}
