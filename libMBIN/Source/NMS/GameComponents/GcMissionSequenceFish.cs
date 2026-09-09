using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4ABC5D35EF5019BA, NameHash = 0xBF805707)]
    public class GcMissionSequenceFish : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public GcMissionFishData TargetFishInfo;
        [NMS(Index = 19)]
        /* 0x30 */ public VariableSizeString DebugText;
        [NMS(Index = 17)]
        /* 0x40 */ public NMSString0x10 FormatStatIntoText;
        [NMS(Index = 0)]
        /* 0x50 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x60 */ public VariableSizeString MessageAvailableNearby;
        [NMS(Index = 6)]
        /* 0x70 */ public VariableSizeString MessageNoFishLaserEquipped;
        [NMS(Index = 5)]
        /* 0x80 */ public VariableSizeString MessageNoFishLaserInstalled;
        [NMS(Index = 3)]
        /* 0x90 */ public VariableSizeString MessageNoFishLaserKnown;
        [NMS(Index = 4)]
        /* 0xA0 */ public VariableSizeString MessageNoFishLaserKnownNexus;
        [NMS(Index = 2)]
        /* 0xB0 */ public VariableSizeString MessageNoneInSystem;
        [NMS(Index = 7)]
        /* 0xC0 */ public int Amount;
        [NMS(Index = 14)]
        /* 0xC4 */ public float DepthToFormatIntoText;
        [NMS(Index = 8)]
        /* 0xC8 */ public bool FromNow;
        [NMS(Index = 18)]
        /* 0xC9 */ public bool Multiplayer;
        [NMS(Index = 16)]
        /* 0xCA */ public bool NeverCompleteSequence;
        [NMS(Index = 10)]
        /* 0xCB */ public bool QualityTestIsEqualOrGreater;
        [NMS(Index = 11)]
        /* 0xCC */ public bool SizeTestIsEqualOrGreater;
        [NMS(Index = 12)]
        /* 0xCD */ public bool TakeAmountFromDefaultNumber;
        [NMS(Index = 13)]
        /* 0xCE */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 15)]
        /* 0xCF */ public bool TakeDepthFromSeasonData;
    }
}
