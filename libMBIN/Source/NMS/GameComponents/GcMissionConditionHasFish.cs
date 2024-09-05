using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD9405A3A0CDF103, NameHash = 0x33020686)]
    public class GcMissionConditionHasFish : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcFishData TargetFishInfo;
        [NMS(Index = 0)]
        /* 0x58 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x5C */ public TkEqualityEnum QualityTest;
        [NMS(Index = 3)]
        /* 0x60 */ public TkEqualityEnum SizeTest;
        [NMS(Index = 4)]
        /* 0x64 */ public bool TakeAmountFromSeasonData;
    }
}
