namespace Velentr.Math.FixedPointMath.Precision4
{

    public struct FPL4Vector3
    {
        public FPL4 X;
        public FPL4 Y;
        public FPL4 Z;

        public FPL4Vector3(FPL4 X, FPL4 Y, FPL4 Z)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
        }

        public static FPL4Vector3 Create(FPL4 X, FPL4 Y, FPL4 Z)
        {
            FPL4Vector3 result;
            result.X = X;
            result.Y = Y;
            result.Z = Z;
            return result;
        }

        public static FPL4Vector3 Add(FPL4Vector3 inputA, FPL4Vector3 inputB)
        {
            FPL4Vector3 result;
            result.X = inputA.X + inputB.X;
            result.Y = inputA.Y + inputB.Y;
            result.Z = inputA.Z + inputB.Z;
            return result;
        }

        public static FPL4Vector3 Subtract(FPL4Vector3 inputA, FPL4Vector3 inputB)
        {
            FPL4Vector3 result;
            result.X = inputA.X - inputB.X;
            result.Y = inputA.Y - inputB.Y;
            result.Z = inputA.Z - inputB.Z;
            return result;
        }

        public static FPL4Vector3 Multiply(FPL4Vector3 inputA, FPL4Vector3 inputB)
        {
            FPL4Vector3 result;
            result.X = inputA.X * inputB.X;
            result.Y = inputA.Y * inputB.Y;
            result.Z = inputA.Z * inputB.Z;
            return result;
        }

        public static FPL4Vector3 Divide(FPL4Vector3 inputA, FPL4Vector3 inputB)
        {
            FPL4Vector3 result;
            result.X = inputA.X / inputB.X;
            result.Y = inputA.Y / inputB.Y;
            result.Z = inputA.Z / inputB.Z;
            return result;
        }
    }
}
