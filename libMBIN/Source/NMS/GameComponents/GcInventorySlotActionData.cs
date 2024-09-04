using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCE59074820C2035A, NameHash = 0xD2238C43)]
    public class GcInventorySlotActionData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public GcAudioWwiseEvents ActionAudio;
        [NMS(Index = 6)]
        /* 0x04 */ public float ScaleAtMax;
        [NMS(Index = 5)]
        /* 0x08 */ public float ScaleAtMin;
        [NMS(Index = 8)]
        /* 0x0C */ public GcAudioWwiseEvents SuitAudio;
        [NMS(Index = 4)]
        /* 0x10 */ public float Time;
        [NMS(Index = 7)]
        /* 0x14 */ public TkCurveType AnimCurve;
        [NMS(Index = 2)]
        /* 0x15 */ public bool Disabled;
        [NMS(Index = 1)]
        /* 0x16 */ public bool Glows;
        [NMS(Index = 0)]
        /* 0x17 */ public bool Loops;
        [NMS(Index = 3)]
        /* 0x18 */ public bool Scales;
    }
}
