using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD64022E0A08BDC5, NameHash = 0x986E86EA3EB2C57C)]
    public class GcMissionConditionFactionRank : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcMissionFaction Faction;
        [NMS(Index = 2)]
        /* 0x4 */ public int Rank;
        [NMS(Index = 1)]
        /* 0x8 */ public bool UseSystemRace;
    }
}
