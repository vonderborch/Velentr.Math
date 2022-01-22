using System;

namespace Velentr.Math.FixedPointMath.Precision4
{
    /// <summary>
    /// A fixed-point math struct that has precision to 4 decimal points
    /// </summary>
    public struct FPL4
    {

        public long RawValue;

        public const int Shift = 12;

        public const int Precision = 4;

        public const long OneLong = 1 << Shift;

        public const int OneInt = 1 << Shift;

        public static FPL4 OneFPL4 = FPL4.CreateFromLong(1);

        public static FPL4 MaxValue = FPL4.CreateFromLong(long.MaxValue, false);

        public static FPL4 MinValue = FPL4.CreateFromLong(long.MinValue, false);

        public static FPL4 CreateFromLong(long rawValue, bool valueHasDecimals = true)
        {
            FPL4 result;
            switch (valueHasDecimals)
            {
                case false:
                    result.RawValue = rawValue;
                    break;
                default:
                    result.RawValue = rawValue << Shift;
                    break;
            }
            return result;
        }

        public static FPL4 CreateFromDouble(double rawValue)
        {
            FPL4 result;
            if (rawValue <= int.MaxValue && rawValue >= int.MinValue)
                result.RawValue = (int)System.Math.Round(rawValue * (double)OneLong);
            else if (rawValue <= (long.MaxValue << Shift) && rawValue >= (long.MinValue << Shift))
                result.RawValue = (long)System.Math.Round(rawValue * (double)OneLong);
            else
                throw new InvalidCastException("Unable to convert double to FPL4, out-of-range!");
            return result;
        }

        public static FPL4 CreateFromFloat(float rawValue)
        {
            FPL4 result;
            if (rawValue <= int.MaxValue && rawValue >= int.MinValue)
                result.RawValue = (int)System.Math.Round(rawValue * (float)OneLong);
            else if (rawValue <= (long.MaxValue << Shift) && rawValue >= (long.MinValue << Shift))
                result.RawValue = (long)System.Math.Round(rawValue * (float)OneLong);
            else
                throw new InvalidCastException("Unable to convert float to FPL4, out-of-range!");
            return result;
        }

        public static FPL4 CreateFromIntParts(int preDecimal, int postDecimal)
        {
            FPL4 f = FPL4.CreateFromLong(preDecimal);
            if (postDecimal >= 0)
                f.RawValue += (FPL4.CreateFromDouble(postDecimal) / 1000).RawValue;

            return f;
        }

        public int ToInt()
        {
            return (int)(RawValue >> Shift);
        }

        public long ToLong()
        {
            return (long)(RawValue >> Shift);
        }

        public double ToDouble()
        {
            return (double)RawValue / OneLong;
        }

        public float ToFloat()
        {
            return (float)RawValue / OneLong;
        }

        public FPL4 Inverse
        {
            get { return FPL4.CreateFromLong(-this.RawValue, false); }
        }

        public static implicit operator int(FPL4 source)
        {
            return (int)(source.RawValue >> Shift);
        }

        public static implicit operator long(FPL4 source)
        {
            return (long)(source.RawValue >> Shift);
        }

        public static implicit operator float(FPL4 source)
        {
            return (float)(source.RawValue / (float)OneLong);
        }

        public static implicit operator double(FPL4 source)
        {
            return (double)(source.RawValue / (double)OneLong);
        }

        public static implicit operator string(FPL4 source)
        {
            return source.ToString();
        }

        public static implicit operator FPL4(int source)
        {
            return FPL4.CreateFromLong(source);
        }

        public static implicit operator FPL4(long source)
        {
            return FPL4.CreateFromLong(source);
        }

        public static implicit operator FPL4(float source)
        {
            return FPL4.CreateFromFloat(source);
        }

        public static implicit operator FPL4(double source)
        {
            return FPL4.CreateFromDouble(source);
        }

        public static FPL4 operator *(FPL4 left, FPL4 right)
        {
            FPL4 result;
            result.RawValue = (left.RawValue * right.RawValue) >> Shift;
            return result;
        }

        public static FPL4 operator *(FPL4 left, int right)
        {
            return left * (FPL4)right;
        }

        public static FPL4 operator *(int left, FPL4 right)
        {
            return (FPL4)left * right;
        }

        public static FPL4 operator *(FPL4 left, long right)
        {
            return left * (FPL4)right;
        }

        public static FPL4 operator *(long left, FPL4 right)
        {
            return (FPL4)left * right;
        }

        public static FPL4 operator *(FPL4 left, float right)
        {
            return left * (FPL4)right;
        }

        public static FPL4 operator *(float left, FPL4 right)
        {
            return (FPL4)left * right;
        }

        public static FPL4 operator *(FPL4 left, double right)
        {
            return left * (FPL4)right;
        }

        public static FPL4 operator *(double left, FPL4 right)
        {
            return (FPL4)left * right;
        }

        public static FPL4 operator /(FPL4 left, FPL4 right)
        {
            FPL4 result;
            result.RawValue = (left.RawValue << Shift) / right.RawValue;
            return result;
        }

