/// <file>
/// Velentr.Math\MathHelpers.cs
/// </file>
///
/// <copyright file="MathHelpers.cs" company="">
/// Copyright (c) 2022 Christian Webber. All rights reserved.
/// </copyright>
///
/// <summary>
/// Implements the mathematics helpers class.
/// </summary>
namespace Velentr.Math
{
    /// <summary>
    /// The mathematics helpers.
    /// </summary>
    public static class MathHelpers
    {
        /// <summary>
        /// Clamp the given value.
        /// </summary>
        ///
        /// <param name="value">    The value. </param>
        /// <param name="minimum">  (Optional) The minimum. </param>
        /// <param name="maximum">  (Optional) The maximum. </param>
        ///
        /// <returns>
        /// A double.
        /// </returns>
        public static int Clamp(int value, int minimum = int.MinValue, int maximum = int.MaxValue)
        {
            return value > maximum
                ? maximum
                : value < minimum
                    ? minimum
                    : value;
        }

        /// <summary>
        /// Clamp the given value.
        /// </summary>
        ///
        /// <param name="value">    The value. </param>
        /// <param name="minimum">  (Optional) The minimum. </param>
        /// <param name="maximum">  (Optional) The maximum. </param>
        ///
        /// <returns>
        /// A double.
        /// </returns>
        public static long Clamp(long value, long minimum = long.MinValue, long maximum = long.MaxValue)
        {
            return value > maximum
                ? maximum
                : value < minimum
                    ? minimum
                    : value;
        }

        /// <summary>
        /// Clamp the given value.
        /// </summary>
        ///
        /// <param name="value">    The value. </param>
        /// <param name="minimum">  (Optional) The minimum. </param>
        /// <param name="maximum">  (Optional) The maximum. </param>
        ///
        /// <returns>
        /// A double.
        /// </returns>
        public static float Clamp(float value, float minimum = float.MinValue, float maximum = float.MaxValue)
        {
            return value > maximum
                ? maximum
                : value < minimum
                    ? minimum
                    : value;
        }

        /// <summary>
        /// Clamp the given value.
        /// </summary>
        ///
        /// <param name="value">    The value. </param>
        /// <param name="minimum">  (Optional) The minimum. </param>
        /// <param name="maximum">  (Optional) The maximum. </param>
        ///
        /// <returns>
        /// A double.
        /// </returns>
        public static double Clamp(double value, double minimum = double.MinValue, double maximum = double.MaxValue)
        {
            return value > maximum
                ? maximum
                : value < minimum
                    ? minimum
                    : value;
        }
    }
}