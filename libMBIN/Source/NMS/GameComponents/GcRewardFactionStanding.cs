using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBCAD9FF33170C830, NameHash = 0x6F652B7C)]
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
