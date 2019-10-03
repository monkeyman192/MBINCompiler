using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xDB92FE50460E2D1F, NameHash = 0x6BA92648DD779F47)]
    public class GcHUDEffectRewardData : NMSTemplate
    {
        /* 0x0000 */ public int NumBoxes;
        /* 0x0004 */ public float BoxAnimTime;
        /* 0x0008 */ public float BoxRotate;
        /* 0x000C */ public float BoxAnimTimeBetweenBoxes;
        /* 0x0010 */ public TkCurveType BoxAnimTimeCurve;
        /* 0x0014 */ public Vector2f BoxSizeStart;
        /* 0x001C */ public float BoxThicknessStart;
        /* 0x0020 */ public Colour BoxColourStart;
        /* 0x0030 */ public Vector2f BoxSizeEnd;
                     [NMS(Size = 0x08, Ignore = true)]
        /* 0x0038 */ public byte[] Padding38;
        /* 0x0040 */ public Colour BoxColourEnd;
        /* 0x0050 */ public float BoxThicknessEnd;
                     [NMS(Size = 0x0C, Ignore = true)]
        /* 0x0054 */ public byte[] Padding54;
    }
}
