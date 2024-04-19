using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2A3891A98FCB4498, NameHash = 0x8B79DF642602985A)]
    public class GcRewardFactionStanding : NMSTemplate
    {
        /* 0x0 */ public int AmountMax;
        /* 0x4 */ public int AmountMin;
        /* 0x8 */ public GcMissionFaction Faction;
        /* 0xC */ public bool SetToMinBeforeAdd;
    }
}
