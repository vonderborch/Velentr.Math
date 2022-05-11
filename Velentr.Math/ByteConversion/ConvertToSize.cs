namespace Velentr.Math.ByteConversion
{
    public static class ConvertToSize
    {
        public static double ToSizeUnit(this long value, SizeUnits unit, short baseAmount = 1024)
        {
            return value / System.Math.Pow(baseAmount, (long) unit);
        }
    }
}
