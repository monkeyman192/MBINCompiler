using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4EFAF6F13D71CD58, NameHash = 0x627CF21D)]
    public class GcBreakTechByStatData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcStatsTypes DamageTechWithStat;
        [NMS(Index = 1)]
        /* 0x4 */ public bool IncludeStatChildren;
    }
}
