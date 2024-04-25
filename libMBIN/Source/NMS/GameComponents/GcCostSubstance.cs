using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD13BDB8285D2B04A, NameHash = 0xDDDD3B456E0993D3)]
    public class GcCostSubstance : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A UseScanEventToDetermineLocalSubstance;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 4)]
        /* 0x30 */ public int Amount;
        [NMS(Index = 0)]
        /* 0x34 */ public GcDefaultMissionSubstanceEnum Default;
        [NMS(Index = 3)]
        /* 0x38 */ public GcLocalSubstanceType LocalSubstanceType;
        [NMS(Index = 5)]
        /* 0x3C */ public bool UseDefaultAmount;
    }
}
