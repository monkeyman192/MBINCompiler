using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC27059F47527B0C, NameHash = 0x196A6949)]
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
