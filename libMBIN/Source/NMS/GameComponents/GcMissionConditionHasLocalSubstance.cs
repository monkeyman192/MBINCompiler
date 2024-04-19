using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B12CBDD37A4676F, NameHash = 0xE42DA1D15CDA0F31)]
    public class GcMissionConditionHasLocalSubstance : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A UseScanEventToDetermineLocation;
        /* 0x20 */ public int Amount;
        /* 0x24 */ public float DefaultValueMultiplier;
        /* 0x28 */ public GcLocalSubstanceType LocalSubstanceType;
        /* 0x2C */ public bool TakeAmountFromSeasonData;
        /* 0x2D */ public bool UseDefaultValue;
    }
}
