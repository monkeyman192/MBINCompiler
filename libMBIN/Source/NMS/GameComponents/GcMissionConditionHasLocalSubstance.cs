using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B12CBDD37A4676F, NameHash = 0xE42DA1D15CDA0F31)]
    public class GcMissionConditionHasLocalSubstance : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A UseScanEventToDetermineLocation;
        [NMS(Index = 2)]
        /* 0x20 */ public int Amount;
        [NMS(Index = 4)]
        /* 0x24 */ public float DefaultValueMultiplier;
        [NMS(Index = 1)]
        /* 0x28 */ public GcLocalSubstanceType LocalSubstanceType;
        [NMS(Index = 5)]
        /* 0x2C */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 3)]
        /* 0x2D */ public bool UseDefaultValue;
    }
}
