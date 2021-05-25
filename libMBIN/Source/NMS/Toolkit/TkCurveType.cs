using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x1A6FF072DB629119, NameHash = 0x48849654049904EA)]
    public class TkCurveType : NMSTemplate
    {
        // size: 0x28
        public enum CurveEnum {
            Linear, SmoothInOut, FastInSlowOut, BellSquared, Squared, Cubed, Logarithmic, SlowIn, SlowOut, ReallySlowOut,
            SmootherStep, SmoothFastInSlowOut, SmoothSlowInFastOut, EaseInSine, EaseOutSine, EaseInOutSine, EaseInQuad, EaseOutQuad, EaseInOutQuad, EaseInQuart,
            EaseOutQuart, EaseInOutQuart, EaseInQuint, EaseOutQuint, EaseInOutQuint, EaseInExpo, EaseOutExpo, EaseInOutExpo, EaseInCirc, EaseOutCirc,
            EaseInOutCirc, EaseInBack, EaseOutBack, EaseInOutBack, EaseInElastic, EaseOutElastic, EaseInOutElastic, EaseInBounce, EaseOutBounce, EaseInOutBounce
        }
        public CurveEnum Curve;
    }
}