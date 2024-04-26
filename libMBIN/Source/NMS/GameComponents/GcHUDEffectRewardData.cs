using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA1292A1ED2EC32C9, NameHash = 0x4453C3D28B780FD8)]
    public class GcHUDEffectRewardData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public Colour BoxColourEnd;
        [NMS(Index = 7)]
        /* 0x10 */ public Colour BoxColourStart;
        [NMS(Index = 8)]
        /* 0x20 */ public Vector2f BoxSizeEnd;
        [NMS(Index = 5)]
        /* 0x28 */ public Vector2f BoxSizeStart;
        [NMS(Index = 1)]
        /* 0x30 */ public float BoxAnimTime;
        [NMS(Index = 3)]
        /* 0x34 */ public float BoxAnimTimeBetweenBoxes;
        [NMS(Index = 2)]
        /* 0x38 */ public float BoxRotate;
        [NMS(Index = 10)]
        /* 0x3C */ public float BoxThicknessEnd;
        [NMS(Index = 6)]
        /* 0x40 */ public float BoxThicknessStart;
        [NMS(Index = 0)]
        /* 0x44 */ public int NumBoxes;
        [NMS(Index = 4)]
        /* 0x48 */ public TkCurveType BoxAnimTimeCurve;
    }
}
