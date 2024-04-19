using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD13BDB8285D2B04A, NameHash = 0xDDDD3B456E0993D3)]
    public class GcCostSubstance : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A UseScanEventToDetermineLocalSubstance;
        /* 0x20 */ public NMSString0x10 Id;
        /* 0x30 */ public int Amount;
        /* 0x34 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x38 */ public GcLocalSubstanceType LocalSubstanceType;
        /* 0x3C */ public bool UseDefaultAmount;
    }
}
