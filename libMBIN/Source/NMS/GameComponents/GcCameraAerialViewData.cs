using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE5F643AA1DADF99, NameHash = 0x7AB4D686179F9F82)]
    public class GcCameraAerialViewData : NMSTemplate
    {
        // size: 0x4
        public enum AerialViewModeEnum : uint {
            FaceDown,
            FaceOut,
            FaceDownThenOut,
            FaceDownThenFocus,
        }
        /* 0x00 */ public AerialViewModeEnum AerialViewMode;
        /* 0x04 */ public float Distance;
        /* 0x08 */ public float FocusTargetOffsetDistance;
        /* 0x0C */ public float LookTime;
        /* 0x10 */ public float PauseTime;
        /* 0x14 */ public float SpeedLineDist;
        /* 0x18 */ public float StartTime;
        /* 0x1C */ public float TargetOffsetAngle;
        /* 0x20 */ public float Time;
        /* 0x24 */ public float TimeBack;
        /* 0x28 */ public TkCurveType Curve;
        /* 0x29 */ public TkCurveType CurveDown;
        /* 0x2A */ public bool IgnoreDistanceRestrictions;
        /* 0x2B */ public TkCurveType SlerpCurve;
    }
}
