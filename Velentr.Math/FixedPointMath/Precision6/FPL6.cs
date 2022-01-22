using System;

namespace Velentr.Math.FixedPointMath.Precision6
{
    /// <summary>
    /// A fixed-point math struct that has precision to 4 decimal points
    /// </summary>
    public struct FPL6
    {

        public long RawValue;

        public const int Shift = 20;

        public const int Precision = 6;

        public const long OneLong = 1 << Shift;

        public const int OneInt = 1 << Shift;

        public static FPL6 OneFPL6 = FPL6.CreateFromLong(1);

        public static FPL6 MaxValue = FPL6.CreateFromLong(long.MaxValue, false);

        public static FPL6 MinValue = FPL6.CreateFromLong(long.MinValue, false);

        public static FPL6 CreateFromLong(long rawValue, bool valueHasDecimals = true)
        {
            FPL6 result;
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

        public static FPL6 CreateFromDouble(double rawValue)
        {
            FPL6 result;
            if (rawValue <= int.MaxValue && rawValue >= int.MinValue)
                result.RawValue = (int)System.Math.Round(rawValue * (double)OneLong);
            else if (rawValue <= (long.MaxValue << Shift) && rawValue >= (long.MinValue << Shift))
                result.RawValue = (long)System.Math.Round(rawValue * (double)OneLong);
            else
                throw new InvalidCastException("Unable to convert double to FPL6, out-of-range!");
            return result;
        }

        public static FPL6 CreateFromFloat(float rawValue)
        {
            FPL6 result;
            if (rawValue <= int.MaxValue && rawValue >= int.MinValue)
                result.RawValue = (int)System.Math.Round(rawValue * (float)OneLong);
            else if (rawValue <= (long.MaxValue << Shift) && rawValue >= (long.MinValue << Shift))
                result.RawValue = (long)System.Math.Round(rawValue * (float)OneLong);
            else
                throw new InvalidCastException("Unable to convert float to FPL6, out-of-range!");
            return result;
        }

        public static FPL6 CreateFromIntParts(int preDecimal, int postDecimal)
        {
            FPL6 f = FPL6.CreateFromLong(preDecimal);
            if (postDecimal >= 0)
                f.RawValue += (FPL6.CreateFromDouble(postDecimal) / 1000).RawValue;

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

        public FPL6 Inverse
        {
            get { return FPL6.CreateFromLong(-this.RawValue, false); }
        }

        public static implicit operator int(FPL6 source)
        {
            return (int)(source.RawValue >> Shift);
        }

        public static implicit operator long(FPL6 source)
        {
            return (long)(source.RawValue >> Shift);
        }

        public static implicit operator float(FPL6 source)
        {
            return (float)(source.RawValue / (float)OneLong);
        }

        public static implicit operator double(FPL6 source)
        {
            return (double)(source.RawValue / (double)OneLong);
        }

        public static implicit operator string(FPL6 source)
        {
            return source.ToString();
        }

        public static implicit operator FPL6(int source)
        {
            return FPL6.CreateFromLong(source);
        }

        public static implicit operator FPL6(long source)
        {
            return FPL6.CreateFromLong(source);
        }

        public static implicit operator FPL6(float source)
        {
            return FPL6.CreateFromFloat(source);
        }

        public static implicit operator FPL6(double source)
        {
            return FPL6.CreateFromDouble(source);
        }

        public static FPL6 operator *(FPL6 left, FPL6 right)
        {
            FPL6 result;
            result.RawValue = (left.RawValue * right.RawValue) >> Shift;
            return result;
        }

        public static FPL6 operator *(FPL6 left, int right)
        {
            return left * (FPL6)right;
        }

        public static FPL6 operator *(int left, FPL6 right)
        {
            return (FPL6)left * right;
        }

        public static FPL6 operator *(FPL6 left, long right)
        {
            return left * (FPL6)right;
        }

        public static FPL6 operator *(long left, FPL6 right)
        {
            return (FPL6)left * right;
        }

        public static FPL6 operator *(FPL6 left, float right)
        {
            return left * (FPL6)right;
        }

        public static FPL6 operator *(float left, FPL6 right)
        {
            return (FPL6)left * right;
        }

        public static FPL6 operator *(FPL6 left, double right)
        {
            return left * (FPL6)right;
        }

        public static FPL6 operator *(double left, FPL6 right)
        {
            return (FPL6)left * right;
        }

        public static FPL6 operator /(FPL6 left, FPL6 right)
        {
            FPL6 result;
            result.RawValue = (left.RawValue << Shift) / right.RawValue;
            return result;
        }

        public static FPL6 operator /(FPL6 left, int right)
        {
            return left / (FPL6)right;
        }

        public static FPL6 operator /(int left, FPL6 right)
        {
            return (FPL6)left / right;
        }

        public static FPL6 operator /(FPL6 left, long right)
        {
            return left / (FPL6)right;
        }

        public static FPL6 operator /(long left, FPL6 right)
        {
            return (FPL6)left / right;
        }

        public static FPL6 operator /(FPL6 left, float right)
        {
            return left / (FPL6)right;
        }

        public static FPL6 operator /(float left, FPL6 right)
        {
            return (FPL6)left / right;
        }

        public static FPL6 operator /(FPL6 left, double right)
        {
            return left / (FPL6)right;
        }

        public static FPL6 operator /(double left, FPL6 right)
        {
            return (FPL6)left / right;
        }

        public static FPL6 operator %(FPL6 left, FPL6 right)
        {
            FPL6 result;
            result.RawValue = left.RawValue % right.RawValue;
            return result;
        }

        public static FPL6 operator %(FPL6 left, int right)
        {
            return left % (FPL6)right;
        }

        public static FPL6 operator %(int left, FPL6 right)
        {
            return (FPL6)left % right;
        }

        public static FPL6 operator %(FPL6 left, long right)
        {
            return left % (FPL6)right;
        }

        public static FPL6 operator %(long left, FPL6 right)
        {
            return (FPL6)left % right;
        }

        public static FPL6 operator %(FPL6 left, float right)
        {
            return left % (FPL6)right;
        }

        public static FPL6 operator %(float left, FPL6 right)
        {
            return (FPL6)left % right;
        }

        public static FPL6 operator %(FPL6 left, double right)
        {
            return left % (FPL6)right;
        }

        public static FPL6 operator %(double left, FPL6 right)
        {
            return (FPL6)left % right;
        }

        public static FPL6 operator +(FPL6 left, FPL6 right)
        {
            FPL6 result;
            result.RawValue = left.RawValue + right.RawValue;
            return result;
        }

        public static FPL6 operator +(FPL6 left, int right)
        {
            return left + (FPL6)right;
        }

        public static FPL6 operator +(int left, FPL6 right)
        {
            return (FPL6)left + right;
        }

        public static FPL6 operator +(FPL6 left, long right)
        {
            return left + (FPL6)right;
        }

        public static FPL6 operator +(long left, FPL6 right)
        {
            return (FPL6)left + right;
        }

        public static FPL6 operator +(FPL6 left, float right)
        {
            return left + (FPL6)right;
        }

        public static FPL6 operator +(float left, FPL6 right)
        {
            return (FPL6)left + right;
        }

        public static FPL6 operator +(FPL6 left, double right)
        {
            return left + (FPL6)right;
        }

        public static FPL6 operator +(double left, FPL6 right)
        {
            return (FPL6)left + right;
        }

        public static FPL6 operator -(FPL6 left, FPL6 right)
        {
            FPL6 result;
            result.RawValue = left.RawValue - right.RawValue;
            return result;
        }

        public static FPL6 operator -(FPL6 left, int right)
        {
            return left - (FPL6)right;
        }

        public static FPL6 operator -(int left, FPL6 right)
        {
            return (FPL6)left - right;
        }

        public static FPL6 operator -(FPL6 left, long right)
        {
            return left - (FPL6)right;
        }

        public static FPL6 operator -(long left, FPL6 right)
        {
            return (FPL6)left - right;
        }

        public static FPL6 operator -(FPL6 left, float right)
        {
            return left - (FPL6)right;
        }

        public static FPL6 operator -(float left, FPL6 right)
        {
            return (FPL6)left - right;
        }

        public static FPL6 operator -(FPL6 left, double right)
        {
            return left - (FPL6)right;
        }

        public static FPL6 operator -(double left, FPL6 right)
        {
            return (FPL6)left - right;
        }

        public static bool operator ==(FPL6 left, FPL6 right)
        {
            return left.RawValue == right.RawValue;
        }

        public static bool operator ==(FPL6 left, int right)
        {
            return left == (FPL6)right;
        }

        public static bool operator ==(int left, FPL6 right)
        {
            return (FPL6)left == right;
        }

        public static bool operator ==(FPL6 left, long right)
        {
            return left == (FPL6)right;
        }

        public static bool operator ==(long left, FPL6 right)
        {
            return (FPL6)left == right;
        }

        public static bool operator ==(FPL6 left, float right)
        {
            return left == (FPL6)right;
        }

        public static bool operator ==(float left, FPL6 right)
        {
            return (FPL6)left == right;
        }

        public static bool operator ==(FPL6 left, double right)
        {
            return left == (FPL6)right;
        }

        public static bool operator ==(double left, FPL6 right)
        {
            return (FPL6)left == right;
        }

        public static bool operator !=(FPL6 left, FPL6 right)
        {
            return left.RawValue != right.RawValue;
        }

        public static bool operator !=(FPL6 left, int right)
        {
            return left != (FPL6)right;
        }

        public static bool operator !=(int left, FPL6 right)
        {
            return (FPL6)left != right;
        }

        public static bool operator !=(FPL6 left, long right)
        {
            return left != (FPL6)right;
        }

        public static bool operator !=(long left, FPL6 right)
        {
            return (FPL6)left != right;
        }

        public static bool operator !=(FPL6 left, float right)
        {
            return left != (FPL6)right;
        }

        public static bool operator !=(float left, FPL6 right)
        {
            return (FPL6)left != right;
        }

        public static bool operator !=(FPL6 left, double right)
        {
            return left != (FPL6)right;
        }

        public static bool operator !=(double left, FPL6 right)
        {
            return (FPL6)left != right;
        }

        public static bool operator >=(FPL6 left, FPL6 right)
        {
            return left.RawValue >= right.RawValue;
        }

        public static bool operator >=(FPL6 left, int right)
        {
            return left >= (FPL6)right;
        }

        public static bool operator >=(int left, FPL6 right)
        {
            return (FPL6)left >= right;
        }

        public static bool operator >=(FPL6 left, long right)
        {
            return left >= (FPL6)right;
        }

        public static bool operator >=(long left, FPL6 right)
        {
            return (FPL6)left >= right;
        }

        public static bool operator >=(FPL6 left, float right)
        {
            return left >= (FPL6)right;
        }

        public static bool operator >=(float left, FPL6 right)
        {
            return (FPL6)left >= right;
        }

        public static bool operator >=(FPL6 left, double right)
        {
            return left >= (FPL6)right;
        }

        public static bool operator >=(double left, FPL6 right)
        {
            return (FPL6)left >= right;
        }

        public static bool operator <=(FPL6 left, FPL6 right)
        {
            return left.RawValue <= right.RawValue;
        }

        public static bool operator <=(FPL6 left, int right)
        {
            return left <= (FPL6)right;
        }

        public static bool operator <=(int left, FPL6 right)
        {
            return (FPL6)left <= right;
        }

        public static bool operator <=(FPL6 left, long right)
        {
            return left <= (FPL6)right;
        }

        public static bool operator <=(long left, FPL6 right)
        {
            return (FPL6)left <= right;
        }

        public static bool operator <=(FPL6 left, float right)
        {
            return left <= (FPL6)right;
        }

        public static bool operator <=(float left, FPL6 right)
        {
            return (FPL6)left <= right;
        }

        public static bool operator <=(FPL6 left, double right)
        {
            return left <= (FPL6)right;
        }

        public static bool operator <=(double left, FPL6 right)
        {
            return (FPL6)left <= right;
        }

        public static bool operator >(FPL6 left, FPL6 right)
        {
            return left.RawValue > right.RawValue;
        }

        public static bool operator >(FPL6 left, int right)
        {
            return left > (FPL6)right;
        }

        public static bool operator >(int left, FPL6 right)
        {
            return (FPL6)left > right;
        }

        public static bool operator >(FPL6 left, long right)
        {
            return left > (FPL6)right;
        }

        public static bool operator >(long left, FPL6 right)
        {
            return (FPL6)left > right;
        }

        public static bool operator >(FPL6 left, float right)
        {
            return left > (FPL6)right;
        }

        public static bool operator >(float left, FPL6 right)
        {
            return (FPL6)left > right;
        }

        public static bool operator >(FPL6 left, double right)
        {
            return left > (FPL6)right;
        }

        public static bool operator >(double left, FPL6 right)
        {
            return (FPL6)left > right;
        }

        public static bool operator <(FPL6 left, FPL6 right)
        {
            return left.RawValue < right.RawValue;
        }

        public static bool operator <(FPL6 left, int right)
        {
            return left < (FPL6)right;
        }

        public static bool operator <(int left, FPL6 right)
        {
            return (FPL6)left < right;
        }

        public static bool operator <(FPL6 left, long right)
        {
            return left < (FPL6)right;
        }

        public static bool operator <(long left, FPL6 right)
        {
            return (FPL6)left < right;
        }

        public static bool operator <(FPL6 left, float right)
        {
            return left < (FPL6)right;
        }

        public static bool operator <(float left, FPL6 right)
        {
            return (FPL6)left < right;
        }

        public static bool operator <(FPL6 left, double right)
        {
            return left < (FPL6)right;
        }

        public static bool operator <(double left, FPL6 right)
        {
            return (FPL6)left < right;
        }

        public static FPL6 operator <<(FPL6 left, int right)
        {
            return FPL6.CreateFromLong(left.RawValue << right, false);
        }

        public static FPL6 operator >>(FPL6 left, int right)
        {
            return FPL6.CreateFromLong(left.RawValue >> right, false);
        }

        public override bool Equals(object obj)
        {
            return obj is FPL6
                ? ((FPL6)obj).RawValue == this.RawValue
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
