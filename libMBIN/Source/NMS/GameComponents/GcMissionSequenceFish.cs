using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6D9E1017E68C733B, NameHash = 0xBF805707)]
    public class GcMissionSequenceFish : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public GcFishData TargetFishInfo;
        [NMS(Index = 15)]
        /* 0x58 */ public VariableSizeString DebugText;
        [NMS(Index = 14)]
        /* 0x68 */ public NMSString0x10 FormatStatIntoText;
        [NMS(Index = 0)]
        /* 0x78 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x88 */ public VariableSizeString MessageAvailableNearby;
        [NMS(Index = 4)]
        /* 0x98 */ public VariableSizeString MessageNoFishLaserEquipped;
        [NMS(Index = 3)]
        /* 0xA8 */ public VariableSizeString MessageNoFishLaserInstalled;
        [NMS(Index = 2)]
        /* 0xB8 */ public VariableSizeString MessageNoneInSystem;
        [NMS(Index = 5)]
        /* 0xC8 */ public int Amount;
        [NMS(Index = 11)]
        /* 0xCC */ public float DepthToFormatIntoText;
        [NMS(Index = 6)]
        /* 0xD0 */ public bool FromNow;
        [NMS(Index = 13)]
        /* 0xD1 */ public bool NeverCompleteSequence;
        [NMS(Index = 8)]
        /* 0xD2 */ public bool QualityTestIsEqualOrGreater;
        [NMS(Index = 9)]
        /* 0xD3 */ public bool SizeTestIsEqualOrGreater;
        [NMS(Index = 10)]
        /* 0xD4 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 12)]
        /* 0xD5 */ public bool TakeDepthFromSeasonData;
    }
}
