using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE25758D73FC218D4, NameHash = 0x4027C788)]
    public class GcMissionSequenceCollectLocalSubstance : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A UseScanEventToDetermineLocation;
        [NMS(Index = 11)]
        /* 0x20 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x30 */ public VariableSizeString Message;
        [NMS(Index = 3)]
        /* 0x40 */ public int Amount;
        [NMS(Index = 5)]
        /* 0x44 */ public float DefaultValueMultiplier;
        [NMS(Index = 2)]
        /* 0x48 */ public GcLocalSubstanceType LocalSubstanceType;
        [NMS(Index = 7)]
        /* 0x4C */ public bool CanFormatObjectives;
        [NMS(Index = 9)]
        /* 0x4D */ public bool CanSetIcon;
        [NMS(Index = 8)]
        /* 0x4E */ public bool FromNow;
        [NMS(Index = 10)]
        /* 0x4F */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 4)]
        /* 0x50 */ public bool UseDefaultValue;
        [NMS(Index = 6)]
        /* 0x51 */ public bool WaitForSelected;
    }
}
