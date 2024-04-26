using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F0CB2EA005B49EC, NameHash = 0x24D022A0BCD713A0)]
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
