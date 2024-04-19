using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA1292A1ED2EC32C9, NameHash = 0x4453C3D28B780FD8)]
    public class GcHUDEffectRewardData : NMSTemplate
    {
        /* 0x00 */ public Colour BoxColourEnd;
        /* 0x10 */ public Colour BoxColourStart;
        /* 0x20 */ public Vector2f BoxSizeEnd;
        /* 0x28 */ public Vector2f BoxSizeStart;
        /* 0x30 */ public float BoxAnimTime;
        /* 0x34 */ public float BoxAnimTimeBetweenBoxes;
        /* 0x38 */ public float BoxRotate;
        /* 0x3C */ public float BoxThicknessEnd;
        /* 0x40 */ public float BoxThicknessStart;
        /* 0x44 */ public int NumBoxes;
        /* 0x48 */ public TkCurveType BoxAnimTimeCurve;
    }
}
