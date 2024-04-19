using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD61D8C07EB5B7527, NameHash = 0xF41CD566C844982A)]
    public class GcProceduralTechnologyStatLevel : NMSTemplate
    {
        /* 0x00 */ public GcStatsTypes Stat;
        /* 0x04 */ public float ValueMax;
        /* 0x08 */ public float ValueMin;
        /* 0x0C */ public GcWeightingCurve WeightingCurve;
        /* 0x10 */ public bool AlwaysChoose;
    }
}