        public static FPL4 operator /(FPL4 left, int right)
        {
            return left / (FPL4)right;
        }

        public static FPL4 operator /(int left, FPL4 right)
        {
            return (FPL4)left / right;
        }

        public static FPL4 operator /(FPL4 left, long right)
        {
            return left / (FPL4)right;
        }

        public static FPL4 operator /(long left, FPL4 right)
        {
            return (FPL4)left / right;
        }

        public static FPL4 operator /(FPL4 left, float right)
        {
            return left / (FPL4)right;
        }

        public static FPL4 operator /(float left, FPL4 right)
        {
            return (FPL4)left / right;
        }

        public static FPL4 operator /(FPL4 left, double right)
        {
            return left / (FPL4)right;
        }

        public static FPL4 operator /(double left, FPL4 right)
        {
            return (FPL4)left / right;
        }

        public static FPL4 operator %(FPL4 left, FPL4 right)
        {
            FPL4 result;
            result.RawValue = left.RawValue % right.RawValue;
            return result;
        }

        public static FPL4 operator %(FPL4 left, int right)
        {
            return left % (FPL4)right;
        }

        public static FPL4 operator %(int left, FPL4 right)
        {
            return (FPL4)left % right;
        }

        public static FPL4 operator %(FPL4 left, long right)
        {
            return left % (FPL4)right;
        }

        public static FPL4 operator %(long left, FPL4 right)
        {
            return (FPL4)left % right;
        }

        public static FPL4 operator %(FPL4 left, float right)
        {
            return left % (FPL4)right;
        }

        public static FPL4 operator %(float left, FPL4 right)
        {
            return (FPL4)left % right;
        }

        public static FPL4 operator %(FPL4 left, double right)
        {
            return left % (FPL4)right;
        }

        public static FPL4 operator %(double left, FPL4 right)
        {
            return (FPL4)left % right;
        }

        public static FPL4 operator +(FPL4 left, FPL4 right)
        {
            FPL4 result;
            result.RawValue = left.RawValue + right.RawValue;
            return result;
        }

        public static FPL4 operator +(FPL4 left, int right)
        {
            return left + (FPL4)right;
        }

        public static FPL4 operator +(int left, FPL4 right)
        {
            return (FPL4)left + right;
        }

        public static FPL4 operator +(FPL4 left, long right)
        {
            return left + (FPL4)right;
        }

        public static FPL4 operator +(long left, FPL4 right)
        {
            return (FPL4)left + right;
        }

        public static FPL4 operator +(FPL4 left, float right)
        {
            return left + (FPL4)right;
        }

        public static FPL4 operator +(float left, FPL4 right)
        {
            return (FPL4)left + right;
        }

        public static FPL4 operator +(FPL4 left, double right)
        {
            return left + (FPL4)right;
        }

        public static FPL4 operator +(double left, FPL4 right)
        {
            return (FPL4)left + right;
        }

        public static FPL4 operator -(FPL4 left, FPL4 right)
        {
            FPL4 result;
            result.RawValue = left.RawValue - right.RawValue;
            return result;
        }

        public static FPL4 operator -(FPL4 left, int right)
        {
            return left - (FPL4)right;
        }

        public static FPL4 operator -(int left, FPL4 right)
        {
            return (FPL4)left - right;
        }

        public static FPL4 operator -(FPL4 left, long right)
        {
            return left - (FPL4)right;
        }

        public static FPL4 operator -(long left, FPL4 right)
        {
            return (FPL4)left - right;
        }

        public static FPL4 operator -(FPL4 left, float right)
        {
            return left - (FPL4)right;
        }

        public static FPL4 operator -(float left, FPL4 right)
        {
            return (FPL4)left - right;
        }

        public static FPL4 operator -(FPL4 left, double right)
        {
            return left - (FPL4)right;
        }

        public static FPL4 operator -(double left, FPL4 right)
        {
            return (FPL4)left - right;
        }

        public static bool operator ==(FPL4 left, FPL4 right)
        {
            return left.RawValue == right.RawValue;
        }

        public static bool operator ==(FPL4 left, int right)
        {
            return left == (FPL4)right;
        }

        public static bool operator ==(int left, FPL4 right)
        {
            return (FPL4)left == right;
        }

        public static bool operator ==(FPL4 left, long right)
        {
            return left == (FPL4)right;
        }

        public static bool operator ==(long left, FPL4 right)
        {
            return (FPL4)left == right;
        }

        public static bool operator ==(FPL4 left, float right)
        {
            return left == (FPL4)right;
        }

        public static bool operator ==(float left, FPL4 right)
        {
            return (FPL4)left == right;
        }

        public static bool operator ==(FPL4 left, double right)
        {
            return left == (FPL4)right;
        }

        public static bool operator ==(double left, FPL4 right)
        {
            return (FPL4)left == right;
        }

        public static bool operator !=(FPL4 left, FPL4 right)
        {
            return left.RawValue != right.RawValue;
        }

        public static bool operator !=(FPL4 left, int right)
        {
            return left != (FPL4)right;
        }

