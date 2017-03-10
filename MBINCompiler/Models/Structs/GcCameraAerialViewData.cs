namespace MBINCompiler.Models.Structs
{
    public class GcCameraAerialViewData : NMSTemplate
    {
        /* 0x000 */ public float Time;
		/* 0x004 */ public int AerialViewMode;
        public string[] AerialViewModeValues()
        {
            return new[] { "FaceDown", "FaceOut", "FaceDownThenOut" };
        }
		/* 0x008 */ public float TimeBack;
		/* 0x00C */ public float StartTime;
		/* 0x010 */ public float Pausetime;
		/* 0x014 */ public float Distance;
		/* 0x018 */ public int Stages;
		/* 0x01C */ public float SpeedLineDist;
		/* 0x020 */ public TkCurveType Curve;
		
		
    }
}
