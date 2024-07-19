using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAB4F70F5FBE22946, NameHash = 0x12DAC7AF)]
    public class GcMissionConditionIsTechnologyRepaired : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 SpecificComponent;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Technology;
        [NMS(Index = 2)]
        /* 0x20 */ public int RepairedComponents;
        [NMS(Index = 1)]
        /* 0x24 */ public GcStatsTypes TechStat;
        [NMS(Index = 4)]
        /* 0x28 */ public bool CountAsRepairIfTechMissing;
    }
}
