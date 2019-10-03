using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x135475BEC6A4BDE9, NameHash = 0x7AB4D686179F9F82)]
    public class GcCameraAerialViewData : NMSTemplate
    {
        /* 0x000 */ public float Time;
		public enum AerialViewModeEnum { FaceDown, FaceOut, FaceDownThenOut }
		public AerialViewModeEnum AerialViewMode;
		/* 0x008 */ public float TimeBack;
		/* 0x00C */ public float StartTime;
		/* 0x010 */ public float PauseTime;
		/* 0x014 */ public float Distance;
        /* 0x018 */ public float TargetOffsetAngle;
		/* 0x01C */ public int Stages;
		/* 0x020 */ public float SpeedLineDist;
		/* 0x024 */ public TkCurveType Curve;
        /* 0x028 */ public TkCurveType CurveDown;
        /* 0x02C */ public TkCurveType SlerpCurve;
		
		
    }
}
