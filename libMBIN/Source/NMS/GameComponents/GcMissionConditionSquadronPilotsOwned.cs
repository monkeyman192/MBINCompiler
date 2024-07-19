using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFC0497260F9AD46C, NameHash = 0xD15B1047)]
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
