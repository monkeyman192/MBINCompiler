using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x303BE5A219CAB854, NameHash = 0xBF805707)]
    public class GcMissionSequenceFish : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public GcFishData TargetFishInfo;
        [NMS(Index = 15)]
        /* 0x50 */ public VariableSizeString DebugText;
        [NMS(Index = 14)]
        /* 0x60 */ public NMSString0x10 FormatStatIntoText;
        [NMS(Index = 0)]
        /* 0x70 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x80 */ public VariableSizeString MessageAvailableNearby;
        [NMS(Index = 4)]
        /* 0x90 */ public VariableSizeString MessageNoFishLaserEquipped;
        [NMS(Index = 3)]
        /* 0xA0 */ public VariableSizeString MessageNoFishLaserInstalled;
        [NMS(Index = 2)]
        /* 0xB0 */ public VariableSizeString MessageNoneInSystem;
        [NMS(Index = 5)]
        /* 0xC0 */ public int Amount;
        [NMS(Index = 11)]
        /* 0xC4 */ public float DepthToFormatIntoText;
        [NMS(Index = 6)]
        /* 0xC8 */ public bool FromNow;
        [NMS(Index = 13)]
        /* 0xC9 */ public bool NeverCompleteSequence;
        [NMS(Index = 8)]
        /* 0xCA */ public bool QualityTestIsEqualOrGreater;
        [NMS(Index = 9)]
        /* 0xCB */ public bool SizeTestIsEqualOrGreater;
        [NMS(Index = 10)]
        /* 0xCC */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 12)]
        /* 0xCD */ public bool TakeDepthFromSeasonData;
    }
}
