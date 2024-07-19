using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D21708C5EEC9971, NameHash = 0x84CAAF45)]
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
