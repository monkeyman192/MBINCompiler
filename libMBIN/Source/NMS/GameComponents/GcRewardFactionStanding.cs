using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1BAA2CA13DF1EE28, NameHash = 0x8B79DF642602985A)]
    public class GcRewardFactionStanding : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public int AmountMax;
        [NMS(Index = 1)]
        /* 0x4 */ public int AmountMin;
        [NMS(Index = 0)]
        /* 0x8 */ public GcMissionFaction Faction;
        [NMS(Index = 3)]
        /* 0xC */ public bool SetToMinBeforeAdd;
    }
}
