using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97BDAE2CC8343746, NameHash = 0xC08D0836890AA2D6)]
    public class GcInventorySlotActionData : NMSTemplate
    {
        /* 0x00 */ public GcAudioWwiseEvents ActionAudio;
        /* 0x04 */ public float ScaleAtMax;
        /* 0x08 */ public float ScaleAtMin;
        /* 0x0C */ public GcAudioWwiseEvents SuitAudio;
        /* 0x10 */ public float Time;
        /* 0x14 */ public TkCurveType AnimCurve;
        /* 0x15 */ public bool Disabled;
        /* 0x16 */ public bool Glows;
        /* 0x17 */ public bool Loops;
        /* 0x18 */ public bool Scales;
    }
}