        public static bool operator !=(int left, FPL4 right)
        {
            return (FPL4)left != right;
        }

        public static bool operator !=(FPL4 left, long right)
        {
            return left != (FPL4)right;
        }

        public static bool operator !=(long left, FPL4 right)
        {
            return (FPL4)left != right;
        }

        public static bool operator !=(FPL4 left, float right)
        {
            return left != (FPL4)right;
        }

        public static bool operator !=(float left, FPL4 right)
        {
            return (FPL4)left != right;
        }

        public static bool operator !=(FPL4 left, double right)
        {
            return left != (FPL4)right;
        }

        public static bool operator !=(double left, FPL4 right)
        {
            return (FPL4)left != right;
        }

        public static bool operator >=(FPL4 left, FPL4 right)
        {
            return left.RawValue >= right.RawValue;
        }

        public static bool operator >=(FPL4 left, int right)
        {
            return left >= (FPL4)right;
        }

        public static bool operator >=(int left, FPL4 right)
        {
            return (FPL4)left >= right;
        }

        public static bool operator >=(FPL4 left, long right)
        {
            return left >= (FPL4)right;
        }

        public static bool operator >=(long left, FPL4 right)
        {
            return (FPL4)left >= right;
        }

        public static bool operator >=(FPL4 left, float right)
        {
            return left >= (FPL4)right;
        }

        public static bool operator >=(float left, FPL4 right)
        {
            return (FPL4)left >= right;
        }

        public static bool operator >=(FPL4 left, double right)
        {
            return left >= (FPL4)right;
        }

        public static bool operator >=(double left, FPL4 right)
        {
            return (FPL4)left >= right;
        }

        public static bool operator <=(FPL4 left, FPL4 right)
        {
            return left.RawValue <= right.RawValue;
        }

        public static bool operator <=(FPL4 left, int right)
        {
            return left <= (FPL4)right;
        }

        public static bool operator <=(int left, FPL4 right)
        {
            return (FPL4)left <= right;
        }

        public static bool operator <=(FPL4 left, long right)
        {
            return left <= (FPL4)right;
        }

        public static bool operator <=(long left, FPL4 right)
        {
            return (FPL4)left <= right;
        }

        public static bool operator <=(FPL4 left, float right)
        {
            return left <= (FPL4)right;
        }

        public static bool operator <=(float left, FPL4 right)
        {
            return (FPL4)left <= right;
        }

        public static bool operator <=(FPL4 left, double right)
        {
            return left <= (FPL4)right;
        }

        public static bool operator <=(double left, FPL4 right)
        {
            return (FPL4)left <= right;
        }

        public static bool operator >(FPL4 left, FPL4 right)
        {
            return left.RawValue > right.RawValue;
        }

        public static bool operator >(FPL4 left, int right)
        {
            return left > (FPL4)right;
        }

        public static bool operator >(int left, FPL4 right)
        {
            return (FPL4)left > right;
        }

        public static bool operator >(FPL4 left, long right)
        {
            return left > (FPL4)right;
        }

        public static bool operator >(long left, FPL4 right)
        {
            return (FPL4)left > right;
        }

        public static bool operator >(FPL4 left, float right)
        {
            return left > (FPL4)right;
        }

        public static bool operator >(float left, FPL4 right)
        {
            return (FPL4)left > right;
        }

        public static bool operator >(FPL4 left, double right)
        {
            return left > (FPL4)right;
        }

        public static bool operator >(double left, FPL4 right)
        {
            return (FPL4)left > right;
        }

        public static bool operator <(FPL4 left, FPL4 right)
        {
            return left.RawValue < right.RawValue;
        }

        public static bool operator <(FPL4 left, int right)
        {
            return left < (FPL4)right;
        }

        public static bool operator <(int left, FPL4 right)
        {
            return (FPL4)left < right;
        }

        public static bool operator <(FPL4 left, long right)
        {
            return left < (FPL4)right;
        }

        public static bool operator <(long left, FPL4 right)
        {
            return (FPL4)left < right;
        }

        public static bool operator <(FPL4 left, float right)
        {
            return left < (FPL4)right;
        }

        public static bool operator <(float left, FPL4 right)
        {
            return (FPL4)left < right;
        }

        public static bool operator <(FPL4 left, double right)
        {
            return left < (FPL4)right;
        }

        public static bool operator <(double left, FPL4 right)
        {
            return (FPL4)left < right;
        }

        public static FPL4 operator <<(FPL4 left, int right)
        {
            return FPL4.CreateFromLong(left.RawValue << right, false);
        }

        public static FPL4 operator >>(FPL4 left, int right)
        {
            return FPL4.CreateFromLong(left.RawValue >> right, false);
        }

        public override bool Equals(object obj)
        {
            return obj is FPL4
                ? ((FPL4)obj).RawValue == this.RawValue
                : false;
        }

        public override int GetHashCode()
        {
            return RawValue.GetHashCode();
        }

        public override string ToString()
        {
            return $"{System.Math.Round(this.ToDouble(), Precision)}";
        }
    }
}
