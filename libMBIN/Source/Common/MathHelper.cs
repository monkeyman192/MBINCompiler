namespace libMBIN.Source.Common
{
    internal static class MathHelper
    {
        /// <summary>
        /// Clamps a value to be equal to or between the minimum and maximum.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <returns></returns>
        public static int Clamp(int value, int minimum, int maximum)
        {
            if (value < minimum)
                value = minimum;
            if (value > maximum)
                value = maximum;

            return value;
        }

        /// <summary>
        /// Clamps a value to be equal to or between the minimum and maximum.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <returns></returns>
        public static float Clamp(float value, float minimum, float maximum)
        {
            if (value < minimum)
                value = minimum;
            if (value > maximum)
                value = maximum;

            return value;
        }

        /// <summary>
        /// Clamps a value to be equal to or between the minimum and maximum.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <returns></returns>
        public static double Clamp(double value, double minimum, double maximum)
        {
            if (value < minimum)
                value = minimum;
            if (value > maximum)
                value = maximum;

            return value;
        }
    }
}
