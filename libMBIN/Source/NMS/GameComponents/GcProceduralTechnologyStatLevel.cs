using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3509A8D11F481CF3, NameHash = 0xF41CD566C844982A)]
    public class GcProceduralTechnologyStatLevel : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public GcStatsTypes Stat;
        [NMS(Index = 2)]
        /* 0x04 */ public float ValueMax;
        [NMS(Index = 1)]
        /* 0x08 */ public float ValueMin;
        [NMS(Index = 3)]
        /* 0x0C */ public GcWeightingCurve WeightingCurve;
        [NMS(Index = 4)]
        /* 0x10 */ public bool AlwaysChoose;
    }
}
