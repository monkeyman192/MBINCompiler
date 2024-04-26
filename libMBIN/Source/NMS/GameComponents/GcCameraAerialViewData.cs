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
        [NMS(Index = 1)]
        /* 0x00 */ public AerialViewModeEnum AerialViewMode;
        [NMS(Index = 6)]
        /* 0x04 */ public float Distance;
        [NMS(Index = 9)]
        /* 0x08 */ public float FocusTargetOffsetDistance;
        [NMS(Index = 5)]
        /* 0x0C */ public float LookTime;
        [NMS(Index = 4)]
        /* 0x10 */ public float PauseTime;
        [NMS(Index = 10)]
        /* 0x14 */ public float SpeedLineDist;
        [NMS(Index = 3)]
        /* 0x18 */ public float StartTime;
        [NMS(Index = 8)]
        /* 0x1C */ public float TargetOffsetAngle;
        [NMS(Index = 0)]
        /* 0x20 */ public float Time;
        [NMS(Index = 2)]
        /* 0x24 */ public float TimeBack;
        [NMS(Index = 11)]
        /* 0x28 */ public TkCurveType Curve;
        [NMS(Index = 12)]
        /* 0x29 */ public TkCurveType CurveDown;
        [NMS(Index = 7)]
        /* 0x2A */ public bool IgnoreDistanceRestrictions;
        [NMS(Index = 13)]
        /* 0x2B */ public TkCurveType SlerpCurve;
    }
}
