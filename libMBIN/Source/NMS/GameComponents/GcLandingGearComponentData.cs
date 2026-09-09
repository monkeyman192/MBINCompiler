using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34D8902F21DA2228, NameHash = 0xC1383C3B)]
    public class GcLandingGearComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ExtendAnim;
        [NMS(Index = 7)]
        /* 0x10 */ public NMSString0x10 FlyingAnim;
        [NMS(Index = 1)]
        /* 0x20 */ public float DeployTime;
        [NMS(Index = 6)]
        /* 0x24 */ public GcAudioWwiseEvents EndAudioEvent;
        [NMS(Index = 9)]
        /* 0x28 */ public float LandTime;
        [NMS(Index = 3)]
        /* 0x2C */ public float RetractTime;
        [NMS(Index = 5)]
        /* 0x30 */ public GcAudioWwiseEvents StartAudioEvent;
        [NMS(Index = 8)]
        /* 0x34 */ public float TakeOffTime;
        [NMS(Index = 2)]
        /* 0x38 */ public TkCurveType DeployCurve;
        [NMS(Index = 10)]
        /* 0x39 */ public TkCurveType FlyingCurve;
        [NMS(Index = 4)]
        /* 0x3A */ public TkCurveType RetractCurve;
    }
}
