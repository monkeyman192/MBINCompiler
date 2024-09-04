using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x529DB3F4E9887B2, NameHash = 0x33020686)]
    public class GcMissionConditionHasFish : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcFishData TargetFishInfo;
        [NMS(Index = 0)]
        /* 0x50 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x54 */ public TkEqualityEnum QualityTest;
        [NMS(Index = 3)]
        /* 0x58 */ public TkEqualityEnum SizeTest;
        [NMS(Index = 4)]
        /* 0x5C */ public bool TakeAmountFromSeasonData;
    }
}
