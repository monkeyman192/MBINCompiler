using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkCurveType : NMSTemplate
    {
        public int Curve;

        public string[] CurveValues()
        {

            return new[] { "Linear", "SmoothInOut", "FastInSlowOut", "BellSquared", "Squared", "Cubed",
                "Logarithmic", "SlowIn", "SlowOut", "ReallySlowOut", "SmootherStep", "SmoothFastInSlowOut",
                "SmoothSlowInFastOut", "EaseInSine", "EaseOutSine", "EaseInOutSine", "EaseInQuad",
                "EaseOutQuad", "EaseInOutQuad", "EaseInQuart", "EaseOutQuart", "EaseInOutQuart",
                "EaseInQuint", "EaseOutQuint", "EaseInOutQuint", "EaseInExpo", "EaseOutExpo",
                "EaseInOutExpo", "EaseInCirc", "EaseOutCirc", "EaseInOutCirc", "EaseInBack", "EaseOutBack",
                "EaseInOutBack", "EaseInElastic", "EaseOutElastic", "EaseInOutElastic", "EaseInBounce",
                "EaseOutBounce", "EaseInOutBounce" };
        }
    }
}
