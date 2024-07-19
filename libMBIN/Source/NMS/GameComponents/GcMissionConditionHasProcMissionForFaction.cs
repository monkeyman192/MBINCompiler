using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6FCC25E5B17B159A, NameHash = 0x8E70BA89)]
    public class GcMissionConditionHasProcMissionForFaction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcMissionFaction Faction;
    }
}
