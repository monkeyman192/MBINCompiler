using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26EDC0C87D9215A, NameHash = 0x50BA783E)]
    public class GcMissionConditionDefaultItem : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 0)]
        /* 0x10 */ public GcDefaultMissionProductEnum ProductType;
        [NMS(Index = 1)]
        /* 0x14 */ public GcDefaultMissionSubstanceEnum SubstanceType;
    }
}
