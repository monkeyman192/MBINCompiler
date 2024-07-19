using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE934A203E7689F7F, NameHash = 0xD9E54037)]
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
