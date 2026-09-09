using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF7967E76F03B2E89, NameHash = 0x7A7B4ECF)]
    public class GcMissionConditionFactionRank : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcMissionFaction Faction;
        [NMS(Index = 2)]
        /* 0x4 */ public int Rank;
        [NMS(Index = 3)]
        /* 0x8 */ public bool UseSystemGuild;
        [NMS(Index = 1)]
        /* 0x9 */ public bool UseSystemRace;
    }
}
