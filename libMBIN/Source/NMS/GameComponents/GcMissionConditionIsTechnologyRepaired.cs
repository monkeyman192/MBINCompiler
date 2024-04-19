using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1F0CB2EA005B49EC, NameHash = 0x24D022A0BCD713A0)]
    public class GcMissionConditionIsTechnologyRepaired : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 SpecificComponent;
        /* 0x10 */ public NMSString0x10 Technology;
        /* 0x20 */ public int RepairedComponents;
        /* 0x24 */ public GcStatsTypes TechStat;
        /* 0x28 */ public bool CountAsRepairIfTechMissing;
    }
}
