using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9604DA40F24A3887, NameHash = 0x8D9B5B2B496038D9)]
    public class GcMissionConditionHasProcMissionForFaction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcMissionFaction Faction;
    }
}
