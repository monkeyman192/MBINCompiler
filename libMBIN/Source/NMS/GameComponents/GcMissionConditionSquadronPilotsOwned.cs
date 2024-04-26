using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA18A3B2161D7E0C6, NameHash = 0x8984A8784D46EE5F)]
    public class GcMissionConditionSquadronPilotsOwned : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Amount;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
        [NMS(Index = 2)]
        /* 0x8 */ public bool TakeNumberFromSeasonData;
    }
}
